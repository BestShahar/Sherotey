using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HighScoresContext context = new HighScoresContext();
\|
            Player p = new Player() { Name = "Shahar", BirthYear=2007 };
            p.PlayerHighScores.Add( new PlayerHighScore(){GameId=1, HighScore=1000});
            try
            {
                context.AddPlayer(p);

                List<PlayerHighScore> highScores = context.PlayerHighScores.OrderBy(x => x.HighScore).ToList();
                foreach(var g in highScores)
                {
                    Console.WriteLine($"{g.HighScore} {g.Game}");
                }
            }
           catch(Exception ex) { Console.WriteLine((ex.Message)); }
        }
    }
}