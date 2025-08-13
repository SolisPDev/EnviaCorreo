using System.Windows;

namespace EnviarCorreo
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            if (e.Args.Length > 0)
            {
                MainWindow mainWindow = new MainWindow(e.Args);
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("No se recibieron argumentos.");
                Shutdown();
            }
        }
    }
}