using System;

namespace ConsoleFirstProject.Models
{
    class PhoneBook
    {
        public string phone;
        public string name;

        public void ShowAllData()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("phone: " + phone);
        }

    }
}
