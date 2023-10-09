using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Dictionary
    {

        public static void Main(string[] args)
        {
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(10, "Sefa Yeşilarslan");
            kullanicilar.Add(6, "Ahmet Çalık");
            kullanicilar.Add(17, "Sokol Chikalleshi");
            kullanicilar.Add(18, "Ahmet Oğuz");

            Console.WriteLine("****Elemanlara Erişimm********");

            Console.WriteLine(kullanicilar[17]);

            foreach (var kullanici in kullanicilar)
            {
                Console.WriteLine(kullanici);
            }


            // COUNT
            Console.WriteLine("****Count********");
            Console.WriteLine(kullanicilar.Count);

            // Contais
            Console.WriteLine("****Contais********");
            Console.WriteLine(kullanicilar.ContainsKey(10));
            Console.WriteLine(kullanicilar.ContainsValue("Ahmet Çalık"));

            // Remove
            Console.WriteLine("****Remove********");
            kullanicilar.Remove(18);

            foreach (var kullanici in kullanicilar)
            {
                Console.WriteLine(kullanici);
            }


            // Key ve Value

            foreach (var kullanici in kullanicilar)
            {
                Console.WriteLine(kullanici.Value);
            }





        }
    }
}