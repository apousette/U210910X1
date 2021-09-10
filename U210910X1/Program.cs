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
                Console.WriteLine("Du är nu inne i kund-systemet.");
                Console.WriteLine("Vill du; \n1. Lägga till en ny kund, \n2. Se antalet kunder, \n3. Se en lista över alla kunder, \n4. Avsluta programmet?");
                Console.WriteLine("");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");

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
        }
    }

    public class Customer
    {
        //Kundens olika egenskaper som matas in av användaren.
        public string Name;
        public string Phone;
        public string Adress;

    }

}
