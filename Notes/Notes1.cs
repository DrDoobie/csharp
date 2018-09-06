using System;

namespace New_folder
{
    class Program
    {
        static int x = 0, y = 5;

        static void Main(string[] args)
        {
            //These two functions do the same thing
            WhileTest();
            ForTest();
        }

        static void WhileTest () {
            //Simple while example
            while(x < y)
            {
                Console.WriteLine(x);
                x++;
            }
        }

        static void ForTest () {
            /*Initializaiton; Condition; Steps
            Declare and initialize var; Execute code til condition is true/false; Increment to keep progressing code*/
            for (int i = 0; i < y; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
