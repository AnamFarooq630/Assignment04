using System.Collections.Generic;
using System.Threading.Tasks;

namespace App06_NotificationService.Services
{
    public class NotificationService
    {
        private readonly NotificationConfig _config;

        // Injecting configuration via constructor dependency injection
        public NotificationService(NotificationConfig config)
        {
            _config = config;
        }

        public Task<List<string>> GetNotificationsAsync(int? numberOfNotifications = null)
        {
            int count = numberOfNotifications ?? _config.DefaultNumberOfNotifications;

            var notifications = new List<string>();
            for (int i = 1; i <= count; i++)
            {
                notifications.Add($"Notification alert message #{i}: System data parsed and updated successfully.");
            }

            return Task.FromResult(notifications);
        }
    }
}