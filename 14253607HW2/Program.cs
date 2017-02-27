using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253607HW2
{ 
        class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("komutları aşağıdaki tipte giriniz");
        Console.WriteLine("KOMUT 1 = FIRÇA AŞAĞI ");
        Console.WriteLine("KOMUT 2 = FIRÇA YUKARI ");
        Console.WriteLine("KOMUT 3 = SAĞA DÖN ");
        Console.WriteLine("KOMUT 4 = SOLA DÖN ");
        Console.WriteLine("KOMUT 5 = X KADAR İLERLE ");
        Console.WriteLine("KOMUT 6 = ZIPLA BULUNDUĞU KARA HARİÇ 3 ZIPLAR");
        Console.WriteLine("KOMUT 7 = GERİ DÖN ");
        Console.WriteLine("KOMUT 8 = DİZİYİ GÖRÜNTÜLE ");
        Console.WriteLine("KOMUT 0 = PROGRAMI SONLANDIR ");
        Console.WriteLine("ÖRNEK KOMUT = BOYUT+5_5+3+5_1+3+1+5_4+4+5_7+4+5_4+4+5_3+4+5_2+7+6 +8+0");


        Console.Write("Komutları giriniz :");
        string komut = Console.ReadLine();




        Islem islem = new Islem();
        islem.cizdir(komut);




    }
}
}
