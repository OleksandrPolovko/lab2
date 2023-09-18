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

        static void Main(string[] args)
        {
            Task1();
        }
    }
}
