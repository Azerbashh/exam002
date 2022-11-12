using System;

namespace exam002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 80;
            Console.BufferWidth = 80;
            while (true)
            {
                
                int n = int.Parse(Console.ReadLine());
                if (n == 13)
                {
                    break;
                }
                Console.Clear();
                for (int i = 0; i < (2 * n - 1); i++)
                {
                    if (i < n)
                    {
                        for (int j = 0; j <= i; j++)
                        {

                            Console.Write("*");

                        }
                    }
                    else
                    {
                        for (int j = (2 * n - 1); j > i; j--)
                        {

                            Console.Write("*");

                        }
                    }

                    Console.WriteLine();
                }
            }

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < j; j++)
            //    {

            //    }
            //}

        }
    }
}
