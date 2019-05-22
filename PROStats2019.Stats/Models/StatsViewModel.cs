using HockeyStats2019.Models;
using PROStats2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROStats2019.Stats.Models
{
    public class StatsViewModel
    {
        public List<Arena> Arenas { get; set; }

        public List<Club> Clubs { get; set; }

        public List<Coach> CoachesStatuses { get; set; }

        public List<Game> Games { get; set; }

        public List<GameStatus> GameStatuses { get; set; }

        public List<PaymentPost> PaymentPosts { get; set; }

        public List<Person> People { get; set; }

        public List<Player> PlayerStatus { get; set; }

        public List<ProGame> ProGames { get; set; }

        public List<Referee> RefereeStatuses { get; set; }

        public List<RefereeCategory> RefereeCategories { get; set; }

        public List<RefereeCategoryType> RefereeCategoryTypes { get; set; }

        public List<RefereeDistrict> RefereeDistricts { get; set; }

        public List<RefereeType> RefereeTypes { get; set; }

        public List<Series> Series { get; set; }

        public List<ShowCase> ShowCases { get; set; }

        public List<Sport> Sports { get; set; }

        public List<Staff> StaffStatuses { get; set; }

        public List<Team> Teams { get; set; }

        public List<Workout> Workouts { get; set; }
                
    }
}
