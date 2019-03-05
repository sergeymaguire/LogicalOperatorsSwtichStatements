using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperatorsSwtichStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string ageNumber;
            Console.Write("Please enter your age: ");
            ageNumber = Console.ReadLine();
            age = Convert.ToInt32(ageNumber);
           if(age >= 65 || age <= 17)
            {
                Console.WriteLine("Congrats you get a discount!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You get no discount sorry");
                Console.ReadLine();
            }

            int salesAmount;
            int yearsOfService;
            int bonus = 500;
            string salesString;
            string yearsString;
            Console.Write("Enter sales amount: ");
            salesString = Console.ReadLine();
            salesAmount = Convert.ToInt32(salesString);
            Console.Write("Enter years of service: ");
            yearsString = Console.ReadLine();
            yearsOfService = Convert.ToInt32(yearsString);
            if(salesAmount >= 2000 && yearsOfService >= 10)
            {
                bonus += 200;
                Console.WriteLine("Congrats your new bonus is {0} ", bonus);
                Console.ReadLine();
            }
            else
            {
                bonus -= 100;
                Console.WriteLine("Here is your bonus {0}", bonus);
                Console.ReadLine();
            }
        }
    }
}
