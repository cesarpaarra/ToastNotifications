using System;
using Toastify.Core;

namespace Toastify.Lifetime
{
    public class CloseNotificationEventArgs : EventArgs
    {
        public INotification Notification { get; }

        public CloseNotificationEventArgs(INotification notification)
        {
            Notification = notification;
        }
    }
}