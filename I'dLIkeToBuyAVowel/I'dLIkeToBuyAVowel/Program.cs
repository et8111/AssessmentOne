using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace I_dLIkeToBuyAVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gimme a string: ");
            string word = Console.ReadLine();
            int vowels = Regex.Matches(word, "[aeiouAEIOUYy]").Count;
            Console.WriteLine(vowels);
        }
    }
}
