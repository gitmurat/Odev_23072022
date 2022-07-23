﻿using System;
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
            Dictionary<string, Kisiler> sinif = new Dictionary<string, Kisiler>();
            int count = 0;
            string OgrenciNo = "";

            while (KisiEkle)
            {
                Console.WriteLine("Sınıfa yeni bir kişi eklemek istiyor musunuz? Evet için 'E', Hayır için 'H' yazınız.");
                string ekle = Console.ReadLine();
                OgrenciNo = "MSDS-0622-" + count.ToString();
                if (ekle == "E")
                {
                    Kisiler kisi1 = Kisiler.YeniKisi();
                    sinif.Add(OgrenciNo, kisi1);
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
                
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Sınıfta Mevcut Öğrenciler:");
                Console.WriteLine("--------------------------");

                foreach (string key in sinif.Keys)
                {
                    Console.WriteLine(key + " - " + sinif[key]);
                    Console.WriteLine();
                }
            }

            
        }
    }
}
