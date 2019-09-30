using System.Windows;

namespace WpfSample
{
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainWindowState = new MainWindowState();

            new MainWindow
            {
                DataContext = new MainWindowViewModel(mainWindowState)
            }.Show();
        }
    }
}
