using cross_zero.Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Cross_zero.Common.ViewModels;
using Cross_zero.Common.Enums;

namespace cross_zero.Data.Repositories.Implementations
{
    public class HistoryGamesRepository : IHistoryGamesRepository
    {
        private readonly GameContext _gameContext;

        public HistoryGamesRepository(GameContext gameContext)
        {
            _gameContext = gameContext;
        }


        public async Task Create(HistoryGamesEntityModel model)
        {

            await _gameContext.HistoryGames.AddAsync(model);
            await _gameContext.SaveChangesAsync();
        }

        public HistoryGamesEntityModel Update(HistoryGamesEntityModel model)
        {

            var game = GetGame(model);

            game.UserOne = model.UserOne;
            game.UserTwo = model.UserTwo;

            game.Result = model.Result;

            _gameContext.SaveChanges();

            return model;

        }

        public List<HistoryGamesEntityModel> GetHistoryUser(string userId)
        {

           return _gameContext.HistoryGames.Where(game => game.UserOne == userId || game.UserTwo == userId).ToList();

        }

        public HistoryGamesEntityModel GetGame(GameViewModel model)
        {

            return _gameContext.HistoryGames.FirstOrDefault(game => ((game.UserOne == model.UserOne && game.UserTwo == model.UserTwo) || (game.UserOne == model.UserTwo && game.UserTwo == model.UserOne)) && game.Result == ResultGame.None);

        }

    }
}
