using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302210004
{
    internal class Penjumlahan
    {
        public void JumlahTigaAngka<T>(T angka, T num, T number)
        {
            dynamic penjumlahan = 0.0;
            penjumlahan = penjumlahan + angka;
            penjumlahan+= num;
            penjumlahan+= number;
            Console.WriteLine("Total jumlah tiga angka: " + penjumlahan);

        }
    }
}
