using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //atama operatorleri:
            int a = 4;
            int x = 3;//x degiskenine 3 degerini atadık.
            x += 1;//x = x + 1 
            x *= 1;//x = x * 1
            x -= 1;//x = x - 1
            x /= 1;//x = x / 1

            //mantiksal operatorler
            bool y = true;
            bool z = false;
            Console.WriteLine(y && z);//"ve" operatoru, iki degiskenin degeri true ise true, en az biri false ise false dondurur.
            Console.WriteLine(y || z);//"veya" operatoru, en az bir degiskenin degeri true ise true dondurur.
            Console.WriteLine(!y);//onune getirilen degiskenin degilini alır.Degisken true ise false, false ise true dondurur.
            Console.ReadLine();

            //iliskisel operatorler

            Console.WriteLine(y != z);//"degil" operatoru, degiskenlerin degerleri birbirlerine esit degilse true dondurur.
            Console.WriteLine(y == z);//degiskenlerin degerlerini karsilastirir, ayni ise true dondurur.
            Console.WriteLine(x < a);//x'in degeri a'dan kucukse true dondurur.
            Console.WriteLine(x >= a);//x'in degeri a'dan büyük ya da esit ise true dondurur.

            






        }
    }
}
