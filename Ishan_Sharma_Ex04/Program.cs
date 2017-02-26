using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ishan_Sharma_Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int lowIndex;
            int highIndex;

            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9,12.5};
            int[] intArray = { 1, 2, 3, 4, 5, 10,12,14,12,90 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O', 'I', 'S', 'H','A', 'N'};

            Console.WriteLine("\nLength of double Array is = " + doubleArray.Length + "\n");
            Console.WriteLine("\nLength of char Array is =" + charArray.Length + "\n");
            Console.WriteLine("\nLength of integer Array is =" + intArray.Length);

            Console.WriteLine("\nEnter the low index");

            string input1 = Console.ReadLine();
            Console.WriteLine("\nLow index entered =" + input1);
            lowIndex = Int32.Parse(input1);

            Console.WriteLine("\nEnter the high index");
            string input2 = Console.ReadLine();
            Console.WriteLine("\nHigh index entered =" + input2);
            highIndex = Int32.Parse(input2);

            
            var intArr = DisplayArray(intArray, lowIndex, highIndex); // pass an int array argument

            Console.WriteLine("\nDisplaying int array");
            foreach (var item in intArr)
            {
                Console.Write( item + ",");
            }


            Console.WriteLine("\nDisplaying double array");


            var doubleArr = DisplayArray(doubleArray, lowIndex, highIndex); // pass an int doubleArray argument
            foreach (var item in doubleArr)
            {
                Console.Write(item + ",");
            }

            Console.WriteLine("\nDisplaying char array");


            var charArr = DisplayArray(charArray, lowIndex, highIndex); // pass an int doubleArray argument

            foreach (var item in charArr)
            {
                Console.Write(item + ",");
            } 

        }
        //y = lowindex
        //z = highindex
        private static T[] DisplayArray<T>(T[] inputArray, int y, int z) where T : IComparable<T>
        {

            var length = (z - y);
            T[] tmp = new T[length];

            try
            {
                for (var i = 0; i < length; i++)
                {
                    tmp[i] = inputArray[y];
                    y++;
                }
            }
            catch(SystemException)
            {
                MessageBox.Show("\nLow and High index Must be Within Array's size");
            }

            return (tmp);
            //Done

        }


        }

    }


