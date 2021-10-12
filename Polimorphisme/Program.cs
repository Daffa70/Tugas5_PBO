using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphisme
{
    class Program
    {
        private void A()
        {
            var karyawan = new KomisiKaryawan("Sue", "Jones", "222-22-2222", 10000.00M, .06M);
            var pendapatanDasar = new PendapatanDasarTambahanKaryawan("Bob", "Lewis", "333-33-3333", 5000.00M, .04M, 300.00M);

            Console.WriteLine("Memanggil KomisiKaryawan ToString dan methods pembayaran " + "dengan class base object\n");
            Console.WriteLine(karyawan.ToString());
            Console.WriteLine($"pendapatan: {karyawan.Pendapatan() }\n");
            Console.WriteLine("Memanggil PendapatanDasarTambahanKaryawan ToString dan methods pembayaran " + " dan juga method pendapatan reference ke base object class");
            Console.WriteLine(pendapatanDasar.ToString());
            Console.WriteLine($"earnings: { pendapatanDasar.Pendapatan() }\n");
            Console.WriteLine("Memanggil PendapatanDasarTambahanKaryawan ToString dan methods pembayaran " + " dan juga method pendapatan reference ke base object class");
            Console.WriteLine(pendapatanDasar.ToString());
            Console.WriteLine($"earnings: { pendapatanDasar.Pendapatan() }\n");
        }
    }
}
