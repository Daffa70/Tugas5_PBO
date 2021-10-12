using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphisme
{
    public class KomisiKaryawan : Karyawan
    {
        public decimal penjualanKotor;
        public decimal tarifKomisi;

        public KomisiKaryawan(string NamaDepan, string NamaBelakang, string NomorKtp, decimal penjualanKotor, decimal tarifKomisi):base(NamaDepan, NamaBelakang, NomorKtp)
        {
            this.penjualanKotor = penjualanKotor;
            this.tarifKomisi = tarifKomisi;
        }

        public decimal PenjualanKotor
        {
            get
            {
                return this.penjualanKotor;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(PenjualanKotor)} harus >= 0");
                }

                penjualanKotor = value;
            }
        }

        public decimal TarifKomisi
        {
            get
            {
                return tarifKomisi;
            }
            set
            {
                if (value <= 0 || value >= 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(TarifKomisi)} harus > 0 dan < 1");

                }

                tarifKomisi = value;
            }
        }

        public override decimal Pendapatan() => tarifKomisi * penjualanKotor;

        public override string ToString() =>
            $"commission employee: {base.ToString()}\n" +
            $"gross sales: {PenjualanKotor:C}\n" +
            $"commission rate: {TarifKomisi:F2}";

    }
}
