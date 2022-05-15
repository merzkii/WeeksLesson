using System;
using System.Collections.Generic;
using System.Linq;

namespace weeek8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var count = CountFromArray(new[] { 'B', 'B', 'A', 'A', 'C' }, 'A');
            IdentifyPairs();
            //PowForN(49, 71, 2);
            //var letters = lastletters("motivation", "demotivation");
        }

        static int CountFromArray(char[] array, char value)
        {
            int counter = 0;
            foreach (var item in array)
            {
                if (item == value)
                    counter = counter + 1;  
            }
            return counter;
        }


        static void IdentifyPairs()
        {
            char[] input = Console.ReadLine().ToCharArray();

            int totalCount = 0;
            var distinctInputs = input.Distinct();

            foreach (var item in distinctInputs)
            {
                int count = CountFromArray(input, item);
                if (count > 1)
                {
                    totalCount = totalCount + 1;
                }


            }
            Console.WriteLine(totalCount);
        }
        static void PowForN(int a, int b, int n)
        {
            var rootFromA = (int)Math.Ceiling(Math.Pow(a, (double)1 / n));
            var rootFromb = (int)Math.Ceiling(Math.Pow(b, (double)1 / n));
            for (int i = rootFromA; i < rootFromb; i++)
            {
                Console.WriteLine(i);
            }
        }
        static string lastletters(string first, string second)
        {
            if (first.Last() != second.Last())
                return "Not eqaul";

            var firstReverse = first.Reverse().ToArray();
            var secondReverse = second.Reverse().ToArray();
            var lastLetters = new List<char>();
            for (int i = 0; i < firstReverse.Count(); i++)
            {
                if (firstReverse[i] == secondReverse[i])
                {
                    lastLetters.Add(firstReverse[i]);
                }
                else
                {
                    break;
                }
            }

            var arrayInRightWay = lastLetters.ToArray().Reverse().ToArray();

            return new string(arrayInRightWay);

            
        }
    }
}
