// See https://aka.ms/new-console-template for more information
using Practice_task;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the data");
        Console.WriteLine("Name");
        string name = Console.ReadLine();
        Console.WriteLine("Surname");
        string surname = Console.ReadLine();
        Console.WriteLine("Balance");
        int balance = int.Parse(Console.ReadLine());
        Guid id = Guid.NewGuid();


        Person person = new Person();
        person.Surname = surname;
        person.Name = name;
        person.Balance = balance;
        person.Id = id;

        Console.WriteLine($"Name: {name}  Surname: {surname} Balance: {balance} Id: {id}");


        Bmw bmw = new Bmw();
        bmw.CarName = "BMW";
        bmw.Model = "F 10";
        bmw.CarColour = "Black";
        bmw.Price = 50000;

        if (bmw.Price > person.Balance)
        {
            Console.WriteLine("You dont have enough money on your accout");
        }
        else
        {
            Console.WriteLine($"Your Balance: {person.Balance - bmw.Price}");
        }
    }
}
