using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] numbers = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(numbers);
            //TODO: Print the first number of the array
            Console.WriteLine("first number of the array");
            Console.WriteLine(numbers[0]);
            //TODO: Print the last number of the array
            Console.WriteLine("Last number of the array");
            Console.WriteLine(numbers[numbers.Length-1]);
            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            
            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(numbers);
            NumberPrinter(numbers);
            Console.WriteLine("---------REVERSE CUSTOM------------");
            var newArray = ReverseArray(numbers);
            NumberPrinter(newArray);
            Console.WriteLine();

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbers);
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbers);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }            
            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> numberList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine("This is my list capacity");
            int capacity = numberList.Capacity;
            Console.WriteLine(capacity);
            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Console.WriteLine("here are the random numbers in my new list");
            Populater(numberList);
            NumberPrinter(numberList);
            //TODO: Print the new capacity
            Console.WriteLine("This is the new capacity");
            capacity = numberList.Capacity;
            Console.WriteLine(capacity);
            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            NumberChecker(numberList);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numberList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numberList);
            NumberPrinter(numberList);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numberList.Sort();
            foreach (int i in numberList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            Console.WriteLine(" My list has been converted to an array checking array length");
            int[] array = numberList.ToArray();
            Console.WriteLine(array.Length);
            //TODO: Clear the list
            Console.WriteLine("Lets clear the list");
            Console.WriteLine("Number of elements before the clear");
            Console.WriteLine(numberList.Count());
            Console.WriteLine("Number of elements after the clear");
            numberList.Clear();
            Console.WriteLine(numberList.Count());
            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i=0; i <= numbers.Length-1; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }

            }

        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count-1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }

            }
        }

        private static void NumberChecker(List<int> numberList)
        {
            var searchNumber = int.TryParse(Console.ReadLine(), out int userNum);

            if (searchNumber)
            {
                if (numberList.Contains(userNum))
                {
                    Console.WriteLine("We found your number");
                }
                else
                {
                    Console.WriteLine("Number not found");               
                }
            }
            else
            {
                Console.WriteLine("Thats not a number");               
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random random = new Random();

            for (int i = 0; i < 50; i++)
            {
                numberList.Add(random.Next(1, 51)); 

            }

        }

        private static void Populater(int[] numbers)
        {
            Random randomNum = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = randomNum.Next(1, 51);
            }


        }        

        private static int[] ReverseArray(int[] numbers)
        {
            var list = new List<int>();
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                list.Add(numbers[i]);
            }
             return list.ToArray();
        }
           
    /// <summary>
    /// Generic print method will iterate over any collection that implements IEnumerable<T>
    /// </summary>
    /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
    /// <param name="collection"></param>
    private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
