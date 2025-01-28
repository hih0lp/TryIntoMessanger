using Microsoft.AspNetCore.SignalR;

namespace Web_Message_Try2
{
    public class ChatHub : Hub
    {
        

        public async Task SendMessage(string message, string userName, string connectionID) //
        {
            await Clients.Client(connectionID).SendAsync("ReceiveMessage", message, userName);
            //await Clients.User().SendAsync;            
        }
    }
}


