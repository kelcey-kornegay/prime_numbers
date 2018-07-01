using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*A prime number is any integer, or whole number, 
greater than 1 that is only divisible by 1 and itself. 
In other words, a prime number only has two factors, 1 and itself.*/

namespace prime_numbers
{
    class Program
    {
        static void Main(string[] args)

        {
             bool isPrime = true;
            int number = int.Parse(Console.ReadLine());
            
             Console.WriteLine("Prime Numbers : ");
             for (int i = 2; i <= number; i++)
             {
                    for (int j = 2; j <= number; j++)
                    {

                        if (i != j && i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    
                    }
                    if (isPrime)
                    {
                        Console.Write("\t{0}..\n", i);
                    }
                    isPrime = true;
              }
             Console.ReadKey();
       
         }
    }
}