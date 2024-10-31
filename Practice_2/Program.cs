// See https://aka.ms/new-console-template for more information


using System.Xml;
using System.Xml.Serialization;

int[] hesablarim = { 1200, 1300, 2400, 5000 };
start:
Console.WriteLine("Bankomata xosh geldiniz");
Console.WriteLine("Emeliyyatlar: ");
Console.WriteLine("1.Hesablar haqqinda melumat");
Console.WriteLine("2.Pul kocurme");
Console.WriteLine("3.Cixish etmek");

Console.WriteLine("Etmek istediyiniz emeliyyati daxil edin");
Console.Write("Emeliyyat: ");
int emeliyyatNomresi = Convert.ToInt32(Console.ReadLine());

switch (emeliyyatNomresi)
{
    case 1:
        foreach(var Hesab in hesablarim)
        {
            Console.WriteLine($"{Array.IndexOf(hesablarim,Hesab) + 1}.No hesabda {hesablarim[Array.IndexOf(hesablarim, Hesab)]}-mebleg movcuddur ");
        }

        Console.WriteLine("Davam etmek isteyirsiniz?");
        Console.Write("Cavabi daxil edin");
        string cavab = Console.ReadLine().ToLower();
        if (cavab == "he")
        {
            goto start;
        }
        else if (cavab == "yox")
        {
            goto end;
        }
        else
        {
            Console.WriteLine("Duzgun cavab verin");

        }
        break;

    case 2:
        Console.WriteLine("Pul kocurme emeliyyati");
        Console.WriteLine("Zehmet olmasa pul kocurulecek hesabin nomresini daxil edin");
        Console.Write("Pul kocurulecek hesab: ");
        int kocurulecekHesabNomresi = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Pul cixarilacaq hesabin nomresini daxil edin");
        Console.Write("Pul cixarilacaq hesab: ");
        int cixarilacaqHesabNomresi = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Mebleghi daxil edin");
        Console.Write("Kocurulecek meblegh: ");
        int meblegh = Convert.ToInt32(Console.ReadLine());

        if (hesablarim[cixarilacaqHesabNomresi-1] < meblegh)
        {
            Console.WriteLine("Hesabda yeteri geder meblegh yoxdur");
        }
        else
        {
            Console.WriteLine($"Siz {cixarilacaqHesabNomresi}.No hesabdan {meblegh} qeder meblegi" +  $"{kocurulecekHesabNomresi}.No hesaba kocurme emeliyyati edirsiniz");
            Console.WriteLine($"{cixarilacaqHesabNomresi}.No hesabda balans: {(hesablarim[cixarilacaqHesabNomresi - 1]) - meblegh}" + $"{kocurulecekHesabNomresi}.No hesabda balans: {(hesablarim[kocurulecekHesabNomresi-1])+meblegh}");

        }
        break;

    case 3:
        end:
        Console.WriteLine("Chixish edilir");
        break;

    default:
        Console.WriteLine("Bele bir emeliyyat yoxdur");
        break;


}