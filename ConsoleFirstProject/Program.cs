using System;
using ConsoleFirstProject.Models;

namespace ConsoleFirstProject
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            PhoneBook myPhone = new PhoneBook
            {
                phone = "2257261",
                name = "Jahongir"
            };
            Console.WriteLine(myPhone.name);
            Console.ReadLine();
            

        }
}