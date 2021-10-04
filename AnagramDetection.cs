using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms058
{
    class AnagramDetection
    {
        //Created a method to check given two strings are Anagram or not
        //Anagram Example: heart --> earth.
        public void AnagramDetect()
        {   //Ask the user to type the first string
            Console.WriteLine("Please Enter the First String");
            string firstString = Console.ReadLine();
            //Ask the user to type the second string
            Console.WriteLine("Please Enter Second String");
            string secondString = Console.ReadLine();


            //comparing the lengths of 2 strings which we given on console window.
            if (firstString.Length == secondString.Length)
            {
                //converting the two strings into character arrays with lowercase
                char[] ch1 = (firstString.ToLower()).ToCharArray();
                char[] ch2 = (secondString.ToLower()).ToCharArray();

                //sort the arrays
                Array.Sort(ch1);
                Array.Sort(ch2);
                // convert the character arrays to strings
                String word1 = new String(ch1);
                string word2 = new String(ch2);
                // if two words are equal then if condition excutes.
                if (word1 == word2)
                {
                    Console.WriteLine("Strings {0}  and {1}  are Anagrams ", firstString, secondString);
                }
                else
                {
                    //if 2 strings length are not equal, else condition eexcutes. 
                    Console.WriteLine("Strings {0}  and {1}  are Not Anagrams ", firstString, secondString);
                }
            }
            
        }
    }
}