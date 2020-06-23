using Cross_zero.Common.ViewModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cross_zero.Services.Services
{
    public interface IUserService
    {

        Task<IdentityResult> Create(RegistrationViewModel model);

        Task<SignInResult> LogIn(LoginViewModel model);

        Task LogOut();

        UsersListViewModel GetUsersList(string userId);

        Task AddRoleGamer(List<string> userNames);

        Task RemoveRoleGamer(List<string> userNames);

        Task<string> GetUserName(string userId);

        Task<string> GetUserId(string userName);
    }
}
