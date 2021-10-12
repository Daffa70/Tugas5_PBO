using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var karyawan = new PendapatanDasarTambahanKaryawan("Bob", "Lewis", "333-33-3333", 5000.00M, .04M, 300.00M);

            Console.WriteLine("Informasi karyawan diperoleh dari mengambil properti dan metode: \n");
            Console.WriteLine($"Nama depan adalah {karyawan.NamaDepan}");
            Console.WriteLine($"Nama belakang adalah {karyawan.NamaBelakang }");
            Console.WriteLine($"Nomor KTP {karyawan.NomorKtp }");
            Console.WriteLine($"Penjualan kotor {karyawan.PenjualanKotor:C}");
            Console.WriteLine($"Tarif komisi {karyawan.TarifKomisi:F2}");
            Console.WriteLine($"Pendapatan {karyawan.Pendapatan():C}");
            karyawan.GajiPokok = 1000.00M;
            Console.WriteLine("\nUpdate informasi karyawan yang didapatkan dari mengubah ToString:\n");
            Console.WriteLine(karyawan);
            Console.WriteLine($"Pendapatan: { karyawan.Pendapatan():C}");

            Console.ReadLine();
        }
    }
}
