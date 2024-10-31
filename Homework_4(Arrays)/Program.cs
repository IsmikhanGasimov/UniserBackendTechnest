// See https://aka.ms/new-console-template for more information

////------Task1 Array
//#region
//Console.WriteLine("Enter data");
//Console.Write("Name: ");
//string name = Console.ReadLine();
//Console.Write("Surname: ");
//string surname = Console.ReadLine();
//Console.Write("Age: ");
//string age = Console.ReadLine();
//Console.Write("Major: ");
//string major = Console.ReadLine();
//Console.Write("GPA: ");
//string gpa = Console.ReadLine();

//string[] studentData = { name, surname, age, major, gpa };

//for(int i = 0; i < 5; i++)
//{
//    Console.WriteLine(studentData[i]);
//}
//#endregion




////-------Task2 Array
//#region
//using System.Threading.Channels;

//int[] numbers = new int[5];

//Console.WriteLine("Enter the numbers");
//numbers[0] = Convert.ToInt32(Console.ReadLine());
//numbers[1] = Convert.ToInt32(Console.ReadLine());
//numbers[2] = Convert.ToInt32(Console.ReadLine());
//numbers[3] = Convert.ToInt32(Console.ReadLine());
//numbers[4] = Convert.ToInt32(Console.ReadLine());

//int sum = 0;
//int product = 1;

//foreach(int number in numbers)
//{
//    if (number % 2 == 0)
//    {
//        sum += number;
//    }
//    else
//    {
//        product *= number;
//    }
//}

//Console.WriteLine($"Sum of the even: {sum}");
//Console.WriteLine($"Product of the odd: {product}");
//#endregion



////------Task3 Array
//#region
//int[] numbersA = { 4, 6, -3, 44, -5 };
//int[] numbersB = { 9, 16, 100, 11, -20 };

//int maxNumber = numbersA[0];
//int minNumber = numbersB[0];
//int index1 = 0;
//int index2 = 0;
//for(int i = 0; i < numbersA.Length; i++)
//{
//    if (maxNumber < numbersA[i])
//    {
//        index1 = i;
//        maxNumber = numbersA[i];
//    }
//}

//for (int i = 0; i < numbersB.Length; i++)
//{
//    if (minNumber > numbersB[i])
//    {
//        index2 = i;
//        minNumber = numbersB[i];
//    }
//}

//foreach(var number1 in numbersA)
//{
//    Console.WriteLine(number1);
//}

//foreach (var number2 in numbersB)
//{
//    Console.WriteLine(number2);
//}

//numbersA[index1] = minNumber;
//numbersB[index2] = maxNumber;

//Console.WriteLine("*********************");

//foreach (var number1 in numbersA)
//{
//    Console.WriteLine(number1);
//}

//foreach (var number2 in numbersB)
//{
//    Console.WriteLine(number2);
//}
//#endregion