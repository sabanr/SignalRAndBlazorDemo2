using Microsoft.AspNetCore.SignalR;

namespace Notifications.Api;

public class NotificationsHub : Hub<INotificationClient>
{
   public override async Task OnConnectedAsync()
   {
      await Clients.Client(Context.ConnectionId).ReceiveNotification($"Thank for connecting {Context.User?.Identity?.Name}");
      await base.OnConnectedAsync();
   }
}