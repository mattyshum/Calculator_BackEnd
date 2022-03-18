using System;
using System.Data;
using System.Text;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string itemEntered = null;
            StringBuilder calculation = new StringBuilder();
            string calc = null;
            

            while(itemEntered != "q")
            {
                Console.WriteLine("Enter item:");

                itemEntered = Console.ReadLine();

                if (itemEntered != "q")
                {
                    calculation.Append(itemEntered + " ");
                }
            }

            calc = calculation.ToString();
            calc.Trim();
            Console.WriteLine($"Here is your expression: {calc}");


            double result = Convert.ToDouble(new DataTable().Compute(calc, null));
            Console.WriteLine($"And here is your result: {result}");
        }
    }
}
