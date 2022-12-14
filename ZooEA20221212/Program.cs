using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooEA20221212
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "giraffe", "lion", "octopus", "iguana", "monkey", "toucan", "bear", "elephant" };
            string vowels = "aeiou";
            foreach (string animal in animals)
            {
                //if the first letter of the animal name isn't a vowel, set the article to "a";
                //otherwise, the article should be "an"
                string article = "an ";
                if (vowels.IndexOf(animal[0]) == -1)
                    article = "a ";

                Console.WriteLine("Oooh, I see " + article + animal + "!");
            }
        }
    }
}
