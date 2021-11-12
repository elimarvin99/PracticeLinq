using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>() { "Fortnite", "Call of Duty", "Far Cry", "Battlefield", "Madden", "Assasins Creed" };
            var orderdVideoGames = videoGames.OrderBy(x => x.Length).ToList();       //need to add to list because otherwise the variable is returned as a IEnumerable type
            orderdVideoGames.ForEach(x => Console.WriteLine(x));

            //foreach (var item in orderdVideoGames)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
