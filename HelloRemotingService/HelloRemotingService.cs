﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloRemotingService
{
    public class HelloRemotingService : MarshalByRefObject,
        IHelloRemotingService.IHelloRemtingService
    {
        public string GetMessage(string name)
        {
            return "Hello " + name;
        }
    }
}