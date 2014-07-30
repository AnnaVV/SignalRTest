using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace MvcApplicationToTestSignalR.Hub
{
    public class MySignalRHub: Microsoft.AspNet.SignalR.Hub
    {
        public void MyMethod(int n)
        {
            var res = n * n;
            Clients.All.Pow(res);
        }
    }
}