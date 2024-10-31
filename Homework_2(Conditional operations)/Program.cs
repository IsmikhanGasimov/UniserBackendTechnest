// See https://aka.ms/new-console-template for more information
using static System.Console;
using static System.Convert;



WriteLine("Xosh gelmisiniz");
WriteLine("Menu");

WriteLine("1 - Isti yemekler");
WriteLine("2 - Qazan yemekleri");
WriteLine("3 - Ickiler");
WriteLine("4 - Desertler");

Write("Secim edin: ");
int orderNumber = ToInt32(ReadLine());

if (orderNumber >= 0 && orderNumber <= 4)
{
    switch (orderNumber)
    {
        case 1:
            WriteLine("1 - Dolma");
            WriteLine("2 - Ev sayagi kartof");
            WriteLine("3 - Shaurma");
            WriteLine("4 - Merci shorbasi");
            Write("Secim edin: ");
            orderNumber = ToInt32(ReadLine());
            switch (orderNumber)
            {
                case 1:
                    WriteLine("Dolma sifarish edildi");
                    break;
                case 2:
                    WriteLine("Ev sayagi kartof sifarish edildi");
                    break;
                case 3:
                    WriteLine("Shaurma sifarish edildi");
                    break;
                case 4:
                    WriteLine("Merci shorbasi sifarish edildi");
                    break;
                default:
                    WriteLine("Sifaris nomresi duzgun secilmeyib");
                    break;
            }
            break;

        case 2:
            WriteLine("1 - Buglama");
            WriteLine("2 - Qaymaqli can eti");
            WriteLine("3 - Cigirtma");
            WriteLine("4 - Coban qovurma");
            Write("Secim edin: ");
            orderNumber = ToInt32(ReadLine());
            switch (orderNumber)
            {
                case 1:
                    WriteLine("Buglama sifarish edildi");
                    break;
                case 2:
                    WriteLine("Qaymaqli can eti kartof sifarish edildi");
                    break;
                case 3:
                    WriteLine("Cigirtma sifarish edildi");
                    break;
                case 4:
                    WriteLine("Coban qovurma shorbasi sifarish edildi");
                    break;
                default:
                    WriteLine("Sifaris nomresi duzgun secilmeyib");
                    break;
            }
            break;

        case 3:
            WriteLine("1 - Ayran");
            WriteLine("2 - Kola");
            WriteLine("3 - Sprite");
            WriteLine("4 - Fanta");
            Write("Secim edin: ");
            orderNumber = ToInt32(ReadLine());
            switch (orderNumber)
            {
                case 1:
                    WriteLine("Ayran sifarish edildi");
                    break;
                case 2:
                    WriteLine("Kola sifarish edildi");
                    break;
                case 3:
                    WriteLine("Sprite sifarish edildi");
                    break;
                case 4:
                    WriteLine("Fanta sifarish edildi");
                    break;
                default:
                    WriteLine("Sifaris nomresi duzgun secilmeyib");
                    break;
            }
            break;

        case 4:
            WriteLine("1 - Tiramisu");
            WriteLine("2 - Kruasan");
            WriteLine("3 - Tort");
            WriteLine("4 - San sebastyan");
            Write("Secim edin: ");
            orderNumber = ToInt32(ReadLine());
            switch (orderNumber)
            {
                case 1:
                    WriteLine("Tiramisu sifarish edildi");
                    break;

                case 2:
                    WriteLine("Kruasan sifarish edildi");
                    break;
                case 3:
                    WriteLine("Tort sifarish edildi");
                    break;
                case 4:
                    WriteLine("San sebastyan sifarish edildi");
                    break;
                default:
                    WriteLine("Sifaris nomresi duzgun secilmeyib");
                    break;
            }
            break;
    }
}
else
{
    WriteLine("Sifaris nomresi duzgun secilmeyib");
}