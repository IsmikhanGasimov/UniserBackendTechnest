// See https://aka.ms/new-console-template for more information



//Console.WriteLine("Enter 2 numbers");
//int num1 = Convert.ToInt32(Console.ReadLine()); 
//int num2 = Convert.ToInt32(Console.ReadLine());
//int MAX = 0;

//if (num1 < num2)
//{
//    MAX = num2;
//    Console.WriteLine($"{MAX} is maximum");
//}
//else if (num1 > num2)
//{
//    MAX = num1;
//    Console.WriteLine($"{MAX} is maximum");
//}
//else
//{
//    Console.WriteLine("Numbers are equal");
//}


Console.WriteLine("Enter the number of season");
int numberOfseason = Convert.ToInt32(Console.ReadLine());
switch (numberOfseason)
{
    case 1:
        Console.WriteLine("Winter");
        break;
    case 2:
        Console.WriteLine("Spring");
        break;
    case 3:
        Console.WriteLine("Summer");
        break;

    case 4:
        Console.WriteLine("Autumn");
        break;

    default:
        Console.WriteLine("Wrong Number");
        break;
}

