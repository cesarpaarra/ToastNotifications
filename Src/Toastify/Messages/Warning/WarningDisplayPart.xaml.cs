﻿using System.Windows;
using Toastify.Core;

namespace Toastify.Messages.Warning
{
    /// <summary>
    /// Interaction logic for WarningDisplayPart.xaml
    /// </summary>
    public partial class WarningDisplayPart : NotificationDisplayPart
    {
        public WarningDisplayPart(WarningMessage warning)
        {
            InitializeComponent();
            Bind(warning);
        }

        private void OnClose(object sender, RoutedEventArgs e)
        {
            Notification.Close();
        }

        public void ContentWrapper_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Notification.Close();
        }
    }
}
