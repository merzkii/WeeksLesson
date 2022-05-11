using System;

namespace week5
{
    class Program
    {
        static void Main()
        {
            #region
            Console.WriteLine("enter number");
            var number = int.Parse(Console.ReadLine());


            if (number % 5 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            #endregion
            #region

            Console.WriteLine("-------------------------------");
            Console.WriteLine("enter first number");
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            var y = int.Parse(Console.ReadLine());
            var jami = Add(x, y);
            Console.WriteLine($"jami = {jami}");
            var namravli = Multiple(x, y);
            Console.WriteLine($"namravli = {namravli}");
            var ganayofi = Divide(x, y);
            Console.WriteLine($"ganayofi = {ganayofi}");
            var subtraction = Subtraction(x, y);
            Console.WriteLine($"sxvaoba = {subtraction}");

            Swap(x, y);
            PrintScheduleFor(x);
            schedule2for(x);


            #endregion
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Multiple(int x, int y)
        {
            return x * y;
        }
        static double Divide(double x, double y)
        {
            var udidesi = x > y ? x : y;
            var umciresi = x < y ? x : y;
            var shedegi = udidesi / umciresi;
            return shedegi;
            //var zero = x = 0;
            //var message = "cannot be divided";
            //return message;                       დაბლის გამო სტრინგს ვერ ვაბრუნებ


        }
        static int Subtraction(int x, int y)
        {
            var udidesi = x > y ? x : y;
            var umciresi = y > x ? x : y;
            return udidesi - umciresi;
        }



        static void Swap(int x, int y)
        {
            Console.WriteLine($"Input:X-{x}, Y:{y}");
            var axaliCvladi = y;
            y = x;
            x = axaliCvladi;
            Console.WriteLine($"Output:X-{x}, Y:{y}");
        }

        static void PrintScheduleFor(int x)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{x} * {i} = {x * i}");
            }

        }
        
        static void schedule2for(int x)           //ეს შემთხვევით გამივარდა 
        {
            for (int i = 0; i <=x; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i * i);
                }
                
            }
        }
    }
}










        



