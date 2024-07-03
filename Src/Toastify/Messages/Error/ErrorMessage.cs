using System.Windows;
using System.Windows.Input;
using Toastify.Core;
using Toastify.Messages.Core;

namespace Toastify.Messages.Error
{
    public class ErrorMessage : MessageBase<ErrorDisplayPart>
    {
        public ErrorMessage(string message) : this(message, new MessageOptions())
        {
        }

        public ErrorMessage(string message, MessageOptions options) : base(message, options)
        {
        }

        protected override ErrorDisplayPart CreateDisplayPart()
        {
            return new ErrorDisplayPart(this);
        }

        protected override void UpdateDisplayOptions(ErrorDisplayPart displayPart, MessageOptions options)
        {

            if (options.FontSize != null)
            {
                displayPart.FontSize = options.FontSize.Value;
            }

            if (options.ShowCloseButton)
            {
                displayPart.CloseButton.Visibility = Visibility.Visible;
            }
            else
            {
                displayPart.CloseButton.Visibility = Visibility.Collapsed;
                displayPart.ContentWrapper.MouseDown += displayPart.ContentWrapper_MouseDown;
                displayPart.ContentWrapper.Cursor = Cursors.Hand;
            }
        }
    }
}