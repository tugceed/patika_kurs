using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsminizi giriniz:");
            string isim = Console.ReadLine();
            Console.WriteLine("Merhaba "+isim);
            Console.ReadLine();
            int x = 152;
            double y = 15.2;
            float z = 15.4F; //float tipinde değişkenin sonuna F yazılır yoksa double olarak algılanır hata verir.
            decimal a = 10.5186789286M; //double'ın aksine virgülden sonra 28 değer alabilir. Sonuna M yazılmalı!!!
            short b = 2;
            long c = 561465165146514;
            byte d = 200;// 0-256 aralığında değer tutabilir.
            bool e = true; // or false

        }
    }
}

