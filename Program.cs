// See https://aka.ms/new-console-template for more information

////------Task 1 Loops
//#region
//using System.Numerics;
//int i = 1;
//BigInteger product = 1;

//while (i <= 50)
//{
//    product *= i;
//    i +=3;
//}

//Console.WriteLine($"The product of numbers: {product}");
//#endregion



////------Task 2 Loops
//#region
//using System.Numerics;
//int sum = 0;
//BigInteger product = 1;
//int count = 0;
//for (int number = -30; number <= 28; number++)
//{
//    if ((number % 3 == 0 && number % 6 == 0) && number != 0)
//    {
//        sum += number;
//    }

//    if ((number % 5 == 0 || number % 2 == 0) && number != 0)
//    {
//        product *= number;
//    }

//}

//Console.WriteLine($"Sum of numbers which divide by 3 and 6: {sum}");

//Console.WriteLine($"Product of numbers which divide by 5 or 2: {product}");

//Console.WriteLine($"The count of prime numbers {count}");
//#endregion




////--------Task 3 Loops
//#region
//int number = 304001;
//int reminder = 0;
//int sumOfNumbers = 0;
//int countOfNumbers = 0;
//while (number != 0)
//{
//    reminder = number % 10;
//    number = number / 10;
//    sumOfNumbers += reminder;
//    countOfNumbers++;
//}

//Console.WriteLine($"The sum of numbers: {sumOfNumbers}");
//Console.WriteLine($"The count of numbers: {countOfNumbers}");
//#endregion



////------Task 4 Loops
//#region
//int number = 4573;
//int n = number;
//int reminder = 0;
//int reverse = 0;
//while (number != 0)
//{
//    reminder = number % 10;
//    number = number / 10;
//    reverse = (reverse*10)+reminder ;

//}
//Console.WriteLine($"The number: {n}");
//Console.WriteLine($"The reverse: {reverse}");
//#endregion





////------Task 5 Loops
//#region
//string correctLogin = "booleanteach";
//string correctPassword = "booleanms13";
//int count = 0;

//while (count < 3)
//{
//    Console.WriteLine("Enter Login and Password");
//    Console.Write("Login: ");
//    string login = Console.ReadLine();
//    Console.Write("Password: ");
//    string password = Console.ReadLine();

//    if (login != correctLogin && password == correctPassword)
//    {
//        Console.WriteLine("Wrong Login");
//    }
//    else if (login == correctLogin && password != correctPassword)
//    {
//        Console.WriteLine("Wrong Password");
//    }
//    else if (login != correctLogin && password != correctPassword)
//    {
//        Console.WriteLine("Wrong Login and Password");
//    }
//    else
//    {
//        Console.WriteLine("Welcome");
//        break;
//    }
//    count++;
//    if (count >= 3)
//    {
//        Console.WriteLine("System Blocked");
//    }
//}

//#endregion

