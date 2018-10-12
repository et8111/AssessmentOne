using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BondJames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string first, last,name = Console.ReadLine();
            first = name.Substring(0,name.IndexOf(' '));
            last = name.Substring(name.IndexOf(' ')+1);
            Console.WriteLine(last + " " + first);
        }
    }
}
