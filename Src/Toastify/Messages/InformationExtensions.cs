using Toastify.Core;
using Toastify.Messages.Information;

namespace Toastify.Messages
{
    public static class InformationExtensions
    {
        public static void ShowInformation(this Notifier notifier, string message)
        {
            notifier.Notify<InformationMessage>(() => new InformationMessage(message));
        }

        public static void ShowInformation(this Notifier notifier, string message, MessageOptions displayOptions)
        {
            notifier.Notify<InformationMessage>(() => new InformationMessage(message, displayOptions));
        }
    }
}
