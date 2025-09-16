using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World"); //Print Statements

            // Calculate Area Of A Rectangle

            Console.WriteLine("Enter The Width: ");
            int Width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Height");
            int Height = int.Parse(Console.ReadLine());

            int answer = Width * Height;

            Console.WriteLine("The Area Of The Rectangle Is " + answer);

            //Pythagoras Theorem

            Console.WriteLine("Enter the base length: ");
            int Base = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height: ");
            int TriHeight = int.Parse(Console.ReadLine());

            double Hyptnse1 = ((Base * Base) + (TriHeight * TriHeight));
            double Hyptnse2 = Math.Sqrt(Hyptnse1);
            Console.WriteLine("The Hypoteneuse Length Is " + Hyptnse2);

            //Simple Programming Challenges From Mr Parr

            //1a. Temp Converter From Celsius To Fahrenheit
            Console.WriteLine("Convert from celsius to fahrenheit: ");
            int Cel1 = int.Parse(Console.ReadLine());
            int Fah1 = ((Cel1 * (9 / 5)) + 32);
            Console.WriteLine("The temperature in Fahrenheit is: " + Fah1);

            //1b. Temp Converter From Fahrenheit To Celsius
            Console.WriteLine("Convert from fahrenehit to celsius: ");
            int Fah2 = int.Parse(Console.ReadLine());
            double Cel2 = ((Fah2 - 32) * (5.0 / 9.0));
            Console.WriteLine("The temperature in celsius is: " + Cel2);

            //2. Shapes
            //2a. Perimeter Of A Rectangle
            Console.WriteLine("Enter The Width: ");
            int Width2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Height");
            int Height2 = int.Parse(Console.ReadLine());
            int Perimeter = 2 * (Width2 + Height2);
            Console.WriteLine("The Perimeter Of The Rectangle Is " + Perimeter);

            //2b surface area and volume of a cuboid
            Console.WriteLine("Enter The Width: ");
            int Width3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Height");
            int Height3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Depth");
            int Depth = int.Parse(Console.ReadLine());
            int SurfaceArea = 2 * ((Width3 * Height3) + (Height3 * Depth) + (Width3 * Depth));
            int Volume = Width3 * Height3 * Depth;
            Console.WriteLine("The Surface Area Of The Cuboid Is " + SurfaceArea);
            Console.WriteLine("The Volume Of The Cuboid Is " + Volume);

            //2c. Radius of a circle and output the diameter, circumference and volume
            Console.WriteLine("Enter The Radius: ");
            int Radius = int.Parse(Console.ReadLine());
            int Diameter = 2 * Radius;
            double Circumference = 2 * Math.PI * Radius;
            double CircleVolume = (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
            Console.WriteLine("The Diameter Of The Circle Is " + Diameter);
            Console.WriteLine("The Circumference Of The Circle Is " + Circumference);
            Console.WriteLine("The Volume Of The Circle Is " + CircleVolume);

        }
    }
}
