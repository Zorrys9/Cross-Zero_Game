using Cross_zero.Common.ViewModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace cross_zero.Services.Services.Implementations
{
    public class UserService : IUserService
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public UserService(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {

            _signInManager = signInManager;
            _userManager = userManager;

        }


        public async Task<IdentityResult> Create(RegistrationViewModel model)
        {

            if(model != null)
            {

                var user = new IdentityUser
                {

                    UserName = model.UserName,
                    Email = model.Email,
                    PhoneNumber = model.Phone
                };

                var created = await _userManager.CreateAsync(user, model.Password);

                if (created.Succeeded)
                {

                    await _userManager.AddToRoleAsync(user, "User");

                    return created;
                }
                else
                {

                    throw new Exception("При регистрации возникла ошибка");

                }

            }
            else
            {

                throw new Exception("Данные для регистрации не заполнены");

            }
        }


        public async Task<SignInResult> LogIn(LoginViewModel model)
        {

            if(model != null)
            {

                return await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, false);

            }
            else
            {

                throw new Exception("Данные для входа в систему не заполнены");

            }

        }

        public async Task LogOut()
        {

            await _signInManager.SignOutAsync();

        }

        public UsersListViewModel GetUsersList(string userId)
        {

            var users = _userManager.GetUsersInRoleAsync("User").Result;
            UsersListViewModel usersList = new UsersListViewModel();
            usersList.UsersList = new List<UserViewModel>();
            foreach(var user in users)
            {

                    UserViewModel newUser = new UserViewModel()
                    {

                        UserName = user.UserName,
                        Id = user.Id

                    };

                    usersList.UsersList.Add(newUser);

            }

            var gamers = _userManager.GetUsersInRoleAsync("Gamer").Result.FirstOrDefault(user => user.Id == userId);

            if(gamers != null)
            {
                usersList.CurrentUser = new UserViewModel();
                usersList.CurrentUser.UserName = gamers.UserName;
                usersList.CurrentUser.Id = gamers.Id;

            }

            return usersList;

        }

        public async Task AddRoleGamer(List<string> userNames)
        {

            foreach (var userName in userNames)
            {

                var user = await _userManager.FindByNameAsync(userName);

                await _userManager.AddToRoleAsync(user, "Gamer");
                await _userManager.RemoveFromRoleAsync(user, "User");

            }

        }

        public async Task RemoveRoleGamer(List<string> userNames)
        {

            foreach (var userName in userNames)
            {

                var user = await _userManager.FindByNameAsync(userName);

                await _userManager.RemoveFromRoleAsync(user, "Gamer");
                await _userManager.AddToRoleAsync(user, "User");

            }

        }

        public async Task<bool> CheckUser(string userName)
        {

            var user = await _userManager.FindByNameAsync(userName);

            return true;
        }

        public async Task<string> GetUserName(string userId)
        {

            var result = await _userManager.FindByIdAsync(userId);

            return result.UserName;

        }

        public async Task<string> GetUserId(string userName)
        {

            var result = await _userManager.FindByNameAsync(userName);

            return result.Id;

        }

    }
}
