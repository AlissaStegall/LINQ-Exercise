using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a list of video game names... DONE
            // Order the list of games by length of the game name.
            //Use the lambda expression in this exercise as well.
            //Use Method Syntax for this exercise

            var games = new List<string>() { "Super Mario", "Zelda", "Donkey Kong", "Mortal Kombat" };

            var nameOfGames = games.OrderBy(game => game.Length);

            foreach(var videoGame in nameOfGames)
            {
                Console.WriteLine(videoGame);
            }
        }
    }
}
