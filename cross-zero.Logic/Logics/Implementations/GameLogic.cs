using cross_zero.Services.Services;
using Cross_zero.Common.Enums;
using Cross_zero.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cross_zero.Logic.Logics.Implementations
{
    public class GameLogic :IGameLogic
    {

        private readonly IUserService _userService;
        private readonly IHistoryGamesService _gameService;

        public GameLogic(IUserService userService, IHistoryGamesService historyGamesService)
        {

            _userService = userService;
            _gameService = historyGamesService;

        }


        public async Task CreateGame(GameViewModel model)
        {

            model.UserOne = await _userService.GetUserId(model.UserNameOne);
            model.UserTwo = await _userService.GetUserId(model.UserNameTwo);

            model.Result = ResultGame.None;

            await _gameService.Create(model);

        }

        public async Task EndGame(GameViewModel model)
        {

            model.UserOne = await _userService.GetUserId(model.UserNameOne);
            model.UserTwo = await _userService.GetUserId(model.UserNameTwo);

            _gameService.Update(model);
        }

        public async Task<GameViewModel> GetGame(GameViewModel model)
        {
        
            model.UserOne = await _userService.GetUserId(model.UserNameOne);
            model.UserTwo = await _userService.GetUserId(model.UserNameTwo);

            var result = _gameService.GetGame(model);

            if(result != null)
            {

                result.UserNameOne = await _userService.GetUserName(result.UserOne);
                result.UserNameTwo = await _userService.GetUserName(result.UserTwo);

                Random r = new Random();

                var numberFigure = r.Next(1, 2);

                switch (numberFigure)
                {

                    case 1:
                        result.FigureOne = "cross";
                        result.FigureTwo = "zero";
                        break;
                    case 2:
                        result.FigureOne = "zero";
                        result.FigureTwo = "cross";
                        break;
                }

                return result;

            }
            else
            {

                throw new Exception("Игра не найдена");

            }

        }

    }
}
