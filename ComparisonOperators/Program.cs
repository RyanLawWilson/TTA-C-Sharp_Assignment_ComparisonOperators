using System;

namespace ComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            System.Threading.Thread.Sleep(500);
            Console.Write("Person 1");
            displayDotDotDot();
            Console.Write("What is your hourly rate: ");
            double p1_rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hours worked this week: ");
            double p1_hours = Convert.ToDouble(Console.ReadLine());

            System.Threading.Thread.Sleep(250);
            Console.Write("\nPerson 2");
            displayDotDotDot();
            Console.Write("What is your hourly rate: ");
            double p2_rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hours worked this week: ");
            double p2_hours = Convert.ToDouble(Console.ReadLine());

            double p1_salary = p1_rate * p1_hours * 52;     // (about) 52 weeks in a year
            double p2_salary = p2_rate * p2_hours * 52;     // (about) 52 weeks in a year

            Console.WriteLine("\nAnnual Salary 1: " + p1_salary.ToString());
            Console.WriteLine("Annual Salary 2: " + p2_salary.ToString());

            if (p1_salary > p2_salary)
            {
                Console.Write("Does Person 1 make more money than Person 2?");
                displayDotDotDot();
                Console.WriteLine(p1_salary > p2_salary);
            } else
            {
                Console.Write("Does Person 1 make more money than Person 2?");
                displayDotDotDot();
                Console.WriteLine(p1_salary < p2_salary);
            }

            Console.WriteLine("\nThis is the end of the program.  Press ENTER.");
            Console.Read();
        }


        static void displayDotDotDot()
        {
            Random rand = new Random();

            short baseDelay = 100;
            short maxDelay = 300;

            System.Threading.Thread.Sleep(baseDelay + rand.Next(0, maxDelay + 1));
            Console.Write(".");
            System.Threading.Thread.Sleep(baseDelay + rand.Next(0, maxDelay + 1));
            Console.Write(".");
            System.Threading.Thread.Sleep(baseDelay + rand.Next(0, maxDelay + 1));
            Console.WriteLine(".");
            System.Threading.Thread.Sleep(baseDelay + rand.Next(0, maxDelay + 1));
        }
    }
}
