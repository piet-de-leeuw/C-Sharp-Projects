using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK_application
{
    public abstract class Game
    {
        public Game()
        {
            Players = new List<Player>();
            Bets = new Dictionary<Player, int>();
        }

        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get; set; }


        public abstract void Play();
        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }   
        }
    }
}
