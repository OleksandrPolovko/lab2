using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Task1()
        {
            //Створити екземпляр класу Address.
            Address addr = new Address();

            //У поля екземпляра записати інформацію про поштову адресу. 
            addr.Index = 07442;
            addr.Country = "Ukraine";
            addr.City = "Kyiv";
            addr.Street = "Parkhomenko";
            addr.House = "23b";
            addr.Apartment = 8;

            //Виведіть на екран значення полів, що описують адресу.
            Console.Out.WriteLine("Index: " + addr.Index);
            Console.Out.WriteLine("Country: " + addr.Country);
            Console.Out.WriteLine("City: " + addr.City);
            Console.Out.WriteLine("Street: " + addr.Street);
            Console.Out.WriteLine("House: " + addr.House);
            Console.Out.WriteLine("Apartment: " + addr.Apartment);
        }
        static void Task2()
        {
            //Створити екземпляр класу Converter.
            Converter conv = new Converter(37.6, 40.2, 8.3);
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Convert Hrivnas to Dollars.");
            Console.WriteLine("2. Convert Hrivnas to Euros.");
            Console.WriteLine("3. Convert Hrivnas to Zlots.");
            Console.WriteLine("4. Convert Dollars to Hrivnas.");
            Console.WriteLine("5. Convert Euros to Hrivnas.");
            Console.WriteLine("6. Convert Zlots to Hrivnas.");
            Console.WriteLine("Please, select one (1-6)");
            string user_selection = Console.ReadLine();
            int selection = Convert.ToInt16(user_selection);

            if (selection == 1)//1. Convert Hrivnas to Dollars.
            {
                Console.WriteLine("How much do you have Hrivnas?");
                String str = Console.ReadLine();
                double users_hrivnas = Convert.ToDouble(str);
                Console.WriteLine("These are " + conv.GrnToUsd(users_hrivnas) + " dollars.");
            }
            else if (selection == 2)//2. Convert Hrivnas to Euros.
            {
                Console.WriteLine("How much do you have Hrivnas?");
                String str = Console.ReadLine();
                double users_hrivnas = Convert.ToDouble(str);
                Console.WriteLine("These are " + conv.GrnToEur(users_hrivnas) + " euros.");
            }
            else if (selection == 3)//3. Convert Hrivnas to Zlots.
            {
                Console.WriteLine("How much do you have Hrivnas?");
                String str = Console.ReadLine();
                double users_hrivnas = Convert.ToDouble(str);
                Console.WriteLine("These are " + conv.GrnToPln(users_hrivnas) + " zlots.");
            }
            else if (selection == 4)//4. Convert Dollars to Hrivnas.
            {
                Console.WriteLine("How much do you have Dollars?");
                String str = Console.ReadLine();
                double users_dollars = Convert.ToDouble(str);
                Console.WriteLine("These are " + conv.UsdToGrn(users_dollars) + " hrivnas.");
            }
            else if (selection == 5)//5. Convert Euros to Hrivnas.
            {
                Console.WriteLine("How much do you have Euros?");
                String str = Console.ReadLine();
                double users_euros = Convert.ToDouble(str);
                Console.WriteLine("These are " + conv.EurToGrn(users_euros) + " hrivnas.");
            }
            else if (selection == 6)//6. Convert Zlots to Hrivnas.
            {
                Console.WriteLine("How much do you have Zlots?");
                String str = Console.ReadLine();
                double users_zlots = Convert.ToDouble(str);
                Console.WriteLine("These are " + conv.PlnToGrn(users_zlots) + " hrivnas.");
            }
            else //Error 
            {
                Console.WriteLine("I cannot do this operation.");
            }
        }

        static void Main(string[] args)
        {
            Task2();
        }
    }
}
