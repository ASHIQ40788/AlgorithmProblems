using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms058 
{
    public class PrimePalindrome
    {
        public void DisplayPrimePalindrome()
        {

            int count = 0;

            //iteration starts from 0 to 1000
            for (int i = 10; i <= 1000; i++)
            {

                int num = i, revNum = 0;
                while (num != 0)
                {
                    int digit;
                    //modulus gives you remainder.
                    digit = num % 10;

                    //division gives a quotient.
                    num = num / 10;
                    revNum = revNum * 10 + digit;
                }

                //check whether the reverse number and i value same or not.
                if (revNum == i)
                {
                    //Boolean variables can be only two values --> true or false
                    bool isPrime = true;
                    for (int j = 2; j <= i / 2; j++)
                    {

                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }

                    }
                    if (isPrime)
                    {
                        Console.WriteLine(i + " is prime number and palindrome as well");
                        count++;

                        //If count is not equal to 10 ,then if condition fails and control come out of the loop, then control moves to forloop.
                        if (count == 10)
                        {
                           Console.WriteLine();
                            count = 0;
                        }
                    }
                }
            }
        }
    }
}
