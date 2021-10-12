using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class KomisiKaryawan
    {
        public string NamaDepan { get; }
        public string NamaBelakang { get; }
        public string NomorKtp { get; }
        private decimal penjualanKotor;
        private decimal tarifKomisi;

        public KomisiKaryawan(string namaDepan, string namaBelakang, string nomorKtp, decimal penjualanKotor, decimal tarifKomisi)
        {
            this.NamaDepan = NamaDepan;
            this.NamaBelakang = NamaBelakang;
            this.NomorKtp = nomorKtp;
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

        public virtual decimal Pendapatan() => TarifKomisi * PenjualanKotor;

        public override string ToString() =>
            $"komisi karyawan : {NamaDepan} {NamaBelakang}\n" +
            $"nomor ktp: {NomorKtp}\n" +
            $"Penjualan kotor: {PenjualanKotor:C}\n" +
            $"Tarif komisi: {TarifKomisi:F2}";
    }
}
