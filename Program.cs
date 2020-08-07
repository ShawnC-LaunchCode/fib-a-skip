using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace fib_a_skip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //generate a list of fib numbers n long
            //output numbers as described, by only putting out what is wanted
            fib(64);
        }

        public static void fib(int n)
        {
            double n1 = 1;
            double n2 = 1;
            double n3;

            bool evenSkip = true;

            Console.WriteLine(n1);

            if (n >= 2)//meaning n=2+
            {
                Console.WriteLine("Skip");
            }

            if (n >= 3)
            {
                for (int a = 3; a < n+1; a++)
                {
                    n3 = n1 + n2;
                    if (evenSkip)
                    {
                        Console.WriteLine(n3);
                        
                    }
                    else
                    {
                        Console.WriteLine("Skip");
                    }
                    
                    evenSkip = !evenSkip;
                    n1 = n2;
                    n2 = n3;

                }
            }
            
        } 

    }
}
