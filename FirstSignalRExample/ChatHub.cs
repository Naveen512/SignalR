using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace FirstSignalRExample
{
    public class ChatHub : Hub
    {
       
        public void Send(string Name,string Message)
        {
            Clients.All.broadCastMessage(Name, Message);
        }
    }
}