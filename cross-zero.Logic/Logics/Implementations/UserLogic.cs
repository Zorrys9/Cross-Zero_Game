using cross_zero.Services.Services;
using Cross_zero.Common.Enums;
using Cross_zero.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cross_zero.Logic.Logics.Implementations
{
    public class UserLogic : IUserLogic
    {

        private readonly IUserService _userService;
        private readonly IHistoryGamesService _historyGamesService;

        public UserLogic(IUserService userService, IHistoryGamesService historyGamesService)
        {

            _userService = userService;
            _historyGamesService = historyGamesService;

        }



        public UsersListViewModel GetUsers(string userId)
        {

            var users = _userService.GetUsersList(userId);

            foreach(var user in users.UsersList)
            {

                var games = _historyGamesService.GetHistoryUser(user.Id);

                user.CountGames = games.Count;

                user.Victory = games.Where(game => (game.UserOne == user.Id && game.Result == ResultGame.VictoryUserOne)
                || (game.UserTwo == user.Id && game.Result == ResultGame.VictoryUserTwo)).ToList().Count;

                user.Lose = games.Where(game => (game.UserOne == user.Id && game.Result == ResultGame.VictoryUserTwo)
                || (game.UserTwo == user.Id && game.Result == ResultGame.VictoryUserOne)).ToList().Count;

                user.CountGamesWithCurrentUser = games.Where(game => (game.UserOne == user.Id && game.UserTwo == userId)
                || (game.UserOne == userId && game.UserTwo == user.Id)).ToList().Count;

                user.CountVictoryWithCurrentUser = games.Where(game => (game.UserOne == user.Id && game.UserTwo == userId && game.Result == ResultGame.VictoryUserOne)
                || (game.UserOne == userId && game.UserTwo == user.Id && game.Result == ResultGame.VictoryUserTwo)).ToList().Count;

                user.CountLoseWithCurrentUser = games.Where(game => (game.UserOne == user.Id && game.UserTwo == userId && game.Result == ResultGame.VictoryUserTwo)
                || (game.UserOne == userId && game.UserTwo == user.Id && game.Result == ResultGame.VictoryUserOne)).ToList().Count;
            }

            if(users.CurrentUser == null)
            {

                users.CurrentUser = users.UsersList.FirstOrDefault(user => user.Id == userId);

                users.UsersList.Remove(users.UsersList.Find(user => user.Id == userId));

            }
            

            return users;
        }

    }
}
