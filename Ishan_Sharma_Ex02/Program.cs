using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishan_Sharma_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                List<char> charactersList = new List<char>();
                Random randomGenerator = new Random();

                for (int a = 0; a < 12; a++)
                {
                    charactersList.Add(Convert.ToChar(randomGenerator.Next(97, 122))); //Using Ascii Value from a-z(Small Alphabets)
                }

                Console.WriteLine("Randomly Generated Characters:");
                foreach (var character in charactersList)
                {
                    Console.WriteLine("\t" + character);
                }

                var ascendingList = from character in charactersList
                                    orderby character ascending
                                    select character;
                var descendingList = from character in charactersList
                                     orderby character descending
                                     select character;
                var distinctList = (from character in charactersList
                                    orderby character ascending
                                    select character).Distinct();

                Console.WriteLine("\n\n");
                Console.WriteLine("Characters sorted in ascending order: ");
                foreach (var character in ascendingList)
                {
                    Console.WriteLine("\t" + character);
                }
                Console.WriteLine("\n\n");

                Console.WriteLine("Characters sorted in descending order: ");
                foreach (var character in descendingList)
                {
                    Console.WriteLine("\t" + character);
                }
                Console.WriteLine("\n\n");

                Console.WriteLine("Characters sorted in distinct manner: ");
                foreach (var character in distinctList)
                {
                    Console.WriteLine("\t" + character);
                }
                Console.WriteLine("\n\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }

        }
    }
}
