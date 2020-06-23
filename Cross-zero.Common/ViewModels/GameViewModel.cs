using Cross_zero.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cross_zero.Common.ViewModels
{
    public class GameViewModel
    {

        public Guid Id { get; set; }

        public string UserOne { get; set; }
        public string UserNameOne { get; set; }
        public string FigureOne { get; set; }

        public string UserTwo { get; set; }
        public string UserNameTwo { get; set; }
        public string FigureTwo { get; set; }

        public ResultGame Result { get; set; }

    }
}
