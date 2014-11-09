using System;
using System.Windows.Forms;
using ICanClick.Core;
using System.Diagnostics;
using System.Threading;

namespace ICanClick
{
	internal sealed class Program
	{
        public const string GUID = "269C01C6-91AA-4DF2-9BBE-4E2E80F1E55A";

        [STAThread]
        private static void Main(string[] args)
        {
            AppDomain appDomain = Thread.GetDomain();
            
            appDomain.UnhandledException += Program_UnhandledException;
            Application.ThreadException += Application_ThreadException;
            
            bool newMutexCreated;
            using (Mutex m = new Mutex(true, GUID, out newMutexCreated))
            {
                if (newMutexCreated == true)
                {
                    RunProgram();
                }
            }
        }

        private static void RunProgram()
        {
            using (ApplicationClass application = new ApplicationClass())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm(application));
            }
        }

        private static void Program_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            FatalError(e.ExceptionObject);
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            FatalError(e.Exception);
        }

        static void FatalError(object ex)
        {
            string message = "An unexpected error occured. ICanClick will be terminated.";
            if (ex != null && ex is Exception)
            {
                message += "\r\n\r\nDetails:\r\n" + ((Exception)ex).Message;
            }
            DialogResult result = MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Process.GetCurrentProcess().Kill();
        }
	}
}
