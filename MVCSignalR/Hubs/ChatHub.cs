using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace MVCSignalR.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string Name,string Message)
        {
            Clients.All.addNewMessageToPage(Name, Message);
        }
    }
}