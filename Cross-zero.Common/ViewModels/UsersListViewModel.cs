using System;
using System.Collections.Generic;
using System.Text;

namespace Cross_zero.Common.ViewModels
{
    public class UsersListViewModel
    {

        public UserViewModel CurrentUser { get; set; }

        public List<UserViewModel> UsersList { get; set; }


    }
}
