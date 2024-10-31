// See https://aka.ms/new-console-template for more information

using AreaCalculator_OOP.Figures;
using AreaCalculator_OOP.Triangle;
using System.Security.Authentication;

Console.WriteLine("Area Calculator");
Console.WriteLine("1.Calculate the area of triangle");
Console.WriteLine("2.Calculate the area of circle");
Console.WriteLine("3.Calculate the area of rectangle");

int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.Write("Enter the 1 side of triangle");
        int side1= Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the 2 side of triangle");
        int side2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the 3 side of triangle");
        int side3 = Convert.ToInt32(Console.ReadLine());

        Triangle triangle = new Triangle();
        triangle.Side1 = side1;
        triangle.Side2 = side2;
        triangle.Side3 = side3;

        Console.WriteLine(triangle.CalcAreaOfTriangle());
        break;

    case 2:
        Console.WriteLine("Enter the radius of circle");
        int radius = Convert.ToInt32(Console.ReadLine());

        Circle circle = new Circle();
        circle.Radius = radius;
        Console.WriteLine(circle.CalcAreaOfCircle());

        break;

    case 3:
        Console.WriteLine("Enter the 1 side of rectangle:");
        int rSide1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the 2 side of rectangle:");
        int rSide2 = Convert.ToInt32(Console.ReadLine());



        break;


    default:
        break;
}

