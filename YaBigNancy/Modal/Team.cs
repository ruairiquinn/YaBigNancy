using System.Collections.Generic;

namespace YaBigNancy.Modal
{
    public class Team
    {
        public string Name { get; set; }
        public Manager Manager { get; set; }
        public IList<Player> Players { get; set; }
    }

    public static class SeedTeams
    {
        public static IList<Team> Seed()
        {
            var teams = new List<Team>();

            var liverpool = new Team
            {
                Name = "Liverpool",
                Manager = new Manager { Id = 1, Forename = "Brendan", Surname = "Rogers" },
                Players = new List<Player>
                                                 {
                                                     new Player {Id = 2, Forename = "Steven", Surname = "Gerrard"},
                                                     new Player {Id = 3, Forename = "Luis", Surname = "Suarez"}
                                                 }
            };

            var manUtd = new Team
            {
                Name = "Man Utd",
                Manager = new Manager { Id = 4, Forename = "Alex", Surname = "Fergusen" },
                Players = new List<Player>
                                                 {
                                                     new Player {Id = 2, Forename = "Wayne", Surname = "Rooney"},
                                                     new Player {Id = 3, Forename = "Ryan", Surname = "Giggs"}
                                                 }
            };

            teams.Add(liverpool);
            teams.Add(manUtd);

            return teams;
        }        
    }

    public class Manager : Person
    {
    }

    public class Player : Person
    {
        public int Value { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
    }
}