using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifStatementsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 18;

            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to elementry school");
            }
            else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to elementry school");
            }
            else if ((age > 13) && (age <= 18))
            {
                Console.WriteLine("Go to highschool!");
            }

            if ((age < 16) || (age > 67))
            {
                Console.WriteLine("You should not work!");
            }
            else Console.WriteLine("Get a job!");
        }
    }
}
