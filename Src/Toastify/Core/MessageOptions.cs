﻿using System;

namespace Toastify.Core
{
    public class MessageOptions
    {
        public double? FontSize { get; set; }

        public bool ShowCloseButton { get; set; } = false;

        public object Tag { get; set; }

        public bool FreezeOnMouseEnter { get; set; } = true;

        public Action<NotificationBase> NotificationClickAction { get; set; }

        public Action<NotificationBase> CloseClickAction { get; set; }

        public bool UnfreezeOnMouseLeave { get; set; } = true;
    }
}
