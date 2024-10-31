// See https://aka.ms/new-console-template for more information
using System;
using System.Transactions;


//CTRL+K+D kodu seliqeye salir
//CTRL+K+C  == comment
//CTRL+K+U  == uncomment
Console.WriteLine("Hello, World!");


//var_type var_name = 13
//Tam ededler - int,short,long

//int numberOne = 10;  //32bit
//long numberTwo = 12; //64bit
//short numberThree = 15;  //16bit


//Console.WriteLine(numberOne);
//Console.WriteLine(numberTwo);
//Console.WriteLine(numberThree);


//int sum = 10 + 15;
//Console.WriteLine(sum);


#region
Console.WriteLine("Enter your name");
Console.Write("name: ");
string studentName = Console.ReadLine();


Console.WriteLine("Enter your surname");
Console.Write("surname: ");
string studentSurname = Console.ReadLine();



Console.WriteLine($"Hi, my name is {studentName} {studentSurname}");
Console.WriteLine("Hi my name is {0} {1}", studentName, studentSurname);
Console.WriteLine("Hi my name is " + studentName + " " + studentSurname);
#endregion

double value1 = Math.Pow(16, 1.0 / 4.0);
Console.WriteLine(value1);
