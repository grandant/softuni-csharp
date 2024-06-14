﻿namespace NumberPyramid
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine()!);
            int current = 1;
            bool isBigger = false;

            for (int rows = 0; rows <= n; rows++)
            {
                for (int cols = 0; cols <= rows; cols++)
                {
                    if (current > n)
                    {
                        isBigger = true;
                        break;
                    }

                    Console.Write(current + " ");
                    current++;
                }
                if (isBigger)
                {
                    break;
                }

                Console.WriteLine();
            }
        }
    }
}