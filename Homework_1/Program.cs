// See https://aka.ms/new-console-template for more information

//---------Task1
#region
Console.WriteLine("Enter the name of department:");
string nameOfdep = Console.ReadLine();

if (nameOfdep == "HR" || nameOfdep == "Hr" || nameOfdep == "hr")
{
    Console.WriteLine("Human Resources Department");
}
else if (nameOfdep == "IT" || nameOfdep == "It" || nameOfdep == "it")
{
    Console.WriteLine("Information Technologies Department");
}
else if (nameOfdep == "Finance" || nameOfdep == "finance")
{
    Console.WriteLine("Finance Department");
}
else
{
    Console.WriteLine("There is no such department");
}
#endregion







////---------Task2
//#region
//Console.WriteLine("Enter the duration of your work experience");
//int workYears = Convert.ToInt32(Console.ReadLine());

//if (workYears>=0 && workYears <=2)
//{
//    Console.WriteLine("Your salary is 2000 ");

//}
//else if(workYears >= 3 && workYears <= 5)
//{
//    Console.WriteLine("Your salary is 5000 ");

//}
//else if(workYears >5 && workYears <= 10)
//{
//    Console.WriteLine("Your salary is 7000 ");

//}
//else if (workYears > 10)
//{
//    Console.WriteLine("Your salary is 10000 ");

//}
//#endregion






////-------Task3
//#region
//Console.WriteLine("Enter the time of the day");
//int dayTime = Convert.ToInt32(Console.ReadLine());

//if (dayTime > 0 && dayTime <= 24)
//{
//    if (dayTime < 12)
//    {
//        Console.WriteLine("Good Morning");

//    }
//    else if (dayTime >= 12 && dayTime <= 17)
//    {
//        Console.WriteLine("Good Afternoon");

//    }
//    else
//    {
//        Console.WriteLine("Good Evening");
//    }
//}
//else
//{
//    Console.WriteLine("The time is not correct");
//}
//#endregion







////---------Task4
//#region
//Console.WriteLine("Enter 3 numbers");
//int num1 = Convert.ToInt32(Console.ReadLine());
//int num2 = Convert.ToInt32(Console.ReadLine());
//int num3 = Convert.ToInt32(Console.ReadLine());

//int meanValue = (num1 + num2 + num3) / 3;
//Console.WriteLine($"Value: {meanValue}");
//if (meanValue <= 20)
//{
//    Console.WriteLine("Active");
//}
//else
//{
//    Console.WriteLine("Not Active");
//}
//#endregion







////-----------Triangle Task
//#region
//Console.WriteLine("Enter the sides of triangle");
//int side1 = Convert.ToInt32(Console.ReadLine());
//int side2 = Convert.ToInt32(Console.ReadLine());
//int side3 = Convert.ToInt32(Console.ReadLine());


//if (side1<side2+side3 && side2 < side1 + side3 && side3 < side1 + side2)
//{
//    Console.WriteLine("Triangle is existing");
//    if (side1 == side2 && side1 == side3 && side2 == side3)
//    {
//        Console.WriteLine("Equilateral triangle");

//    }
//    else if (side1 == side2 || side1 == side3 || side2 == side3)
//    {
//        Console.WriteLine("Isosceles triangle");
//    }
//    else
//    {
//        Console.WriteLine("Scalene triangle");
//    }
//}
//else
//{
//    Console.WriteLine("Triangle does not exist");
//}
//#endregion






////----------Weather task
//#region
//Console.WriteLine("Enter the type of weather");
//string weatherType = Console.ReadLine();
//switch (weatherType)
//{
//    case "sunny":
//        {
//            Console.WriteLine("The weather is beautiful");
//        }
//        break;

//    case "rainy":
//        {
//            Console.WriteLine("Take your umbrella, today is a rainy day");
//        }
//        break;
//    case "snowy":
//        {
//            Console.WriteLine("Dress warmly, it is so cold outside");
//        }
//        break;
//    case "cloudy":
//        {
//            Console.WriteLine("It might be cold, you need a jacket");
//        }
//        break;

//    default:
//        {
//            Console.WriteLine("Wrong weather type");
//        }
//        break;
//}
//#endregion




////------------Month task
//#region
//Console.WriteLine("Enter the number between 1 and 12");
//int monthNumber = Convert.ToInt32(Console.ReadLine());

//if (monthNumber<1 || monthNumber > 12)
//{
//    Console.WriteLine("Wrong number,try again");
//}
//else
//{
//    switch (monthNumber)
//    {
//        case 1:
//            {
//                Console.WriteLine("It's January");
//            }
//            break;
//        case 2:
//            {
//                Console.WriteLine("It's February");
//            }
//            break;
//        case 3:
//            {
//                Console.WriteLine("It's March");
//            }
//            break;
//        case 4:
//            {
//                Console.WriteLine("It's April");
//            }
//            break;
//        case 5:
//            {
//                Console.WriteLine("It's May");
//            }
//            break;
//        case 6:
//            {
//                Console.WriteLine("It's June");
//            }
//            break;
//        case 7:
//            {
//                Console.WriteLine("It's July");
//            }
//            break;
//        case 8:
//            {
//                Console.WriteLine("It's August");
//            }
//            break;
//        case 9:
//            {
//                Console.WriteLine("It's September");
//            }
//            break;
//        case 10:
//            {
//                Console.WriteLine("It's October");
//            }
//            break;
//        case 11:
//            {
//                Console.WriteLine("It's November");
//            }
//            break;
//        case 12:
//            {
//                Console.WriteLine("It's December");
//            }
//            break;
//        default:
//            {
//                Console.WriteLine("Wrong Number");
//            }
//            break;

//    }
//}
//#endregion






////---------Ternary operator task
//#region
//Console.WriteLine("Enter number");
//int num = Convert.ToInt32(Console.ReadLine());
//string result = num >= 0 ? "Positive" : "Negative";
//Console.WriteLine(result);
//#endregion


