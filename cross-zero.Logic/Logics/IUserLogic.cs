using Cross_zero.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace cross_zero.Logic.Logics
{
    public interface IUserLogic
    {

        UsersListViewModel GetUsers(string userId);

    }
}
