using cross_zero.Models;
using cross_zero.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cross_zero.Hubs
{
    [Authorize]
    public class CallHub : Hub
    {

        private readonly IUserService _userService;

        public CallHub(IUserService userService)
        {

            _userService = userService;

        }

        public async Task Call(CallModel model)
        {
            
            await Clients.User(model.To).SendAsync("Call", model);

            //await _userService.AddRoleGamer(new List<string> { model.To, model.From });

        }

        public async Task Play(CallModel model)
        {

            await Clients.User(model.To).SendAsync("Play", model.From);

        }

        public async Task Deny(CallModel model)
        {

            await Clients.User(model.To).SendAsync("Deny", model.From);

            //await _userService.RemoveRoleGamer(new List<string> { model.To, model.From });
        }

        public async Task Cancel(CallModel model)
        {

            await Clients.User(model.To).SendAsync("Cancel", model.From);

            //await _userService.RemoveRoleGamer(new List<string> { model.To, model.From });
        }

        public async Task Refresh()
        {

            await Clients.All.SendAsync("Refresh");

        }
    }
}
