using Inventory_Management_System_For_Windows.Utilities;
using System.Windows;

namespace Inventory_Management_System_For_Windows
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static System.Threading.Mutex? mutex;

        protected override void OnStartup(StartupEventArgs e)
        {
            mutex = new System.Threading.Mutex(true, "OnlyRun_CRNS");
            if (mutex.WaitOne(0, false))
            {
                base.OnStartup(e);
            }
            else
            {
                // MessageBox.Show("程序已经在运行！", "提示");
                Shutdown();
            }
        }

        protected override void OnExit(ExitEventArgs e)
        {

            DatabaseUtility.GetInstance().Close();
            base.OnExit(e);
        }
    }

}
