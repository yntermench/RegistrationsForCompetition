using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationsForCompetition.Models
{
    public class Repositories
    {
        public static List<Player> players = new List<Player>();
        public static IEnumerable<Player> Players { get { return players; } }

        public static void AddResponses(Player player)
        {
            players.Add(player);
        }
    }
}
