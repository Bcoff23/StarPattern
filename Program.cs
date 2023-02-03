using System;
namespace StarPattern
{
   class Program
    {
        static void Main(string[] args)
        {
            for (int row = 1; row <= 6; row++)
            {
                for (int col =1;col <= row; ++col)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }

            Console.WriteLine("Break");
            for (int row = 6; row >= 1; -- row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }

            Console.WriteLine("Break");

            for (int row = 1; row <= 6; ++row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }

    }
}