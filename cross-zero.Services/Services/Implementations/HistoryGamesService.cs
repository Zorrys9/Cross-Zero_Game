using cross_zero.Data.Repositories;
using Cross_zero.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cross_zero.Services.Services.Implementations
{
    public class HistoryGamesService : IHistoryGamesService
    {

        private readonly IHistoryGamesRepository _historyGamesRepository;

        public HistoryGamesService(IHistoryGamesRepository historyGamesRepository)
        {

            _historyGamesRepository = historyGamesRepository;

        }




        public async Task Create(GameViewModel model)
        {
            if(model != null)
            {

                await _historyGamesRepository.Create(model);

            }
            else
            {

                throw new Exception("Данные игры не заполнены");

            }
        }

        public GameViewModel Update(GameViewModel model)
        {
            if (model != null)
            {

                var result = _historyGamesRepository.Update(model);

                return result;

            }
            else
            {

                throw new Exception("Данные игры не заполнены");

            }
        }

        public List<GameViewModel> GetHistoryUser(string userId)
        {
            if (userId != null)
            {

                var result = _historyGamesRepository.GetHistoryUser(userId);
                List<GameViewModel> games = new List<GameViewModel>();

                foreach(var game in result)
                {

                    games.Add(game);

                }

                return games;

            }
            else
            {

                throw new Exception("Пользователь не указан");

            }
        }

        public GameViewModel GetGame(GameViewModel model)
        {
            if(model != null)
            {

                return _historyGamesRepository.GetGame(model);

            }
            else
            {

                throw new Exception("Данные игры не указаны");

            }
        }

    }
}
