using System.Collections.Generic;
using System.Linq;
using Toastify.Core;

namespace Toastify.Lifetime.Clear
{
    public class ClearLast : IClearStrategy
    {
        public IEnumerable<INotification> GetNotificationsToRemove(NotificationsList notifications)
        {
            if (notifications.IsEmpty)
            {
                return Enumerable.Empty<INotification>();
            }

            var lastMessage = notifications.LastOrDefault().Value.Notification;

            return new[] {lastMessage};
        }
    }
}