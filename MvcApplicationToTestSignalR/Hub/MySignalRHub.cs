using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace MvcApplicationToTestSignalR.Hub
{
    public class MySignalRHub: Microsoft.AspNet.SignalR.Hub
    {
        public void ErrorMessageBroadcast()
        {
            try
            {
                throw new Exception();
            }
            catch
            {
                Clients.All.broadcastErrorMessage("Holy guacamole! Best check yo self, you're not looking too good."); 
            }
        }
    }
}