using Microsoft.AspNetCore.SignalR;

namespace Web_Message_Try2
{
    public class ChatModule : Hub
    {
        public async Task SendMessage(string message, string userName)
        {
            //await Clients.All.SendAsync("ReceiveMessage", message, userName);
            await Clients.User().SendAsync;
        }
    }
}
