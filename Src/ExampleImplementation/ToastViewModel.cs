using System.ComponentModel;
using System.Windows;
using Toastify;
using Toastify.Core;
using Toastify.Lifetime;
using Toastify.Messages;
using Toastify.Position;

namespace ExampleImplementation
{
    public class ToastViewModel : INotifyPropertyChanged
    {
        private readonly Notifier _notifier;

        public event PropertyChangedEventHandler? PropertyChanged;

        public ToastViewModel()
        {
            _notifier = new Notifier(cfg =>
            {
                cfg.PositionProvider = new WindowPositionProvider(
                    parentWindow: Application.Current.MainWindow,
                    corner: Corner.BottomRight,
                    offsetX: 25,
                    offsetY: 25);

                cfg.LifetimeSupervisor = new TimeAndCountBasedLifetimeSupervisor(
                    notificationLifetime: TimeSpan.FromSeconds(2),
                    maximumNotificationCount: MaximumNotificationCount.FromCount(6));

                cfg.Dispatcher = Application.Current.Dispatcher;

                cfg.DisplayOptions.TopMost = false;
                cfg.DisplayOptions.Width = 250;
            });
        }

        public void ShowInformation(string message)
        {
            _notifier.ShowInformation(message);
        }

        public void ShowInformation(string message, MessageOptions opts)
        {
            _notifier.ShowInformation(message, opts);
        }

        public void ShowSuccess(string message)
        {
            _notifier.ShowSuccess(message);
        }

        public void ShowSuccess(string message, MessageOptions opts)
        {
            _notifier.ShowSuccess(message, opts);
        }

        public void ShowWarning(string message)
        {
            _notifier.ShowWarning(message);
        }

        public void ShowWarning(string message, MessageOptions opts)
        {
            _notifier.ShowWarning(message, opts);
        }

        public void ShowError(string message)
        {
            _notifier.ShowError(message);
        }

        public void ShowError(string message, MessageOptions opts)
        {
            _notifier.ShowError(message, opts);
        }

        protected virtual void OnPropertyChanged(string? propertyName = null)
        {
            var handler = PropertyChanged;

            if (handler != null)
            {
                handler.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
