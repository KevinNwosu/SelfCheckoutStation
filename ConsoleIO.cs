using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCheckoutStation
{
    public class ConsoleIO
    {
        public static decimal GetSalesTax()
        {
            string message = "Enter the sales tax as a percent please";

            decimal value = PromptForPositivePercent(message);
 
            decimal salesTax = value / 100;

            return salesTax; 
        }
        public static decimal PromptForPositivePercent(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                if (decimal.TryParse(Console.ReadLine(), out decimal input))
                {
                    if (input < 0)
                    {
                        Console.WriteLine("No negative values please.");
                    }
                    else if (input > 100)
                    {
                        Console.WriteLine("Sales Tax shouldn't be more than 100. It's a scam, shop elsewhere!!");
                    }
                    else
                    {
                        return input;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, enter a number please.");
                }
            }
        }
        public static decimal GetPrice()
        {
            string message = "Please enter the item price";

            decimal price = PromptForPositiveDecimal(message);

            return price;
        }
        public static decimal PromptForPositiveDecimal(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                if (decimal.TryParse(input, out decimal output))
                {
                    if (output < 0)
                    {
                        Console.WriteLine("No negative values please.");
                    }
                    else
                    {
                        return output;
                    }
                }
                else if (input.Trim().ToLower() == "q")
                {
                    return -1;
                }
                else
                {
                    Console.WriteLine("Invalid input, enter a number please.");
                }
            }
        }
        public static int GetQuantity()
        {
            string message = "Enter the quantity of your item.";

            int quantity = PromptForPositiveInt(message);

            return quantity;
        }
        public static int PromptForPositiveInt(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    if (input < 0)
                    {
                        Console.WriteLine("No negative values please.");
                    }
                    else
                    {
                        return input;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, enter a number please.");
                }
            }
        }
        public static void PromptToContinue()
        {
            Console.WriteLine("Press any key to Continue ");
            Console.ReadKey();
        }
        
    }
}
