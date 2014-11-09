using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace ICanClick.Core
{
    public class MouseHook : IDisposable
    {
        private const int WH_MOUSE_LL = 14;

        private Win32.LowLevelMouseProc _mouseHookCallBack;
        private bool _isDisposed = false;
        private IntPtr _llMouseHookId = IntPtr.Zero;
        private bool _isEnabled = false;

        public event MouseMessageEventHandler MouseMessage;
        public event EventHandler EnabledChanged;

        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                if (_isEnabled != value)
                {
                    _isEnabled = value;
                    OnEnabledChanged();
                }
            }
        }


        public MouseHook()
        {
            SetHook();
        }

        ~MouseHook()
        {
            Dispose(false);
        }


        private void OnEnabledChanged()
        {
            if (EnabledChanged != null)
            {
                EnabledChanged(this, EventArgs.Empty);
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_isDisposed == false)
            {
                RemoveHook();
                _isDisposed = true;
            }

        }
        protected virtual void OnMouseMessage(MouseMessageEventArgs args)
        {

            if (_isEnabled == true)
            {
                if (MouseMessage != null)
                {
                    MouseMessage(this, args);
                }
            }
        }

        private bool IsHookSet()
        {
            return (_llMouseHookId != IntPtr.Zero);
        }

        private void SetHook()
        {
            if (IsHookSet() == false)
            {
                _mouseHookCallBack = MouseHookCallBack;
                using (Process currentProcess = Process.GetCurrentProcess())
                {
                    using (ProcessModule currentModule = currentProcess.MainModule)
                    {
                        _llMouseHookId = Win32.SetWindowsHookEx(WH_MOUSE_LL, _mouseHookCallBack, Win32.GetModuleHandle(currentModule.ModuleName), 0);
                    }
                }
            }
        }
        private void RemoveHook()
        {
            if (IsHookSet() == true)
            {
                Win32.UnhookWindowsHookEx(_llMouseHookId);
                _mouseHookCallBack = null;
                _llMouseHookId = IntPtr.Zero;
            }
        }
        private IntPtr MouseHookCallBack(int nCode, IntPtr wParam, IntPtr lParam)
        {
            // When the nCode < 0 then the message was not ment for this hook. Just ignore it and pass it through.
            if (nCode >= 0)
            {
                Win32.MSLLHOOKSTRUCT hookStruct = (Win32.MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(Win32.MSLLHOOKSTRUCT));

                MouseMessageEventArgs args = new MouseMessageEventArgs();
                args.Message = (MouseMessage)wParam;
                args.X = hookStruct.pt.x;
                args.Y = hookStruct.pt.y;
                OnMouseMessage(args);

            }
            return Win32.CallNextHookEx(_llMouseHookId, nCode, wParam, lParam);
        }
    }
}
