using System.Collections.Generic;
using System.Linq;
using Toastify.Core;

namespace Toastify.Lifetime.Clear
{
    public class ClearByMessage : IClearStrategy
    {
        private readonly string _message;

        public ClearByMessage(string message)
        {
            _message = message;
        }

        public IEnumerable<INotification> GetNotificationsToRemove(NotificationsList notifications)
        {
            var notificationsToRemove = notifications
                .Select(x => x.Value.Notification)
                .Where(x => x.Message == _message)
                .ToList();

            return notificationsToRemove;
        }
    }
}