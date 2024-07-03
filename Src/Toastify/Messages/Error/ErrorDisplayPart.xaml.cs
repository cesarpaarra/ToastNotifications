using System.Windows;
using Toastify.Core;

namespace Toastify.Messages.Error
{
    /// <summary>
    /// Interaction logic for ErrorDisplayPart.xaml
    /// </summary>
    public partial class ErrorDisplayPart : NotificationDisplayPart
    {
        public ErrorDisplayPart(ErrorMessage error)
        {
            InitializeComponent();
            Bind(error);
        }

        private void OnClose(object sender, RoutedEventArgs e)
        {
            Notification.Close();
        }

        public void ContentWrapper_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Notification.Close();
        }
    }
}
