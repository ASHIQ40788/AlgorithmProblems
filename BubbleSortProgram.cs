using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms058 
{
    class BubbleSortProgram
    {
        /// <summary>
        /// Created a method BubbleSort to sort in Ascending order.
        /// </summary>
        public void BubbleSort()
        {
            Console.WriteLine("enter size of array:");
            //converting string to interger and reading the size value and store in size.
            int size = Convert.ToInt32(Console.ReadLine());

            //created an array to insert values/elements
            int[] array = new int[size]; //size=3
            Console.WriteLine("enter string elements of array:");
            for (int i = 0; i < size; i++)
            {
                //converting string to interger and store it in array[i].
                array[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        //swap temp and arr[i]
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            //calling PrintArray Method.
            BubbleSortProgram.PrintArray(array);
        }

        //created PrintArray method for print the elements.
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                //prints the sorted elements.
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
