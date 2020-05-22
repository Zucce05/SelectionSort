using System;
using System.Threading;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Line comment of what the application is
            Console.WriteLine("Selection Sort");

            // Set variables (arraySize can be modified to be an input parameter)
            uint arraySize = 100;
            int[] myArray = new int[arraySize];
            Random rand = new Random();

            // Populate the array with random values. Allow positive and negative values, use size of array as min and max.
            // Print out array to see 'start' values.
            Console.WriteLine("Start Values");
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rand.Next(0 - myArray.Length, myArray.Length);
                Console.WriteLine($"Index {i} : {myArray[i]}");
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                // Set up position tracking and values
                int currentIndexPosition = i;
                int currentIndexValue = myArray[i];
                int newIndexPosition = -1;
                int newIndexValue = myArray[i];

                // Iterate from current location comparing values
                for (int j = (int)currentIndexPosition; j < myArray.Length; j++)
                {
                    // If a value is less than the current position, set the newIndexPosition and newIndexValue
                    if (myArray[j] < newIndexValue)
                    {
                        newIndexPosition = j;
                        newIndexValue = myArray[j];
                    }
                }

                // Check if newIndexPosition is still -1
                // This can be done in the if block without the else by using (!(newIndexPosition < 0))
                // I've left it this way for reading clarity
                if (newIndexPosition < 0)
                {/* Do nothing, value is lowest already */}
                else
                {
                    myArray[currentIndexPosition] = newIndexValue;
                    myArray[newIndexPosition] = currentIndexValue;
                }
            }

            // Print out array to see 'end' values.
            Console.WriteLine("\nEnd Values");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Index {i} : {myArray[i]}");
            }


        }
    }
}
