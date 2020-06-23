using cross_zero.Data.EntityModels;
using Cross_zero.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cross_zero.Data.Repositories
{
    public interface IHistoryGamesRepository
    {

        Task Create(HistoryGamesEntityModel model);
                
        HistoryGamesEntityModel Update(HistoryGamesEntityModel model);

        List<HistoryGamesEntityModel> GetHistoryUser(string userId);

        HistoryGamesEntityModel GetGame(GameViewModel model);
    }

}
