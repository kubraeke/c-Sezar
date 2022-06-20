using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace bilisimguvenligi
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alfabe  = new char[] { 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'i', 'ı', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };
            List<char> liste = new List<char>();
            Console.WriteLine("Mesaj Giriniz :");
            string mesaj = Console.ReadLine();
            string metin = "";
            Console.WriteLine("Key Giriniz :");
            int key = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i < mesaj.Length; i++)
            {
                if (alfabe.Contains(mesaj[i]))
                {
                    int index = Array.IndexOf(alfabe, mesaj[i]) + key;
                    int mod = index % 29;
                    liste.Add(alfabe[mod]);

                }
                else
                {
                    liste.Add(' ');

                }
            }
            for(int i = 0; i < liste.Count; i++)
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
            Console.WriteLine(metin);
        }
    }
}
