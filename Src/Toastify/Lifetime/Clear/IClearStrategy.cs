using System.Collections.Generic;
using Toastify.Core;

namespace Toastify.Lifetime.Clear
{
    public interface IClearStrategy
    {
        IEnumerable<INotification> GetNotificationsToRemove(NotificationsList notifications);
    }
}