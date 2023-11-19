using System.Windows;
using Toastify.Core;
using Toastify.Messages.Core;

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

            displayPart.CloseButton.Visibility = options.ShowCloseButton ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}