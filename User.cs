using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public DateTime Date { get; }

        public User(string login, string name, string surname, int age)//логін, ім'я, прізвище, вік, дату заповнення анкети
        {
            Login = login; 
            Name = name;
            Surname = surname;
            Age = age;
            Date = System.DateTime.Now;
        }

        public void Output()
        {
            Console.WriteLine("Login: " + Login);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Surname: " + Surname);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Date: " + Date);
        }

    }
}
