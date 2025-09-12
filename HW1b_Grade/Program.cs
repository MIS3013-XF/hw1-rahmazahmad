// HW1b Grade

// Your Name: Rahma Ahmad
// Did you seek help ? If yes, specify the helper or web link here: Slides, notes, ChatGPT

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //set constants
            const double hw_weight = .20;
            const double partic_weight = .15;
            const double e1_weight = .15;
            const double e2_weight = .25;
            const double final_weight = .25;

            //user string inputs
            Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastname = Console.ReadLine();
            Console.WriteLine("What is your student ID?");
            string id = Console.ReadLine();

            //user double inputs
            Console.WriteLine("What is your overall percentage grade for homeworks?");
            double hw = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for participations?");
            double partic = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("What is your overall percentage grade for Exam 1?");
            double exam1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for Exam 2?");
            double exam2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for final?");
            double final = Convert.ToDouble(Console.ReadLine());

            //calculate final grade
            double finalgrade = (hw * hw_weight) + (partic * partic_weight) + (exam1 * e1_weight) + (exam2 * e2_weight) + (final * final_weight);

            //format final grade
            string finalgradeAsString = finalgrade.ToString("F2"); 

            //output to user
            Console.WriteLine($"{firstname} {lastname} ({id}), your final grade is {finalgradeAsString}%.");

            Console.ReadKey();
        }
    }
}
