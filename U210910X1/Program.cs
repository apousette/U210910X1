using System;
using System.Collections.Generic;

namespace U210910X1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Vad som visas när programmet öppnas
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                Console.WriteLine("X-Company kund-system. Vill du; \n");
                Console.WriteLine("1. Lägga till en ny kund, \n2. Se antalet kunder, \n3. Se en lista över alla kunder, \n4. Avsluta programmet?\n");
                Console.WriteLine("För att välja alternativ mata in respektive siffra i konsolen.");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");

                string choice = Console.ReadLine();

                //Skapa ny kund
                if (choice == "1" )
                {
                    //Inmatningsprocessen av kundens egenskaper.
                    Customer myCustomer;
                    myCustomer = new Customer();
                    myCustomer.Name = Console.ReadLine();
                    myCustomer.Phone = Console.ReadLine();
                    myCustomer.Adress = Console.ReadLine();

                    Console.WriteLine($"Ny kund tillagd: \nNamn: {myCustomer.Name} \nTelefonnummer: {myCustomer.Phone} \nAdress: {myCustomer.Adress}");

                    //Lista
                    List<Customer> MyCustomers = new List<Customer>();
                    MyCustomers.Add(myCustomer);

                }

                //Visa antalet kunder
                if (choice == "2")
                {
                    //Ta fram antalet kunde

                }

                //Visa alla kunder
                if (choice == "3")
                {
                    //


                }

                //Avsluta programmet
                if (choice == "4")
                {
                    //Avslutar loopen genom break
                    break;
                }

                if (choice != "1" && choice != "2" && choice != "3" && choice != "4")
                {
                    Console.WriteLine("FELAKTIG INMATNING\n För att använda programmet mata in ett av de fyra alternativen 1, 2, 3 eller 4.");
                }

            }
        }
    }

    public class Customer
    {
        //Kundens olika egenskaper som matas in av användaren.
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }

    }

}
