using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishan_Sharma_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //invoiceArray variable to store some Invoice objects
                Invoice[] invoiceArray =  {
                new Invoice(83, "Electric Sander", 7, 57.98),
                new Invoice(24, "Power Saw", 18, 99.99),
                new Invoice(7, "Sledge Hammer", 11, 21.50),
                new Invoice(77, "Hammer", 76, 11.99),
                new Invoice(39, "Lawn Mover", 3, 79.50),
                new Invoice(68, "Screwdriver", 106, 6.99),
                new Invoice(56, "Jigsaw", 21, 11.00),
                new Invoice(3, "Wrench", 34, 7.50)
            };

                Invoice.ObjectsByPartDescription(invoiceArray);
                Invoice.ObjectsByPrice(invoiceArray);
                Invoice.ObjectsByPartDescriptionAndQuantity(invoiceArray);
                Invoice.ObjectsByPartDesAndInvoice(invoiceArray);
                Invoice.InvoicesRangeDisplayMethod(invoiceArray);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }
    }
}
