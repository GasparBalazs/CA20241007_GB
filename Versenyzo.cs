using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA20241007_GB
{
    internal class Versenyzo
    {
        public string VersenyzoNev { get; set; }
        public int VersenyzoSzulEv { get; set; }
        public int Rajtszam { get; set; }
        public string VersenyzoNeme { get; set; }
        public string EletkorKategoria { get; set; }
        public DateTime UszasIdo { get; set; }
        public DateTime ElsoDepoIdo { get; set; }
        public DateTime KerekparIdo { get; set; }
        public DateTime MasodikDepoIdo { get; set; }
        public DateTime FutasIdo { get; set; }

        public override string ToString()
        {
            return $"{VersenyzoNev} ({VersenyzoSzulEv} éves, {VersenyzoNeme}, {EletkorKategoria}, {UszasIdo}, {ElsoDepoIdo}, {MasodikDepoIdo}, {FutasIdo})";
        }

        public Versenyzo(string sor)
        {
            var v = sor.Split(';');
            VersenyzoNev = v[0];
            VersenyzoSzulEv = int.Parse(v[1]);
            Rajtszam = int.Parse(v[2]);
            VersenyzoNeme = v[3];
            EletkorKategoria = v[4];
            UszasIdo = DateTime.ParseExact(v[5], "HH:mm:ss", CultureInfo.InvariantCulture);
            ElsoDepoIdo = DateTime.ParseExact(v[6], "HH:mm:ss", CultureInfo.InvariantCulture);
            KerekparIdo = DateTime.ParseExact(v[7], "HH:mm:ss", CultureInfo.InvariantCulture);
            MasodikDepoIdo = DateTime.ParseExact(v[8], "HH:mm:ss", CultureInfo.InvariantCulture);
            FutasIdo = DateTime.ParseExact(v[9], "HH:mm:ss", CultureInfo.InvariantCulture);
        }
    }
}
