using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Take a radius length for calculations
            Console.WriteLine("Enter a radius between 1 and 10");
            double radius = float.Parse(Console.ReadLine());

            if (radius >= 1 && radius <= 10)
            {
                // Calculate Diameter, Circumference and volume:
                double Diameter = radius * 2;
                double Circumference = (double)radius * 2 * Math.PI;
                double Volume = (4 / 3) * Math.PI * (radius * radius * radius);
                Console.WriteLine("The diameter is " + Diameter + ", the circumference is " + Circumference + ", and the volume is " + Volume);
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 and 10 next time");
            }

            //Chatterbot task
            Console.WriteLine("Whats your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine("Whats your favourite colour?: ");
            string FavColour = Console.ReadLine();
            Console.WriteLine("Whats your age?: ");
            int age = int.Parse(Console.ReadLine());
            if (age > 18)
            {
                Console.WriteLine("Wow you're old");
            }
            else
            {
                Console.WriteLine("Wow you're young");
            }
        }
    }
}
