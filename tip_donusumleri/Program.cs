using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //int to byte 
            int a = 50;
            byte b = (byte)a;

            //float to byte
            float c = 10.8F;
            byte d = (byte)c;

            //ToString()
            string e = a.ToString();
            string f = c.ToString();

            //Convert.ToInt()
            string g = "15";
            int h = Convert.ToInt32(g);

        }
    }
}
