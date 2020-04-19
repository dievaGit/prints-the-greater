using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            int a = 0, b = 0;

            //Requesting data from the user
            Console.Write(" Enter the first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter the second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                //Showing result
                Console.WriteLine(" The greatest number is: {0}", a);

            }
            else
            {
                if (a < b)
                {
                    //Showing result
                    Console.WriteLine(" The greatest number is: {0}", b);

                }
                else
                {
                    if (a == b)
                    {
                        //Showing result
                        Console.WriteLine(" The numbers are equals.");

                    }
                }
            }

        }
    }
}
