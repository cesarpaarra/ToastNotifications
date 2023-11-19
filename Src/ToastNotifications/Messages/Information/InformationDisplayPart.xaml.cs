﻿using System.Windows;
using ToastNotifications.Core;

namespace ToastNotifications.Messages.Information
{
    /// <summary>
    /// Interaction logic for InformationDisplayPart.xaml
    /// </summary>
    public partial class InformationDisplayPart : NotificationDisplayPart
    {
        public InformationDisplayPart(InformationMessage Information)
        {
            InitializeComponent();
            Bind(Information);
        }

        private void OnClose(object sender, RoutedEventArgs e)
        {
            Notification.Close();
        }
    }
}