// See https://aka.ms/new-console-template for more information


using Practice__File_Handling_;
using System.Net.Security;

//string path = @"C:\Users\USER\Documents\Uniser";
//string newFolderPAth = Path.Combine(path, "UniserWorkers.txt");

//File.Create(newFolderPAth);
//Console.WriteLine(newFolderPAth);

//Employee employee = new Employee();
//List<Employee> employees = new List<Employee>()
//{
//    new Employee{employeeName="Aynur",employeeSurname="Axundzade",salary=500},
//    new Employee{employeeName="Gunel",employeeSurname="Humbetova",salary=800},
//    new Employee{employeeName="Tebriz",employeeSurname="Letifov",salary=1000},
//};

//List<string> employeersInfo = new List<string>();
//foreach(Employee employeer in employees)
//{
//    employeersInfo.Add($"{employeer.employeeId}, {employeer.employeeName}, {employee.employeeSurname}, {employee.salary}");
//}

//File.AppendAllLines(newFolderPAth, employeersInfo);

//string[] lines = File.ReadAllLines(newFolderPAth);


//foreach(var line in lines)
//{
//    Console.WriteLine(line);
//}


//Console.Write("Enter the word: ");
//string searchingWord = Console.ReadLine();
//List<string> output = new List<string>();


//if (File.Exists(newFolderPAth))
//{
//    foreach (string line in lines)
//    {
//        if (line.Contains(searchingWord))
//        {
//            output.Add(line);
//        }
//    }
//}


//else
//{
//    Console.WriteLine("This file does not exist");
//}


//foreach (string item in output)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine("Folderin adini daxil edin");
//string folderName = Console.ReadLine();
//Console.WriteLine("Faylin adini daxil edin");
//string fileName = Console.ReadLine();

//string secondPath = $@"C:\Users\USER\Documents\{folderName}\{fileName}";

//if (File.Exists(secondPath))
//{
//    Console.WriteLine("Exists");
//}
//else
//{
//    Console.WriteLine("Does not exist");
//}


string path = @"C:\Users\USER\Documents\Uniser";
string inputFile = @"C:\Users\USER\Documents\Uniser\UniserWorkers.txt";

string outputPath = Path.Combine(path, "OutputFile.txt");
//File.Create(outputPath);

int key = 2;

Encryption(inputFile, outputPath, key);

void Encryption(string inputFile, string outputFile,int key)
{
    byte[] inputBytes = File.ReadAllBytes(inputFile);
    for(int i = 0; i < inputBytes.Length; i++)
    {
        inputBytes[i] = (byte)(inputBytes[i] * key);
    }

    File.WriteAllBytes(outputFile, inputBytes);
    Console.WriteLine("Operation completed");
}

