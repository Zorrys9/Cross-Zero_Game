using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace cross_zero.Extensions
{
    public static class ControllerExtensions
    {


        public static string CurrentUser(this Controller controller)
        {

            ClaimsPrincipal user = controller.User;
            return user.FindFirst(ClaimTypes.NameIdentifier).Value;


        }

    }
}
