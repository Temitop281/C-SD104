using System;

namespace ConsoleAppLesson4_6Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[] tasks = new string[7];

            for (int i = 0; i < days.Length; i++)
            {

                Console.WriteLine("Go to work " + days[i]);
                Console.WriteLine("Go to school" + days);
                Console.WriteLine("Watch TV" + days);
                Console.WriteLine("read a book" + days);
                Console.WriteLine("go out to eat" + days);
                Console.WriteLine("sleep in" + days);
                Console.WriteLine("go to church" + days);

                tasks[i] = days[i] + " : " + Console.ReadLine();

            }

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(tasks[i]);
            }
        }
    }
}
