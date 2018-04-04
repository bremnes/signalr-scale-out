using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SignalR;

namespace Web
{
    public class TestHub : Hub
    {
        public TestHub(IHostingEnvironment environment)
        {
        }

        public override async Task OnConnectedAsync()
        {
            var connectionID = Context.ConnectionId;
            await base.OnConnectedAsync();
            
            await Clients.Caller.SendAsync("welcomeMessage", connectionID);
            await Clients.Others.SendAsync("newFriendConnected", connectionID);
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            Clients.All.SendAsync("friendLeft", Context.ConnectionId);
            return base.OnDisconnectedAsync(exception);
        }
    }
}