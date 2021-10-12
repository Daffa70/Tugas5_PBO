using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphisme
{
    public class GajiKaryawan : Karyawan
    {
        private decimal gajiMingguan;

        public GajiKaryawan(string NamaDepan, string NamaBelakang, string NomorKtp, decimal gajiMingguan):base(NamaDepan, NamaBelakang, NomorKtp)
        {
            this.gajiMingguan = gajiMingguan;
        }

        public decimal GajiMingguan
        {
            get
            {
                return gajiMingguan;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(GajiMingguan)} harus >= 0");
                }

                gajiMingguan = value;
            }
        }

        public override decimal Pendapatan() => GajiMingguan;

        public override string ToString() => $"Gaji karyawan : {base.ToString()}\n" + $"Gaji mingguan : {GajiMingguan:C}";
    }   
}
