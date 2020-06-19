using System;

namespace ConsoleApp2Solution2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int number1; //input one
            int number2; //input two
            Console.WriteLine("The answer when multiplying is:");
            Console.WriteLine(result);

            double result2 = (double) number1 / (double) number2;
            Console.WriteLine("The answer when dividing is:");
            Console.WriteLine(result2);

            Console.WriteLine("please enter your name.");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello" + userName);


            Console.WriteLine("Lets multiply! please enter a number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter a second number.");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter a third number.");
            int number3 = Convert.ToInt32(Console.ReadLine());
            result = number1 * number2 * number3;
            Console.WriteLine()



     

        }
    }
}
C