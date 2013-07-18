﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.ServiceInterface.Auth;

namespace IN.DOT.DamagedProperty.Api.Services.Infrastructure
{
    public class UserSession : AuthUserSession
    {
        public string Email { get; set; }
    }
}