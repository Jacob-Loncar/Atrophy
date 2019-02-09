using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace AtrophyWebAppAPI.Hubs
{
    public class TestHub : Hub
    {
        public void Hello(string name)
        {
            string message = name + ": test hub is working.";

            Clients.All.hello(message);
        }

        public void TestMethodCall()
        {
            Hello("TestMethodCall");
        }

        public void TestMethodCallWithParams(string name)
        {
            Hello(name);
        }
    }
}