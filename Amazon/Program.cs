using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    class Program
    {
        static void Main(string[] args)
        {
                ShoppStoreDAO storeDAO = new ShoppStoreDAO();
            
                ConsoleColor color = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Welcome To Amazon");
                Console.WriteLine("==================");
                Console.ForegroundColor = color;
               
            
            string Option = "6";
            while (Option == "6")
            {
                Console.WriteLine("\n\nChoice your option:\n" +
                   "___________________________\n" +
                   "Press '1' To Id As Customer.\n" +
                   "Press '2' To Create New Customer Account.\n" +
                   "Press '3' To Choice Supplier. \n" +
                   "Press '4' To Choice your Orders. \n" +
                   "Press '0' To Exit.n");

                Option = Console.ReadLine();
                Console.WriteLine();
                if(Option == "1")
                {
                    Console.WriteLine("\nEnter Your Details:\n" +
                        "__________________");

                    Console.Write("FirstName: "); string FirstName = Console.ReadLine();
                    Console.Write("LastName: "); string LastName = Console.ReadLine();
                    storeDAO.GetCustomerName(FirstName);

                }
                if(Option == "2")
                {
                    Console.Write("FirstName: "); string FirstName = Console.ReadLine();
                    Console.Write("LastName: "); string LastName = Console.ReadLine();
                    storeDAO.GetCustomerName(Option);
                }
                if(Option == "3")
                {
                    Console.WriteLine("\nChoice you Supplier");
                    Console.Write("FirstName: "); string FirstName = Console.ReadLine();
                    Console.Write("LastName: "); string LastName = Console.ReadLine();
                    storeDAO.GetSupplierByName(FirstName);
                }
                if(Option == "4")
                {
                    storeDAO.GetOrders(3);
                }
                if(Option == "0")
                {
                    break;
                }
                if(Option == "6")
                {
                    throw new Exception("Select your option 0 - 5 ");
                }
                Option = "6";
               
               
               
                
                
            }

         
        }
       
      
    }
}
