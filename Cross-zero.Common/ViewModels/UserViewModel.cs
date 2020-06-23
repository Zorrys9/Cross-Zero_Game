using System;
using System.Collections.Generic;
using System.Text;

namespace Cross_zero.Common.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }

        public int CountGames { get; set; }

        public int Victory { get; set; }
        public int Lose { get; set; }

        public int CountGamesWithCurrentUser { get; set; }

        public int CountVictoryWithCurrentUser { get; set; }

        public int CountLoseWithCurrentUser { get; set; }

    }
}
