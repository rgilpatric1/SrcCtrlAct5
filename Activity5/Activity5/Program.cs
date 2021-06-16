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

        public void RealDisplayMethod()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Display the whole list of input");
            Console.WriteLine("2. Display every even number");
            Console.WriteLine("3. Display every odd number");
            Console.WriteLine("4. Display every 5th number");
            Console.WriteLine("5. Display the sum of the integers");
            Console.WriteLine("6. Display every number divisibly by 3");
            Console.WriteLine("7. Quit");

        }
    }

}
