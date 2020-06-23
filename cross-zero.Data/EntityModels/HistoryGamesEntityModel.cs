using Cross_zero.Common.Enums;
using Cross_zero.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace cross_zero.Data.EntityModels
{
    public class HistoryGamesEntityModel
    {
        public Guid Id { get; set; }

        public string UserOne { get; set; }

        public string UserTwo { get; set; }

        public ResultGame Result { get; set; }




        public static implicit operator HistoryGamesEntityModel(GameViewModel model)
        {
            if (model != null)
            {

                return new HistoryGamesEntityModel
                {

                    Id = model.Id,
                    UserOne = model.UserOne,
                    UserTwo = model.UserTwo,
                    Result = model.Result

                };

            }
            else
            {

                return null;

            }
        }

        public static implicit operator GameViewModel(HistoryGamesEntityModel model)
        {
            if (model != null)
            {

                return new GameViewModel
                {

                    Id = model.Id,
                    UserOne = model.UserOne,
                    UserTwo = model.UserTwo,
                    Result = model.Result

                };

            }
            else
            {

                return null;

            }
        }

    }
}
