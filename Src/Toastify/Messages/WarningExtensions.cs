using Toastify.Core;
using Toastify.Messages.Warning;

namespace Toastify.Messages
{
    public static class WarningExtensions
    {
        public static void ShowWarning(this Notifier notifier, string message)
        {
            notifier.Notify<WarningMessage>(() => new WarningMessage(message));
        }

        public static void ShowWarning(this Notifier notifier, string message, MessageOptions displayOptions)
        {
            notifier.Notify<WarningMessage>(() => new WarningMessage(message, displayOptions));
        }
    }
}
