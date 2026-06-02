using System;

namespace App06_NotificationService.Services
{
    public class NotificationConfig
    {
        public int DefaultNumberOfNotifications { get; set; } = 3;
        public string NotificationStyle { get; set; } = "Compact";

        // CRITICAL FOR WORKING: Event to notify other components to refresh
        public event Action? OnConfigChanged;

        public void NotifyChanged()
        {
            OnConfigChanged?.Invoke();
        }
    }
}