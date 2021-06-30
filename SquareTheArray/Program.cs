using System;

namespace SquareTheArray
{

  //  Write a function that takes in a non-empty array of integers that are sorted
  //in ascending order and returns a new array of the same length with the squares
  //of the original integers also sorted in ascending order.

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 3, 4, 5 };
            SquareTheArray(array);
        }

        private static int[] SquareTheArray(int[] array)
        {
            int[] squaredArray = new int[array.Length];
            for(int i= 0; i<array.Length; i++)
            {
                squaredArray[i] = array[i] * array[i];
            }
            return squaredArray;
        }
    }
}
