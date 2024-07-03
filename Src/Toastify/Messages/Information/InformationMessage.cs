using System.Windows;
using Toastify.Core;
using Toastify.Messages.Core;
using System.Windows.Input;

namespace Toastify.Messages.Information
{
    public class InformationMessage : MessageBase<InformationDisplayPart>
    {
        public InformationMessage(string message) : this(message, new MessageOptions())
        {
        }

        public InformationMessage(string message, MessageOptions options) : base(message, options)
        {
        }

        protected override InformationDisplayPart CreateDisplayPart()
        {
            return new InformationDisplayPart(this);
        }

        protected override void UpdateDisplayOptions(InformationDisplayPart displayPart, MessageOptions options)
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