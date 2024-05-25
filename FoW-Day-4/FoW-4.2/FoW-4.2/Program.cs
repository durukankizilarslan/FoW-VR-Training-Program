using System;

namespace FoW_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //---------------------------
            //FONKSIYONLAR
            //---------------------------


            //====================
            //PROBLEM 1
            //Iki sayi sectir, bunlari fonksiyonlari kullanarak 4 islem yaptir
            //====================

            //Console.WriteLine("İşlemciye hoşgeldiniz. 2 sayı giriniz:");
            //Console.Write("Sayi bir: ");
            //double sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Sayi iki: ");
            //double sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Yapmak istediğiniz işlemi seçin: \n1 - Toplama | 2 - Çıkarma | 3 - Çarpma | 4 - Bölme");
            //double secim = Convert.ToInt32(Console.ReadLine());

            //switch(secim)
            //{
            //    case 1:
            //        Topla(sayi1, sayi2); 
            //        break;

            //    case 2:
            //        double sonuc = Cikar(sayi1, sayi2);
            //        Console.Write(sonuc);
            //        break;

            //    case 3:
            //        Carp(sayi1, sayi2);
            //        break;

            //    case 4:
            //        Bol(sayi1, sayi2);
            //        break;
            //}

            //Console.WriteLine("Sonuc: " +Carp(Topla(sayi1,sayi2), Cikar(sayi1, sayi2)));

            //=================
            //PROBLEM 2
            //Iki islem arasi secim yaptir Yazdirma isterse merhaba yazdir, Toplama isterse iki sayi sectirip toplat
            //=================

            Console.WriteLine(("Merhaba. Yapilacak iki işlemden bir tanesini seç:\n1 - Yazdırma | 2 - Toplama"));

            string secim = Console.ReadLine();


            switch (secim)
            {
                case "1":
                    Console.WriteLine("Merhabaaa");
                    break;

                case "2":
                    Console.WriteLine();
                    Topla();
                    break;
            }

            Console.ReadLine();
        }

        private static void Topla()
        {
            Console.Write("Sayi bir: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sayi iki: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            string sonuc = Convert.ToString(sayi1 + sayi2);
            Console.WriteLine("Toplamin sonucu: " + sonuc);
        }

        //private static double Cikar(double a, double b)
        //{

        //    double sonuc = a - b;
        //    Console.WriteLine("Sayinin farki: " + sonuc);
        //    return sonuc;
        //}

        //private static double Carp(double a, double b)
        //{

        //    double sonuc = a * b;
        //    Console.WriteLine("Sayinin carpimi: " + sonuc);
        //    return sonuc;
        //}

        //private static void Bol(double a, double b)
        //{

        //    double sonuc = a / b;
        //    Console.WriteLine("Sayinin bolumu: " + sonuc);
        //}

        //Çıkarma, çarpma, bölme işlemleri yapılacak
        //Ikı sayı isteyip işlem seçtirip fonksiyonlar üzerinden işlemi yaptır

        

    }
}
