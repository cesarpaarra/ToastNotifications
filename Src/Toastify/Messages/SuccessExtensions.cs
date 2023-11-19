using Toastify.Core;
using Toastify.Messages.Success;

namespace Toastify.Messages
{
    public static class SuccessExtensions
    {
        public static void ShowSuccess(this Notifier notifier, string message)
        {
            notifier.Notify<SuccessMessage>(() => new SuccessMessage(message));
        }

        public static void ShowSuccess(this Notifier notifier, string message, MessageOptions displayOptions)
        {
            notifier.Notify<SuccessMessage>(() => new SuccessMessage(message, displayOptions));
        }
    }
}
