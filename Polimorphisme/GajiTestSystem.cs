using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphisme
{
    class GajiTestSystem
    {
        static void Main()
        {
            var gajiKaryawan = new GajiKaryawan("John", "Smith", "111-11-1111", 800.00M);
            var gajiPerjam = new GajiPerjam("Karen", "Price", "222-22-2222", 16.75M, 40.0M);
            var komisiKaryawan = new KomisiKaryawan("Sue", "Jones", "333-33-3333", 10000.00M, .06M);
            var pendapatanDasar = new PendapatanDasarTambahanKaryawan("Bob", "Lewis", "444-44-4444", 5000.00M, .04M, 300.00M);

            Console.WriteLine("Karywan di proses sendiri-sendiri: \n");
            Console.WriteLine($"{gajiKaryawan}\ndiperoleh: " + $"{gajiKaryawan.Pendapatan():C}\n");
            Console.WriteLine($"{gajiPerjam}\ndiperoleh: " + $"{gajiPerjam.Pendapatan()}");
            Console.WriteLine($"{komisiKaryawan}\ndiperoleh: " + $"{komisiKaryawan.Pendapatan()}");
            Console.WriteLine($"{pendapatanDasar}\ndiperoleh: " + $"{pendapatanDasar.Pendapatan()}");

            var karyawans = new List<Karyawan> { gajiKaryawan, gajiPerjam, komisiKaryawan, pendapatanDasar };

            Console.WriteLine("Karyawan di proses secara polymorphisme");

            foreach(var karyawanSekarang in karyawans)
            {
                Console.WriteLine(karyawanSekarang);
                if (karyawanSekarang is PendapatanDasarTambahanKaryawan)
                {
                    var karyawan = (PendapatanDasarTambahanKaryawan)karyawanSekarang;
                    karyawan.GajiPokok *= 1.10M;
                    Console.WriteLine("Gaji pokok baru dengan kenaikan 10% adalah: " + $"{karyawan.GajiPokok:C}");

                }

                Console.WriteLine($"Memperoleh: {karyawanSekarang.Pendapatan():C}\n");

            }

            for (int j = 0; j < karyawans.Count; j++)
            {
                Console.WriteLine($"Karyawan {j} adalah {karyawans[j].GetType()}");
            }

            Console.ReadLine();
        }
    }
}
