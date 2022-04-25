using System;

namespace Operators2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("what is the radius of the circle");
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);



            Console.WriteLine("the area of a circle with a radius of " + radius + " is " + area);


        }
    }
}

