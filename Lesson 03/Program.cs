using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iteration");
            int loop = 10;

            //for (int i = 100; i>-10; i-=2)
            {
                //Console.WriteLine(i)
            }

            //do
            {
                //Console.WriteLine(loop);
               // loop--;
            }// while(loop > 0);

            string email = "bob@gmail.com";

            bool foundAt = false;

            for (int i = 0; i < email.Length; i++)
            {
                Console.WriteLine(email[i]);
                if (email[i] == '@')
                {
                    foundAt = true;
                    Console.WriteLine(foundAt);
                }
                else
                {
                    Console.WriteLine("Not valid email");
                }
            }
        }
    }
}
