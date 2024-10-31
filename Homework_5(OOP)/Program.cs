// See https://aka.ms/new-console-template for more information

using Homework_5_OOP_;
using Homework_5_OOP_.Managers;


Console.WriteLine("Choose one from below");
Console.WriteLine("1.Phone");
Console.WriteLine("2.Computer");
int chooseDesicion = Convert.ToInt32(Console.ReadLine());

switch (chooseDesicion)
{
    case 1:
        Phone phone = new Phone();


        Console.WriteLine("Enter Brand:");
        string marcPhone = Console.ReadLine();
        phone.Marc = marcPhone;

        Console.WriteLine("Enter Model:");
        string modelPhone = Console.ReadLine();
        phone.Model = modelPhone;

        Console.WriteLine("Enter Price:");
        int pricePhone = Convert.ToInt32(Console.ReadLine());
        phone.Price = pricePhone;

        Console.WriteLine("Enter OS:");
        string operatingSystemPhone = Console.ReadLine();
        phone.OperatingSystem = operatingSystemPhone;

        Console.WriteLine("Enter Pixels:");
        int pixelPhone = Convert.ToInt32(Console.ReadLine());
        phone.CameraMegaPixels = pixelPhone;

        Console.WriteLine("Choose an operation");
        Console.WriteLine("1 - Display the information");
        Console.WriteLine("2 - Pixels");
        Console.WriteLine("3 - Price with tax.");

        int choicePhone = Convert.ToInt32(Console.ReadLine());

        PhoneManager phoneManager = new PhoneManager(phone);
        switch (choicePhone)
        {
            case 1:
                phoneManager.DisplayInfo();
                break;
            case 2:
                phoneManager.CheckCamera();
                break;
            case 3:
                phoneManager.CalcPriceWithTax();
                break;
            default:
                Console.WriteLine("There is no information, try again");
                break;
        }
        break;

    case 2:
        Computer computer = new Computer();

        Console.WriteLine("Enter Brand:");
        string marcComputer = Console.ReadLine();
        computer.Marc = marcComputer;

        Console.WriteLine("Enter Model:");
        string modelComputer = Console.ReadLine();
        computer.Model = modelComputer;

        Console.WriteLine("Enter Price:");
        int priceComputer = Convert.ToInt32(Console.ReadLine());
        computer.Price = priceComputer;

        Console.WriteLine("Enter OS:");
        string osComputer = Console.ReadLine();
        computer.OperatingSystem = osComputer;

        Console.WriteLine("Enter Processor:");
        string prosessorComputer = Console.ReadLine();
        computer.ProcessorType = prosessorComputer;

        Console.WriteLine("Enter Ram:");
        int ramComputer = Convert.ToInt32(Console.ReadLine());
        computer.Ram = ramComputer;

        Console.WriteLine("Choose an operation");
        Console.WriteLine("1 - Display the information");
        Console.WriteLine("2 - Ram");
        Console.WriteLine("3 - Price with tax");
        
        int choiceComputer = Convert.ToInt32(Console.ReadLine());
        ComputerManager computerManager = new ComputerManager(computer);
        switch (choiceComputer)
        {
            case 1:
                computerManager.DisplayInfo();
                break;
            case 2:
                computerManager.GetUsefulOrNot();
                break;
            case 3:
                computerManager.CalcPriceWithTax();
                break;
            default:
                Console.WriteLine("There is no information, try again");
                break;
        }
        break;

    default:
        Console.WriteLine("Enter 1 or 2");
        break;
}
