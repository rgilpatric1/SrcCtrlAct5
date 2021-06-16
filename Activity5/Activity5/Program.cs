using System;
using System.Collections;

namespace Activity5
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static void quit()
        {
            System.Environment.Exit(0);
        }

        public static void oddNumbers(ArrayList list)
        {
            foreach (int i in list)
            {
                if (i % 2 == 1)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
