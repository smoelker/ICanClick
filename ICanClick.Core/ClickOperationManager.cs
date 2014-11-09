using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace ICanClick.Core
{
    internal class ClickOperationManager : IDisposable
    {
        private Timer _mouseStopTimer;
        private MouseHook _mouseHook;
        private ClickOperation _currentClickOperation = ClickOperation.SingleClickLeftButton;
        private bool _isDragging = false;

        public event ClickOperationSelectedEventHandler ClickOperationSelected;


        public ClickOperation CurrentClickOperation
        {
            get { return _currentClickOperation; }
        }
        public bool IsEnabled
        {
            get { return _mouseHook.IsEnabled; }
            set { _mouseHook.IsEnabled = value; }
        }
        public MouseHook MouseHook
        {
            get { return _mouseHook; }
        }
        public int ClickInterval
        {
            get
            {
                return _mouseStopTimer.Interval;
            }
            set
            {
                if (_mouseStopTimer.Interval != value)
                {
                    _mouseStopTimer.Interval = value;
                    if (_mouseStopTimer.Enabled == true)
                    {
                        _mouseStopTimer.Stop();
                        _mouseStopTimer.Start();
                    }
                }
            }
        }

        public ClickOperationManager()
        {
            _mouseHook = new MouseHook();
            _mouseStopTimer = new Timer();
            _mouseStopTimer.Interval = 750;
            _mouseStopTimer.Tick += _mouseStopTimer_Tick;
            _mouseHook.MouseMessage += _mouseHook_MouseMessage;
        }

        ~ClickOperationManager()
        {
            Dispose(false);
        }

        public void SelectClickOperation(ClickOperation clickOperation)
        {
            if (clickOperation != _currentClickOperation)
            {
                _currentClickOperation = clickOperation;
                OnClickOperationSelected(new ClickOperationSelectedEventArgs(_currentClickOperation));
            }
        }

        private void SelectDefaultClickOperation()
        {
            if (_currentClickOperation != ClickOperation.SingleClickLeftButton)
            {
                SelectClickOperation(ClickOperation.SingleClickLeftButton);
            }
        }

        private void CancelClickOperation()
        {

        }

        private void ExecuteCurrentClickOperation()
        {
            _mouseStopTimer.Stop();

#if DEBUG
            Debug.WriteLine("Executing click operation: " + _currentClickOperation.ToString());
#endif

            switch (_currentClickOperation)
            {
                case ClickOperation.SingleClickLeftButton:
                    {
                        MouseClickSimulator.SingleClickLeft();
                        break;
                    }
                case ClickOperation.SingleClickMiddleButton:
                    {
                        MouseClickSimulator.SingleClickMiddle();
                        break;
                    }
                case ClickOperation.SingleClickRightButton:
                    {
                        MouseClickSimulator.SingleClickRight();
                        break;
                    }
                case ClickOperation.DoubleClickLeftButton:
                    {
                        MouseClickSimulator.DoubleClickLeft();
                        break;
                    }
                case ClickOperation.DragLeftButton:
                    {
                        if (_isDragging)
                        {
                            MouseClickSimulator.EndDragLeft();
                            _isDragging = false;
                        }
                        else
                        {
                            MouseClickSimulator.BeginDragLeft();
                            _isDragging = true;
                        }
                        break;
                    }
                //case ClickOperation.DragRightButton:
                //    {
                //        if(_isDragging)
                //        {
                //            MouseClickSimulator.EndDragRight();
                //            _isDragging = false;
                //        }
                //        else
                //        {
                //            MouseClickSimulator.BeginDragRight();
                //            _isDragging = true;
                //        }
                //        break;
                //    }
            }
            if (!_isDragging)
            {
                SelectDefaultClickOperation();
            }
        }

        private void _mouseHook_MouseMessage(object sender, MouseMessageEventArgs e)
        {
            lock (_mouseStopTimer)
            {
                if (e.Message == MouseMessage.WM_MOUSEMOVE)
                {
                    if (!_mouseStopTimer.Enabled)
                    {
                        _mouseStopTimer.Start();
                    }
                    else
                    {
                        _mouseStopTimer.Stop();
                        _mouseStopTimer.Start();
                    }
                }
            }
        }

        private void _mouseStopTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                ExecuteCurrentClickOperation();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposeManagedResources)
        {
            if (disposeManagedResources)
            {
                // dispose managed resources...
            }
            if (_mouseStopTimer != null)
            {
                _mouseStopTimer.Dispose();
            }
            if (_mouseHook != null)
            {
                _mouseHook.Dispose();
            }
        }

        protected virtual void OnClickOperationSelected(ClickOperationSelectedEventArgs args)
        {

#if DEBUG
            Debug.WriteLine("Click operation selected: " + args.ClickOperation.ToString());
#endif
            if (ClickOperationSelected != null)
            {
                ClickOperationSelected(this, args);
            }
        }
    }
}
