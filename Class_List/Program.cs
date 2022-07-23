using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_List
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bool KisiEkle = true;
            Dictionary<int, Kisiler> sinif = new Dictionary<int, Kisiler>();
            int count = 0;

            while (KisiEkle)
            {
                Console.WriteLine("Sınıfa yeni bir kişi eklemek istiyor musunuz? Evet için 'E', Hayır için 'H' yazınız.");
                string ekle = Console.ReadLine();

                if (ekle == "E")
                {
                    Kisiler kisi1 = Kisiler.YeniKisi();
                    sinif.Add(count, kisi1);
                    count++;
                    
                }

                else if (ekle == "H")
                {
                    Console.WriteLine("Kisi ekleme tamamlandı. Program kapatılıyor");
                    KisiEkle = false;
                }

                else
                {
                    Console.WriteLine("Yanlış giriş yaptınız.");
                    
                }
                
                foreach (var key in sinif.Keys)
                Console.WriteLine(key + " - "+ sinif[key]);
            }
        }
    }
}
