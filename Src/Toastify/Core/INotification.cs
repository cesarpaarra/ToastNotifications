﻿using System;

namespace Toastify.Core
{
    public interface INotification
    {
        int Id { get; set; }

        NotificationDisplayPart DisplayPart { get; }

        void Bind(Action<INotification> closeAction);

        void Close();

        string Message { get; }
        bool CanClose { get; set; }

        MessageOptions Options {get; }
    }
}