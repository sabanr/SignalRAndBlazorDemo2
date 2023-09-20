namespace Notifications.Api;

public interface INotificationClient
{
    Task ReceiveNotification(string message);
}