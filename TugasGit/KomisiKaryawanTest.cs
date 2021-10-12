using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasGit
{
    class KomisiKaryawanTest
    {
        static void Main()
        {
            var karyawan = new KomisiKaryawan("Sue", "Jones", "222-22-2222", 10000.00M, .06M);

            Console.WriteLine("Informasi karyawan diperoleh dari mengambil properti dan metode: \n");
            Console.WriteLine($"Nama depan adalah {karyawan.namaDepan}"); 
            Console.WriteLine($"Nama belakang adalah {karyawan.namaBelakang }");
            Console.WriteLine($"Nomor KTP {karyawan.nomorKtp }");
            Console.WriteLine($"Penjualan kotor {karyawan.PenjualanKotor :C}");
            Console.WriteLine($"Tarif komisi {karyawan.TarifKomisi :F2}");
            Console.WriteLine($"Pendapatan {karyawan.Pendapatan():C}");
            Console.WriteLine("\nUpdate informasi karyawan yang didapatkan dari mengubah ToString:\n");
            Console.WriteLine(karyawan);
            Console.WriteLine($"Pendapatan: { karyawan.Pendapatan():C}");

            Console.ReadLine ();
        }
}
}
