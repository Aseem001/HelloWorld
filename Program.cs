using System;
using System.Dynamic;
using System.Runtime.Serialization;

namespace HelloWorld
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number whose factorial is to be calculated");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entered number is "+num);
            int factResult = Program.Factorial(num);
            Console.WriteLine("Factorial of "+num+ " is "+factResult);
        }

        public static int Factorial(int num)
        {
            int fac = 1;
            for (int i = 1; i <= num; i++)
            {
                fac = fac * i;
            }
            return fac;
        }
    }
}
