using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class PendapatanDasarTambahanKaryawan : KomisiKaryawan
    {
        private decimal gajiPokok;

        public PendapatanDasarTambahanKaryawan(string namaDepan, string namaBelakang, string nomorKtp, decimal penjualanKotor, decimal tarifKomisi, decimal gajiPokok) : base(namaDepan, namaBelakang, nomorKtp, penjualanKotor, tarifKomisi)
        {
            this.gajiPokok = gajiPokok;
        }

        public decimal GajiPokok
        {
            get
            {
                return gajiPokok;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(GajiPokok)} must be >= 0");
                }

                gajiPokok = value;
            }
        }

        public override decimal Pendapatan() => GajiPokok + base.Pendapatan();

        public override string ToString() =>
            $"gaji-pokok { base.ToString() }\n gaji-pokok total: { GajiPokok:C}";
    }
}
