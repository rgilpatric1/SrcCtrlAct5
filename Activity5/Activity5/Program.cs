using System;
using System.Collections;
namespace Activity5
{
    class Program
    {
      
   static ArrayList listOfNumbers = new ArrayList();

        public static String everyFifth()
        {
            String everyFifthNum = "";
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if (i % 5 == 0)
                {
                    everyFifthNum = everyFifthNum + " " + listOfNumbers[i];
                }
            }
            return everyFifthNum;
        }
        public static int sumNum()
        {
            int sum = 0;
            foreach (var item in listOfNumbers)
            {
                sum += item;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number(Enter -999 to quit):");
            int integerInput = Convert.ToInt32(Console.ReadLine());
            while (integerInput != -999)
            {
                listOfNumbers.Add(integerInput);
                Console.WriteLine("Enter number(Enter -999 to quit):");
                integerInput = Convert.ToInt32(Console.ReadLine());
            }
        }//end of main
        static void displayEvenIntegers()
        {
            foreach (int element in listOfNumbers)
            {
                if (element % 2 == 0)
                {
                    Console.WriteLine(element);
                }
            }
        }
        static void displayNumbersDivisibleByThree()
        {
            foreach (int element in listOfNumbers)
            {
                if (element % 3 == 0)
                {
                    Console.WriteLine(element);
                }

            }

        }
    }
    }
}
