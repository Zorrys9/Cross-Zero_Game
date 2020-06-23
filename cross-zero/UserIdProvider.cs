﻿using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cross_zero
{
    public class UserIdProvider : IUserIdProvider
    {

        public virtual string GetUserId(HubConnectionContext connection)
        {

            return connection.User?.Identity.Name;

        }

    }
}
