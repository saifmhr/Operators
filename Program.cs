using System;

namespace Operators
{
  class Program
    {
        static void Main(string[] args)
        {


            
            Console.Write("enter number ");
            int i =Convert.ToInt32(Console.ReadLine());
            //logical operators

            if(i<10 && i>0)
                {
                    Console.WriteLine(" AND operator I is lessthan 10 && I greater than 0 ");
                }
            else
                {
                    Console.WriteLine(" AND operator I is greaterthan 10 && I greater than 0 ");
                }

            //OR OPERATOR
            if (i < 10 || i > 0)
            {
                Console.WriteLine(" AND operator I is lessthan 10 && I greater than 0 ");
            }
            else
            {
                Console.WriteLine(" AND operator I is greaterthan 10 && I greater than 0 ");
            }

            //conparative operators
            if (i != 10)
            {
                Console.WriteLine(" Input is equit 10 ");
            }
            else
            {
                Console.WriteLine(" Input is not equil to 10 ");
            }

            //greater than
            if (i > 10)
            {
                Console.WriteLine(" Input is greaterthan  to 10 ");
            }
            else
            {
                Console.WriteLine(" Input is not greaterthan  to 10 ");
            }

            //lessthan 
            if (i < 10)
            {
                Console.WriteLine(" Input is lessthan  to 10 ");
            }
            else
            {
                Console.WriteLine(" Input is not lessthan  to 10 ");
            }

            //greater than equil
            if (i >= 10)
            {
                Console.WriteLine(" Input is greaterthan equil to 10 ");
            }
            else
            {
                Console.WriteLine(" Input is not greaterthan equil to 10 ");
            }

            //lessthan  equil
            if (i <= 10)
            {
                Console.WriteLine(" Input is lessthan equil to 10 ");
            }
            else
            {
                Console.WriteLine(" Input is not lessthan equil to 10 ");
            }

            //equil to
            if (i == 10)
            {
                Console.WriteLine(" Input is equil to 10 ");
            }
            else
            {
                Console.WriteLine(" Input is not equil to 10 ");
            }



            //ArthMatic operators
            int dominator = 20;
            int numirator = 10;

            int Result = dominator + numirator;
            int substraction= dominator - numirator;
            int perc = dominator / numirator;
            Console.WriteLine(perc);
            Console.WriteLine(substraction);
            Console.WriteLine(Result);

        }
    }
}
