﻿using System;
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

        public DbSet<PROStats2019.Models.ProGame> ProGame { get; set; }

        public DbSet<PROStats2019.Models.GameStatus> GameStatus { get; set; }

        public DbSet<PROStats2019.Models.PaymentPost> PaymentPost { get; set; }

        public DbSet<PROStats2019.Models.Sport> Sport { get; set; }

        public DbSet<PROStats2019.Models.PROModels.PROGames2012> PROGames2012 { get; set; }

        public DbSet<PROStats2019.Models.PROModels.PROGames2013> PROGames2013 { get; set; }

        public DbSet<PROStats2019.Models.PROModels.PROGames2014> PROGames2014 { get; set; }

        public DbSet<PROStats2019.Models.PROModels.PROGames2015> PROGames2015 { get; set; }

        public DbSet<PROStats2019.Models.PROModels.PROGames2016> PROGames2016 { get; set; }

        public DbSet<PROStats2019.Models.PROModels.PROGames2017> PROGames2017 { get; set; }

        public DbSet<PROStats2019.Models.PROModels.PROGames2018> PROGames2018 { get; set; }

        public DbSet<PROStats2019.Models.PROModels.PROGames2019> PROGames2019 { get; set; }

        public DbSet<PROStats2019.Models.Location> Location { get; set; }

        public DbSet<PROStats2019.Models.Workout> Workout { get; set; }

        public DbSet<PROStats2019.Models.Country> Country { get; set; }

        public DbSet<PROStats2019.Models.Tournament> Tournament { get; set; }

        public DbSet<PROStats2019.Models.MatchLength> MatchLength { get; set; }

        public DbSet<PROStats2019.Models.MatchReporting> MatchReporting { get; set; }

        public DbSet<PROStats2019.Models.MatchTime> MatchTime { get; set; }

        public DbSet<PROStats2019.Models.RefereeLevel> RefereeLevel { get; set; }

        public DbSet<PROStats2019.Models.TableSystem> TableSystem { get; set; }

        public DbSet<PROStats2019.Models.TeamNotification> TeamNotification { get; set; }

        public DbSet<PROStats2019.Models.TeamOfficial> TeamOfficial { get; set; }

        public DbSet<PROStats2019.Models.TeamRegister> TeamRegister { get; set; }

        public DbSet<PROStats2019.Models.TournamentPhase> TournamentPhase { get; set; }

        public DbSet<PROStats2019.Models.TeamRegistration> TeamRegistration { get; set; }

        public DbSet<PROStats2019.Models.RefereeFee> RefereeFee { get; set; }

        


    }
}
