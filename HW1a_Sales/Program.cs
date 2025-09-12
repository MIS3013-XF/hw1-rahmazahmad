// HW1a Sales Total

// Your Name: Rahma Ahmad
// Did you seek help ? If yes, specify the helper or web link here: Classroom notes, slides, and ChatGPT

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)

         
        {
            //define tax rate constant
            const double tax_rate = .085; 

            //user input
            Console.WriteLine("What is the product name of the item you are purchasing?");
            string itemName = Console.ReadLine();
            Console.WriteLine("How many " + itemName + "s would you like to buy?");
            double quant = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the price for each " + itemName + "?");
            double price = Convert.ToDouble(Console.ReadLine());
           
            //calculate and format subtotal
            double subtotal = price * quant;
            string subtotalAsString = subtotal.ToString("C2");

            //calculate and format sales tax
            double sales_tax = tax_rate * subtotal;
            string sales_taxAsString = sales_tax.ToString("C2");

            //calculate and format sales total
            double sales_total = subtotal + sales_tax;
            string sales_totalAsString = sales_total.ToString("C2");

            //output to user 
            Console.WriteLine($"\tYour subtotal for your bill is {subtotalAsString}.");
            Console.WriteLine($"\tYour sales tax for your bill is {sales_taxAsString}.");
            Console.WriteLine($"\tYour total for your bill is {sales_totalAsString}.");

            Console.ReadKey();



        }
    }
}
