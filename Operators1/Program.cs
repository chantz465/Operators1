using System;

namespace Operators1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int numA = ;
            //int numB = ;

           

            Console.WriteLine("Enter a number");
            int numA = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered {0}", numA);


            Console.WriteLine("Enter a number");
            int numB = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered {0}", numB);


            int add =  numA + numB;

            Console.WriteLine("Add ", add);

            int subtract = numA - numB;

            Console.WriteLine("subtract ", subtract );

            int divide = numA / numB;
            int remainder = numA % numB;

            Console.WriteLine("divide " + divide + " " + remainder);




           


        }
    }
}
