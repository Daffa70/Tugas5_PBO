using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class PembayaranInterfaceTest
    {
        static void Main()
        {
            var pembayaranObject = new List<IPembayaran>() {
            new Faktur("01234", "seat", 2, 375.00M),
            new Faktur("56789", "tire", 4, 79.95M),
            new GajiKaryawan("John", "Smith", "111-11-1111", 800.00M),
            new GajiKaryawan("Lisa", "Barnes", "888-88-8888", 1200.00M)};

            Console.WriteLine("Faktur dan karyawan di proses secara Polymorphisme:\n");

            foreach(var pembayaran in pembayaranObject)
            {
                Console.WriteLine($"{pembayaran}");
                Console.WriteLine($"Jatuh tempo pembayaran: {pembayaran.GetJumlahPembayaran():C}\n");
            }

            Console.ReadLine();
        }
    }
}
