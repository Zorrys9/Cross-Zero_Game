using Cross_zero.Common.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cross_zero.Hubs
{

    public class GameHub : Hub
    {

        public async Task Move(string position, string to)
        {

            await Clients.User(to).SendAsync("Move", position);

        }

        public async Task EndGame(string to, string result)
        {

            await Clients.User(to).SendAsync("EndGame", result);

        }

    }
}
