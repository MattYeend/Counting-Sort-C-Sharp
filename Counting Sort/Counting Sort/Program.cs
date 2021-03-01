using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10]
            {
                2, 5, -4, 11, 0, 8, 22, 67, 51, 6
            };

            Console.WriteLine("\n" + "Original array: ");
            foreach (int aa in array)
                Console.Write(aa + " ");

            int[] sortedArray = new int[array.Length];

            //Find smallest and largest value
            int minVal = array[0];
            int maxVal = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                if (array[i] < minVal) minVal = array[i];
                else if (array[i] > maxVal) maxVal = array[i];
            }

            //init array of frequencies
            int[] counts = new int[maxVal - minVal + 1];

            //init the frequencies
            for(int i = 0; i < array.Length; i++)
            {
                counts[array[i] - minVal]++;
            }

            //recalculate
            counts[0]--;
            for(int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            //sort the array
            for(int i = array.Length - 1; i >= 0; i--)
            {
                sortedArray[counts[array[i] - minVal]--] = array[i];
            }

            Console.WriteLine("\n" + "Sorted Array: ");
            foreach (int aa in sortedArray)
                Console.Write(aa + " ");
            Console.Write("\n");
            Console.ReadKey();
        }
    }
}
