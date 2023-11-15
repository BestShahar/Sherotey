using Castle.Components.DictionaryAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public partial class HighScoresContext
    {
        public List<Game> AllGams()
        {
            return this.Games.ToList();

        }

        public void AddPlayer(Player p)
        { 
            this.Players.Add(p);
            this.SaveChanges();
        }
    }
}
