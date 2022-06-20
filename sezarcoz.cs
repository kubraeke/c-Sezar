using System;
using System.Collections.Generic;
using System.Linq;

namespace sezarcoz
{
    class Program
    {
        static void Main(string[] args)
        {
            int ofset = 0;
            int sayac = 0;
            char[] alfabe = new char[] { 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'i', 'ı', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };
            List<char> liste = new List<char>();
            Console.WriteLine("Mesaj Giriniz :");
            string mesaj = Console.ReadLine();
            Console.WriteLine("-------------------------------");
            string metin = "";
            while (ofset <= alfabe.Length)
            {
                for (int i = 0; i < mesaj.Length; i++)
                {
                    if (alfabe.Contains(mesaj[i]))
                    {
                        int index = Array.IndexOf(alfabe, mesaj[i]);
                        int bak = index - ofset;
                        if (bak < 0)
                        {
                            int topla = alfabe.Length + index;
                            int uzunluk = topla - ofset;
                            int mod = uzunluk % 29;
                            liste.Add(alfabe[mod]);

                        }
                        else
                        {
                            int uzunluk = index - ofset;
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
