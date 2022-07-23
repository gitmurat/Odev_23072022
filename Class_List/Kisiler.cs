using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_List
{
    internal class Kisiler
    {
        private int _TC { get; set; }
        public int TC
        {
            get
            {
                return _TC;
            }
        }

        private string _Isim { get; set; }
        public string Isim
        {
            get
            { return _Isim; }
        }

        private string _Soyisim { get; set; }
        public string Soyisim
        {
            get
            { return _Soyisim; }
        }

        public string OgrenciNo { get; set; }

        public Kisiler(int tc, string isim, string soyisim)
        {
            _TC = tc;
            _Isim = isim;
            _Soyisim = soyisim;
        }

        public static Kisiler YeniKisi()
        {
            Console.WriteLine("Kisinin TC'sini giriniz: ");
            string tc = Console.ReadLine();
            int TC = Convert.ToInt32(tc);
            Console.WriteLine("Kisinin İsmini giriniz: ");
            string isim = Console.ReadLine();
            Console.WriteLine("Kisinin Soyismini giriniz: ");
            string soyisim = Console.ReadLine();


            Kisiler kisi = new Kisiler(TC, isim, soyisim);
            return kisi;
        }

        public override string ToString()
        {
            return Isim + " " + Soyisim;
        }
    }
}
