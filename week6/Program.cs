using System;



namespace week6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a;
            //Console.WriteLine("Enter size of index:");
            //a = int.Parse(Console.ReadLine());
            //int[] index = new int[a];
            //for (int i = 0; i < index.Length; i++)
            //{
            //    Console.WriteLine("Enter number:");
            //    index[i] = int.Parse(Console.ReadLine());

            //}

            //Console.WriteLine("\nThe Elemets of the Array are:-");
            //for (int j = 0; j < index.Length; j++)
            //{
            //    Console.WriteLine(index[j]);
            //    ;

            //}
            //Console.WriteLine("evens are");
            //for (int i = 0; i < index.Length; i++)
            //{
            //    if (index[i] % 2 == 0)
            //    {

            //        Console.WriteLine(index[i]);
            //    }

            //}
            //Console.WriteLine("odds are");
            //for (int j = 0; j < index.Length; j++)
            //{
            //    if (index[j] % 2 != 0)
            //    {
            //        Console.WriteLine(index[j]);
            //    }
            //Console.WriteLine("enter symbols");
            //string a = "@@@@@@";
            //a = Console.ReadLine();
            //string b = "$$$";
            //b = Console.ReadLine();
            //string c = "@a@@@@";
            //c = Console.ReadLine();
            //string[] arr1 = new string[] { a, b, c };
            //foreach (var item in arr1)
            //    {
            //    switch (item)
            //    { 

            //        case "@@@@@@":
            //        Console.WriteLine("yes");
            //        break;
            //        case "$$$":
            //        Console.WriteLine("yes");
            //        break;
            //        case "@a@@@@":
            //        Console.WriteLine("no");
            //        break;



            //   }


            //}     



            Console.Write("wins: ");
            int a;
            a = int.Parse(Console.ReadLine());
            Console.Write("draws: ");
            int b;
            b = int.Parse(Console.ReadLine());
            Console.Write("losses: ");
            int c;
            c = int.Parse(Console.ReadLine());

            int result = a * 3 + b * 1 + c * 0;
            Console.WriteLine($"{"points:"} { result}");
            
            

              
            
               
            
            
            
            

            

            

            
           
            

                

                
        
            






































        }
    }

}
