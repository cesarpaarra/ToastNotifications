using System.Collections.Generic;
using System.Linq;
using Toastify.Core;

namespace Toastify.Lifetime.Clear
{
    public class ClearAll: IClearStrategy
    {
        public IEnumerable<INotification> GetNotificationsToRemove(NotificationsList notifications)
        {
            return notifications.Select(x => x.Value.Notification);
        }
    }
}