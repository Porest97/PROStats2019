using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HockeyStats2019.Models;
using PROStats2019.Models;

namespace PROStats2019.Models
{
    public class PROStats2019Context : DbContext
    {
        public PROStats2019Context (DbContextOptions<PROStats2019Context> options)
            : base(options)
        {
        }

        public DbSet<HockeyStats2019.Models.Arena> Arena { get; set; }

        public DbSet<HockeyStats2019.Models.Coach> Coach { get; set; }

        public DbSet<HockeyStats2019.Models.Game> Game { get; set; }

        public DbSet<HockeyStats2019.Models.Player> Player { get; set; }

        public DbSet<HockeyStats2019.Models.Referee> Referee { get; set; }

        public DbSet<HockeyStats2019.Models.RefereeCategory> RefereeCategory { get; set; }

        public DbSet<HockeyStats2019.Models.RefereeCategoryType> RefereeCategoryType { get; set; }

        public DbSet<HockeyStats2019.Models.RefereeDistrict> RefereeDistrict { get; set; }

        public DbSet<HockeyStats2019.Models.RefereeType> RefereeType { get; set; }

        public DbSet<HockeyStats2019.Models.Series> Series { get; set; }

        public DbSet<HockeyStats2019.Models.ShowCase> ShowCase { get; set; }

        public DbSet<HockeyStats2019.Models.Staff> Staff { get; set; }

        public DbSet<HockeyStats2019.Models.Team> Team { get; set; }

        public DbSet<HockeyStats2019.Models.Person> Person { get; set; }

        public DbSet<PROStats2019.Models.Club> Club { get; set; }
    }
}
