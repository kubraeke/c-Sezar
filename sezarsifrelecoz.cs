using System;
using System.Collections.Generic;
using System.Linq;

namespace sezarvesifrecoz
{
    class Program
    {
        static void Main(string[] args)
        {
            int ofset = 0;
            int sayac = 0;
            char[] alfabe = new char[] { 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'i', 'ı', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };
            List<char> liste = new List<char>();
            Console.WriteLine("Şifreli Mesaj Giriniz :");
            string mesaj = Console.ReadLine();
            Console.WriteLine("Şifre Giriniz :");
            string sifre = Console.ReadLine();
            Console.WriteLine("-------------------------------");
            string metin = "";
            while (ofset <= alfabe.Length)
            {
                for (int i = 0; i < mesaj.Length; i++)
                {
                    int sfrmod = i % sifre.Length;
                    int sifreindex = Array.IndexOf(alfabe, sifre[sfrmod]);
                    if (alfabe.Contains(mesaj[i]))
                    {
                        int index = Array.IndexOf(alfabe, mesaj[i]);
                        int bak = index - ofset - sifreindex;
                        if (bak < 0)
                        {
                            int topla = alfabe.Length + index;
                            int uzunluk = topla - ofset - sifreindex;
                            int mod = uzunluk % 29;
                            if (mod < 0)
                            {
                                int yuzunluk = 29 + mod;
                                int ymod = yuzunluk % 29;
                                liste.Add(alfabe[ymod]);
                            }
                            else
                            {
                                liste.Add(alfabe[mod]);
                            }
                            

                        }
                        else
                        {
                            int uzunluk = index - ofset - sifreindex;
                            int mod = uzunluk % 29;
                            liste.Add(alfabe[mod]);

                        }


                    }
                    else
                    {
                        liste.Add(' ');

                    }
                }
                ofset++;
            }
            for (int i = 0; i < liste.Count; i++)
            {
                if (alfabe.Contains(liste[i]))
                {
                    metin = metin + liste[i];
                }
                else
                {
                    metin = metin + " ";
                }
            }
            for (int i = 0; i < metin.Length; i += mesaj.Length)
            {
                int sayi = i + mesaj.Length;
                Console.WriteLine(sayac + ". Ofset");
                Console.WriteLine(metin[i..sayi]);
                Console.WriteLine("-------------------------------");
                sayac++;
            }
        }
    }
    
}
