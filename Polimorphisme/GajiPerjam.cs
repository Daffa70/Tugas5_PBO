using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphisme
{
    public class GajiPerjam : Karyawan
    {
        private decimal gaji;
        private decimal jam;

        public GajiPerjam(string NamaDepan, string NamaBelakang, string NomorKtp, decimal gajiPerjam, decimal jumlahJam):base(NamaDepan, NamaBelakang, NomorKtp)
        {
            gaji = gajiPerjam;
            jam = jumlahJam;
        }

        public decimal Gaji
        {
            get
            {
                return gaji;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Gaji)} harus >= 0");
                }

                gaji = value;
            }
        }

        public decimal Jam
        {
            get
            {
                return jam;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Jam)} harus >= 0");
                }

                jam = value;
            }
        }

        public override decimal Pendapatan()
        {
            if(Jam <= 40)
            {
                return Gaji * Jam;
            }
            else
            {
                return (40 * Gaji) + ((Jam - 40) * Gaji * 1.5M);
            }
        }

        public override string ToString() => $"Gaji karyawan : {base.ToString()}\n" + $"Gaji perjam : {Gaji:C}\njam kerja: {Jam:F2}";

    }
}
