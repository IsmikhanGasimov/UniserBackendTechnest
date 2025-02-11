﻿// See https://aka.ms/new-console-template for more information

using Practice_OOP_polymorphism_;

internal class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.Balance = 29;

        Pizza pizza = new Pizza();
        Console.WriteLine("Seciminiz hansidir?");
        Console.WriteLine("Margaritta");
        Console.WriteLine("Peperonni");
        Console.WriteLine("Mix");
        pizza.PizzaType = Console.ReadLine();

        if (pizza.PizzaType == "Margaritta")
        {
            Console.WriteLine("Kart melumatlarinizi daxil edin");
            Console.WriteLine("Kart hesabi qetd edin");
            person.CardNumber = Console.ReadLine();
            Console.WriteLine("Kart bitme muddeti");
            person.ExpDate = Console.ReadLine();
            Console.WriteLine("CVV daxil edin");
            person.CVV = Console.ReadLine();

            if(person.CardNumber.Length==16 && person.ExpDate.Length==5 && person.CVV.Length == 3)
            {
                Margaritta margaritta = new Margaritta();
                Console.WriteLine("Pizzanin olcusu");
                margaritta.PizzaSize = Console.ReadLine();
                Console.WriteLine("Pizza hazirlanir");
                Console.WriteLine($"Balans:{person.Balance-margaritta.CalcPizzaPrice()}");
            }

        }



        else if (pizza.PizzaType == "Peperonni")
        {
            Console.WriteLine("Kart melumatlarinizi daxil edin");
            Console.WriteLine("Kart hesabi qetd edin");
            person.CardNumber = Console.ReadLine();
            Console.WriteLine("Kart bitme muddeti");
            person.ExpDate = Console.ReadLine();
            Console.WriteLine("CVV daxil edin");
            person.CVV = Console.ReadLine();

            if (person.CardNumber.Length == 16 && person.ExpDate.Length == 5 && person.CVV.Length == 3)
            {
                Peperonni peperonni = new Peperonni();
                Console.WriteLine("Pizzanin olcusu");
                peperonni.PizzaSize = Console.ReadLine();
                Console.WriteLine("Pizza hazirlanir");
                Console.WriteLine($"Balans:{person.Balance - peperonni.CalcPizzaPrice()}");
            }

        }

    }
    
}
