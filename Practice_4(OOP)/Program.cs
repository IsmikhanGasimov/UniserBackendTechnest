// See https://aka.ms/new-console-template for more information
using Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_4_OOP_
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Melumati daxil");
            Console.WriteLine("Ad");
            string name = Console.ReadLine();
            Console.WriteLine("Soyad");
            string surname = Console.ReadLine();
            Console.WriteLine("Balans");
            int balans = int.Parse(Console.ReadLine());
            Guid guid = Guid.NewGuid();


            Person person = new Person();
            person.Surname = surname;
            person.Name = name;
            person.Balance = balans;
            person.Id = guid;



            Iphone iphone = new Iphone();
            iphone.PhoneName = "Iphone";
            iphone.PhoneModel = "Iphone 11";
            iphone.CompanyName = "Apple";
            iphone.Price = 850;

            if (Iphone.Price > person.Balance)
            {
                Console.WriteLine("Hesabda pul yoxdur");
            }
            else
            {
                Console.WriteLine($"Balansiniz: {person.Balance - iphone.Price}");
            }
        }
    }
}

/*
internal class Person
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }

    private int balance { get; set; }

    public int Balance
    {
        get
        {
            return balance;
        }

        set
        {
            if (value > 1200 || value < 100)
            {
                throw new Exception("Error");

            }
            else
            {
                balance = value;
            }
        }
    }


}*/