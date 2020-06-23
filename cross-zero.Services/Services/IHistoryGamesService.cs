using Cross_zero.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cross_zero.Services.Services
{
    public interface IHistoryGamesService
    {

        Task Create(GameViewModel model);

        GameViewModel Update(GameViewModel model);

        List<GameViewModel> GetHistoryUser(string userId);

        GameViewModel GetGame(GameViewModel model);

    }
}
