using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_
{
    class Program
    {
        static void Main(string[] args)
        {
            string c = "";
            while (true)
            {
                Console.Write("Gimme a number: ");
                int num = int.Parse(Console.ReadLine());
                for (int i = 0; i < 13; i++)
                    Console.WriteLine(num + " x " + i + " = " + num * i);
                Console.Write("Enter y to restart: ");
                c = Console.ReadLine();
                if (c != "y")
                    break;
            }
        }
    }
}
