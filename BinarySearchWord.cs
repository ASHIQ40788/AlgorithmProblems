using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms058
{
    public class BinarySearchWord
    {
        //Method for taking user input as word to find in the list
        public void UserInput()
        {
            string input;
            Console.WriteLine("Enter the colour for searching in the arraylist:");
            input = Console.ReadLine();
            BinarySearch(input);
        }
        public void BinarySearch(string input)
        {
            //colours in the array list.
            string[]  colour_list = { "skyblue", "green", "red", "yellow", "orange", "violet" ,"white","black,","purple","blue"};
            Array.Sort(colour_list);
            bool colour_found = false;
            int start = 0;
            int end = colour_list.Length - 1;
            if (colour_list.Length >= 1)
            {
                int middle = start + end / 2;
                int result = input.ToLower().CompareTo(colour_list[middle]);
                if (result > 0)
                {
                    start = middle + 1;
                }
                else
                {
                    end = middle - 1;
                }
                if (result == 0)
                {
                    
                    colour_found  = true;
                }
            }
            if (colour_found != true)
            {
                Console.WriteLine("{0} colour is not present in colour_list", input);
                
                
            }
            else
            {

                Console.WriteLine("{0} colour is present in the colour_list", input);
            }
           
        }
    }

}
