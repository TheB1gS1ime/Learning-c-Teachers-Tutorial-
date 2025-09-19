using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            Console.WriteLine(a);
            Console.WriteLine(b);
            swapit(a,b);
        }

        static void swapit(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
