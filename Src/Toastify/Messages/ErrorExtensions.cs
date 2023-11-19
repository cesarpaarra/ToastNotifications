using Toastify.Core;
using Toastify.Messages.Error;

namespace Toastify.Messages
{
    public static class ErrorExtensions
    {
        public static void ShowError(this Notifier notifier, string message)
        {
            notifier.Notify<ErrorMessage>(() => new ErrorMessage(message));
        }

        public static void ShowError(this Notifier notifier, string message, MessageOptions displayOptions)
        {
            notifier.Notify<ErrorMessage>(() => new ErrorMessage(message, displayOptions));
        }
    }
}
