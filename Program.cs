using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms058
{
    public class Program
    {
        static void Main(string[] args)
        {
            //created an object with class name InsertionSort.
            //InsertionSort insertion = new InsertionSort();
            //insertion.InsertionSortOrder();
            //Console.ReadLine();

            //Created an object with class name BubbleSortProgram.
            //BubbleSortProgram Bubble = new BubbleSortProgram();
            //Bubble.BubbleSort();

            //BinarySearchWord BinaryWord = new BinarySearchWord();
            //BinaryWord.UserInput();
            //Console.ReadLine();

            AnagramDetection anagram = new AnagramDetection();
            anagram.AnagramDetect();
            Console.ReadLine();
        }
    }
}

