﻿using FastTunnel.Core.Client;
using FastTunnel.Core.Filters;
using FastTunnel.Core.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastTunnel.Server.Filters
{
    public class TestAuthenticationFilter : IAuthenticationFilter
    {
        public bool Authentication(FastTunnelServer server, LogInMassage requet)
        {
            if (string.IsNullOrEmpty(server.ServerSettings.Token))
                return true;

            return server.ServerSettings.Token.Equals(requet.Token);
        }
    }
}
