using static System.Console;
using static System.Convert;

//--------Task 1
/*
WriteLine("Restoranimiza xos gelmisiniz");
Write("Hesabi daxil edin: ");
double orderTotal = ToDouble(ReadLine());

if (orderTotal >= 100)
{
    WriteLine("Musterinin statusunu daxil edin");
    string customerStatus = ReadLine();
    int discount = 0;
    switch (customerStatus)
    {
        case "gold":
            discount = 20;
            WriteLine($"Size {discount} faiz endirim tetbiq olundu");

            break;
        case "silver":
            discount = 15;
            WriteLine($"Size {discount} faiz endirim tetbiq olundu");

            break;
        case "bronze":
            discount = 10;
            WriteLine($"Size {discount} faiz endirim tetbiq olundu");

            break;
        default:
            discount = 5;
            WriteLine($"Size {discount} faiz endirim tetbiq olundu");
            break;

    }
    WriteLine($"Endirimsiz {orderTotal}");
    orderTotal = orderTotal - orderTotal * discount / 100;
    WriteLine($"Endirimli {orderTotal}");

}
else
{
    WriteLine("Endirim 100 manati kecmemis hesaba aid edilmir");
}*/





WriteLine("Welcome to ATM");
WriteLine("Operations are below");

WriteLine("1.Take cash");
WriteLine("2.Make a transaction");
WriteLine("3.Show the account");
WriteLine("4.Exit");

int ammount = 1000;
Write("Enter the operation: ");
int operationNumber = ToInt32(ReadLine());

switch (operationNumber)
{
    case 1:
        WriteLine("Taking Cash");
        WriteLine("You can take 1-50, 2-100, 3-150 manats");
        Write("Enter the ammount you want: ");
        int takeAmmount = ToInt32(ReadLine());
        int lastAmmount = 0;
        switch (takeAmmount)
        {
            case 1:
                WriteLine("50 manats");
                int lastAccount = ammount - 50;
                WriteLine($"You have {lastAmmount} manats on your account ");
                break;
            case 2:
                WriteLine("100 manats");
                lastAccount = ammount - 100;
                WriteLine($"You have {lastAmmount} manats on your account ");
                break;
            case 3:
                WriteLine("150 manats");
                lastAccount = ammount - 150;
                WriteLine($"You have {lastAmmount} manats on your account ");
                break;
        }
        break;
    case 2:
        WriteLine("Money transaction operation");
        WriteLine("1-113 pinli hesab");
        WriteLine("2-109 pinli hesab");
        WriteLine("3-101 pinli hesab");
        WriteLine("Pul kocurulecek hesabi secin");

        int hesabNomresi = ToInt32(ReadLine());

        switch (hesabNomresi)
        {
            case 1:
                WriteLine("113e kocuruldu");
                break;
            case 2:
                WriteLine("109e kocuruldu");
                break;
            case 3:
                WriteLine("101e kocuruldu");
                break;

            default:
                WriteLine("Hesab yoxdur");
                break;
        }
        break;

    case 3:
        WriteLine($"Hesabiniz: {ammount}");
        break;
    case 4:
        WriteLine("cixish edilir...");
        break;
    default:
        WriteLine("Bele emeliyyat movcud deyil");
        break;

}












