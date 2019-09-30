using Livet;

namespace WpfSample
{
    public class MainWindowState : NotificationObject
    {
        #region Mode
        
        private MainWindowMode _mode;
        
        public MainWindowMode Mode
        {
            get => _mode;
            set => RaisePropertyChangedIfSet(ref _mode, value);
        }

        #endregion
    }

    public enum MainWindowMode
    {
        User,
        Product
    }
}