using Cross_zero.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cross_zero.Logic.Logics
{
    public interface IGameLogic
    {

        Task<GameViewModel> GetGame(GameViewModel model);

        Task CreateGame(GameViewModel model);
    }
}
