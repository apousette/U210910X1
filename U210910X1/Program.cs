using System;
using System.Collections.Generic;

namespace U210910X1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista
            List<Customer> MyCustomers = new List<Customer>();

            while (true)
            {
                //Vad som visas när programmet öppnas.
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                Console.WriteLine("X-Company kund-system. Vill du; \n" +
                                  "1. Lägga till en ny kund, \n" +
                                  "2. Se antalet kunder, \n" +
                                  "3. Se en lista över alla kunder, \n" +
                                  "4. Avsluta programmet?\n");
                Console.WriteLine("För att välja alternativ mata in respektive siffra i konsolen.");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");

                string choice = Console.ReadLine();
                Console.Clear();

                //Skapa ny kund.
                if (choice == "1" )
                {
                    //Inmatningsprocessen av kundens egenskaper.
                    Customer myCustomer;
                    myCustomer = new Customer();

                    Console.WriteLine("Skriv in kundens namn:");
                    myCustomer.Name = Console.ReadLine();
                    Console.WriteLine("Skriv in kundens telefonnummer:");
                    myCustomer.Phone = Console.ReadLine();
                    Console.WriteLine("Skriv in kundens adress:");
                    myCustomer.Adress = Console.ReadLine();

                    Console.WriteLine("\n¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                    Console.WriteLine($"Ny kund tillagd: \n" +
                                      $"Namn: {myCustomer.Name} \n" +
                                      $"Telefonnummer: {myCustomer.Phone} \n" +
                                      $"Adress: {myCustomer.Adress}\n" +
                                      "¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");

                    Console.WriteLine("Tryck på ENTER för att gå tillbaka till menyn.");
                    Console.ReadLine();

                    MyCustomers.Add(myCustomer);
                    
                    //Rensar konsolen inför nästa inmatning.
                    Console.Clear();
                }

                //Visa antalet kunder.
                if (choice == "2")
                {
                    //Ta fram antalet kunde
                    Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨\n");
                    Console.WriteLine($"I nuläget finns det {MyCustomers.Count} kunder inskrivna i systemet.\n");
                    Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨\n");
                    Console.WriteLine("Tryck på ENTER för att gå tillbaka till menyn.");
                    Console.ReadLine();
                    Console.Clear();
                }

                //Visa alla kunder
                if (choice == "3")
                {
                    Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");

                    //Går igenom alla kunder i listan och matar ut all info om dem i konsollen.
                    foreach (Customer c in MyCustomers)
                    {
                        Console.WriteLine($"{c.Name} {c.Phone} {c.Adress}");
                    }

                    Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");

                    Console.WriteLine("Tryck på ENTER för att gå tillbaka till menyn.");
                    Console.ReadLine();
                    Console.Clear();
                }

                //Avsluta programmet.
                if (choice == "4")
                {
                    //Avslutar loopen genom break.
                    break;
                }

                //Vid felaktig inmatining
                if (choice != "1" && choice != "2" && choice != "3" && choice != "4")
                {
                    //Skriver ut meddelande om felaktig inmatning.
                    Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                    Console.WriteLine("FELAKTIG INMATNING \n" +
                                      "För att använda programmet mata in ett av de fyra alternativen 1, 2, 3 eller 4.\n" +
                                      "Tryck på ENTER för att gå vidare.");
                    Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                    Console.ReadLine();
                    Console.Clear();
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
