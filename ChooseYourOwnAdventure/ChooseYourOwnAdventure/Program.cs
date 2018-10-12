using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static string Escape(int x, Random r, string[] paths,ref int count)
        {
            if (x >= 10)                                        //recursion enders
                return "You escaped the zombie!";
            else if (x <= -10)
                return "You were killed by the zomebie...";


            int num = 0;
            int[] index = { 0, 0 };
            index[0] = r.Next(0, 6);
            index[1] = r.Next(0, 6);                            //index randomly selects one of the 6 paths
            Console.WriteLine("Score: " + x);                   //how close you are to winning or loosing -10/10 breaks it
            Console.WriteLine("##########################");
            Console.WriteLine("1) " + paths[index[0]]);
            if (index[0] == index[1])                           //try not to get same path twice
                index[1] = r.Next(0, 6);
            Console.WriteLine("2) " + paths[index[1]]);
            Console.Write("Choose a path: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            count++;                        //increment step counter
            index[0]++;                     //avoid "take ladder" = 0
            index[1]++;                     //avoid "take ladder" = 0
            return Escape (x +(index[num-1]*r.Next(-2,3)), r, paths, ref count);//x parameter = x + (0-6)*(-3-3)
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            int x = 0;
            Console.WriteLine("ESCAPE THE ZOMBIE\n");
            Console.WriteLine("Press Any Key to begin . . .");
            Console.ReadLine();
            string[] paths = { "Take ladder", "Walk straight", "turn left", "turn right", "Dark hole on floor...", "Crawl through hole in wall" };
            int count = 0;
            Console.WriteLine(Escape(x, r, paths,ref count) + "you made " + count + " moves.");
        }
    }
}
