using System.Windows;
using Toastify.Core;
using Toastify.Messages.Core;

namespace Toastify.Messages.Success
{
    public class SuccessMessage : MessageBase<SuccessDisplayPart>
    {
        public SuccessMessage(string message) : this(message, new MessageOptions())
        {
        }

        public SuccessMessage(string message, MessageOptions options) : base(message, options)
        {
        }

        protected override SuccessDisplayPart CreateDisplayPart()
        {
            return new SuccessDisplayPart(this);
        }

        protected override void UpdateDisplayOptions(SuccessDisplayPart displayPart, MessageOptions options)
        {
            if (options.FontSize != null)
            {
                displayPart.FontSize = options.FontSize.Value;
            }

            displayPart.CloseButton.Visibility = options.ShowCloseButton ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}