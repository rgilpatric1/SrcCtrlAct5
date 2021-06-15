using System;
using System.Collections;

namespace Activity5
{

    class Program
    {
        public static ArrayList listOfNumbers = new ArrayList();
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number(Enter -999 to quit):");
            int integerInput = Convert.ToInt32(Console.ReadLine());
            while(integerInput != -999)
            {
                listOfNumbers.Add(integerInput);
                Console.WriteLine("Enter number(Enter -999 to quit):");
                integerInput = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
