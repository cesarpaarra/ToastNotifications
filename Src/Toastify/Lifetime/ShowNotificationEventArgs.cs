using System;
using Toastify.Core;

namespace Toastify.Lifetime
{
    public class ShowNotificationEventArgs : EventArgs
    {
        public INotification Notification { get; }

        public ShowNotificationEventArgs(INotification notification)
        {
            Notification = notification;
        }
    }
}