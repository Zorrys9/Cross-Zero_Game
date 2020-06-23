using cross_zero.Data.EntityModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cross_zero.Data
{
    public class GameContext : IdentityDbContext
    {

        public DbSet<HistoryGamesEntityModel> HistoryGames { get; set; }

        public GameContext(DbContextOptions<GameContext> options)
                : base(options)   
        {

            if (Roles.Count() == 0)
            {

                Roles.AddRange(
                    new IdentityRole { Name = "User", NormalizedName = "USER" },
                    new IdentityRole { Name = "Gamer", NormalizedName = "GAMER"}
                    );

            }

        }

    }
}
