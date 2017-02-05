// TotalSales
// Daniel Singletary
// Asks user for a salesperson's name and allows item sales to be added resulting in app calculating total sales

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalSales
{
    class TotalSales
    {
        static void Main(string[] args)
        {
            int intItem = 0;            // declare intItem
            int intQuantity;        // declare intQuantity
            double dblItemSales = 0.00;    // declare dblItemSales
            double dblTotalSales = 0.00;   // declare dblTotalSales
            double item1 = 239.99;           // placeholder for item 1
            double item2 = 129.75;           // placeholder for item 2
            double item3 = 99.95;           // placeholder for item 3
            double item4 = 350.89;           // placeholder for item 4
            string salesName;       // declare salespersons name
            bool validItem;         // checks for valid item number

            Console.Write("Enter a salesperson's name: ");      // Prompt user for salesperson name
            salesName = Console.ReadLine();


            while (intItem != -1)
            {


                do
                {
                    Console.Write("Enter an item number between 1 and 4 or -1 to quit: ");
                    intItem = Convert.ToInt32(Console.ReadLine());

                    if (intItem == -1)
                    {
                        validItem = true;
                    }
                    else if (intItem < 1)
                    {
                        validItem = false;
                        Console.WriteLine("Invalid Entry");
                    }
                    else if (intItem > 4)
                    {
                        validItem = false;
                        Console.WriteLine("Invalid Entry");
                    }
                    else
                    {
                        validItem = true;
                    }


                } while (validItem == false);
                if (intItem != -1)
                {

                    Console.Write("Enter the quantity sold: ");
                    intQuantity = Convert.ToInt32(Console.ReadLine());

                    switch (intItem)
                    {
                        case 1:
                            dblItemSales = intQuantity * item1;
                            dblTotalSales = dblTotalSales + dblItemSales;
                            break;
                        case 2:
                            dblItemSales = intQuantity * item2;
                            dblTotalSales = dblTotalSales + dblItemSales;
                            break;
                        case 3:
                            dblItemSales = intQuantity * item3;
                            dblTotalSales = dblTotalSales + dblItemSales;
                            break;
                        case 4:
                            dblItemSales = intQuantity * item4;
                            dblTotalSales = dblTotalSales + dblItemSales;
                            break;

                        default:
                            break;
                    }
                    Console.WriteLine("Salesperson {0} sold {1} of item #{2} at ${3}", salesName, intQuantity, intItem, dblItemSales);  // Displays item sales
                    Console.WriteLine();
                }
                else if (intItem == -1)
                {
                    Console.WriteLine("Salesperson {0} sold a total of ${1}", salesName, dblTotalSales);  // Displays item sales
                    Console.WriteLine();
                }
            }


            Console.WriteLine("Press any key to continue...");      // Allows user to see program run before window closes
            Console.ReadLine();

        }
    }
}