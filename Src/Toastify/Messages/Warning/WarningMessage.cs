using System.Windows;
using System.Windows.Input;
using Toastify.Core;
using Toastify.Messages.Core;

namespace Toastify.Messages.Warning
{
    public class WarningMessage : MessageBase<WarningDisplayPart>
    {
        public WarningMessage(string message) : this(message, new MessageOptions())
        {
        }

        public WarningMessage(string message, MessageOptions options) : base(message, options)
        {
        }

        protected override WarningDisplayPart CreateDisplayPart()
        {
            return new WarningDisplayPart(this);
        }

        protected override void UpdateDisplayOptions(WarningDisplayPart displayPart, MessageOptions options)
        {
            if (options.FontSize != null)
            {
                displayPart.Text.FontSize = options.FontSize.Value;
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