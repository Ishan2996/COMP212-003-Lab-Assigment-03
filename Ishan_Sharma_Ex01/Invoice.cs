using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishan_Sharma_Ex01
{
    class Invoice
    {

        //Properties
        public int partNumber { get; set; }
        public string partDescription { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        
        //Constructor
        public Invoice(int PartNumber, string PartDescription, int Quantity, double Price)
        {
            partNumber = PartNumber;
            partDescription = PartDescription;
            quantity = Quantity;
            price = Price;
        }

        //Method:1 Sort By Parts Description
        public static void ObjectsByPartDescription(Invoice[] invoiceArray)
        {
            
            var objectsByPartDescription = from a in invoiceArray
                                           orderby a.partDescription 
                                           select a;
            Console.WriteLine("(a) Objects Sorted By Part Description \n");
           
            foreach (Invoice a in objectsByPartDescription)
            {                         
             Console.WriteLine("Part Description:" + a.partDescription + "-----------" + "Part Number:" + a.partNumber + "-----------" + "Quantity:" + a.quantity + "-----------" + "Price:" + a.price );                             
            }
            Console.WriteLine("\n**************************************************************************************");
        }

        //Method:2 Sort By Price
        public static void ObjectsByPrice(Invoice[] invoiceArray)
        {
            var objectsByPriceDescription = from a in invoiceArray 
                                            orderby a.price
                                            select a;
            Console.WriteLine("(b) Objects Sorted By Price \n");
            
            foreach (Invoice a in objectsByPriceDescription)
            {
                Console.WriteLine("Price:" + a.price + "-----------" + "Part Description:" + a.partDescription + "-----------" + "Part Number:" + a.partNumber + "-----------" + "Quantity:" + a.quantity );
            }
            Console.WriteLine("\n**************************************************************************************");
        }


        //Method:3 Sort By Parts Description and Quantity
        public static void ObjectsByPartDescriptionAndQuantity(Invoice[] invoiceArray)
        {
            var objectsByQuantity = from a in invoiceArray
                                    orderby a.quantity
                                    select new { a.partDescription, a.quantity, a.partNumber, a.price };
            Console.WriteLine("(c) Objects by Part Description and Quantity And Sorted By Quantity \n");
           

            foreach (var a in objectsByQuantity)
            {
                Console.WriteLine("Quantity:" + a.quantity + "-----------" + "Part Description:" + a.partDescription + "-----------" + "Part Number:" + a.partNumber + "-----------" +  "Price:" + a.price);
            }
            Console.WriteLine("\n**************************************************************************************");
        }

        //Method:3 Sort By Invoice
        public static void ObjectsByPartDesAndInvoice(Invoice[] invoiceArray)
        {
            var objectsByPartDesAndInvoice = from a in invoiceArray
                                             let invoice = (a.quantity * a.price)
                                             select new { a.partDescription, invoice, a.quantity, a.price };

            Console.WriteLine("(d) Objects by Part Description and Sorted By Invoice \n");
            
            foreach (var a in objectsByPartDesAndInvoice)
            {
                Console.WriteLine("Part Description:" + a.partDescription + "-----------" + "Quantity*Price=" + a.quantity + "*" + a.price + "---------------" + "Invoice:"  + a.invoice);
            }
            Console.WriteLine("\n**************************************************************************************");
        }

        public static void InvoicesRangeDisplayMethod(Invoice[] invoiceArray)
        {
            var objectsByInvoiceRange = from a in invoiceArray
                                        let invoice = (a.quantity * a.price)
                                        where (invoice >= 200 && invoice <= 500)
                                        select new { a.partNumber, a.partDescription, invoice };

            Console.WriteLine("(e) Object With Part Description, Quantity and Invoice ($200-$500)");
          
            foreach (var a in objectsByInvoiceRange)
            {
                Console.WriteLine("Part Description:" + a.partDescription + "-------------" + "Part Number:" + a.partNumber + "-------------" + "Invoice:" + a.invoice);
            }
            Console.WriteLine("\n**************************************************************************************");
        }
    }
}
