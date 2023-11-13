using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HighScoresContext context = new HighScoresContext();
            foreach(Game g in context.AllGams())
            {
                Console.WriteLine( $"{g.Name} {g.MinimumAge}");
            }
        }
    }
}