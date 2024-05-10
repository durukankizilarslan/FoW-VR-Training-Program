using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fow1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Header Başlangıcı
            Console.Write("========================= \n");
            Console.Write("FoW Projesine Hoş Geldiniz!\n");
            Console.Write("========================= \n");
            Console.WriteLine("");
            //Header Sonu

            //Öğrenci İçeriği
            Console.WriteLine("Öğrenci: Durukan Kızılarslan");
            Console.WriteLine("Tarih: 06.05.2024\n");

            //Console.ReadLine();//Programın çalıştırılmasına devam etmek için komut bekliyor
            //Console.WriteLine("Cümle 333");

            //Data Types
            //int sayi1 = 0;
            //int sayi12 = 5;
            //double sayi2 = 2;
            //string yazil = "Merhaba";
            //float virgullu = 1.5f;
            //char karakter = '+';

            //Console.WriteLine(sayi1);


            ////Integer Number Operations
            //int num1 = 10;
            //int num2 = 3;
            //int toplam = num1+ num2;
            //int bolum = num1 / num2;
            //int carpim = num1 * num2;
            //int fark = num1 - num2;
            //Console.WriteLine("toplam: " + toplam);
            //Console.WriteLine("bolum: " + bolum);
            //Console.WriteLine("carpim: " + carpim);
            //Console.WriteLine("fark: " + fark);

            //string asd = "asd +";
            //string yazi = "Merhaba";

            //Console.WriteLine(asd + yazi);

            //|| -- or
            //&& -- and
            //< , >, <=, >=
            //%=

            //Console.Write("Bir cümle gir: ");
            //string yazi2 = Console.ReadLine();


            ////-------------------------
            ////PRATIK 1
            ////------------------------

            ////Take number 1
            //Console.Write("Bir sayi girin: ");
            //double numInput1 = System.Convert.ToInt32(Console.ReadLine());

            ////Take number 2
            //Console.Write("Ikinci bir sayi girin: ");
            //double numInput2 = System.Convert.ToInt32(Console.ReadLine());

            ////Take sum
            //double sumInputs = numInput1 + numInput2;

            ////Print sum
            //Console.WriteLine("Sayılarınızın toplamı: " + (sumInputs));
            //Console.WriteLine("Sayılarınızın farkı: " + (numInput1 - numInput2));
            //Console.WriteLine("Sayılarınızın çarpımı: " + (numInput1 * numInput2));
            //Console.WriteLine("Sayılarınızın bölümü: " + (numInput1 / numInput2));


            ////--------------------------------------------------------------------

            //iki sayi al
            //iki sayinin toplami 10 dan buyukse toplam 10 dan kucuktur yazdir
            //iki sayinin toplami 10 dan kucukse toplam 10 dan buyuktur yazdir

            ////-------------------------
            ////PRATIK 2
            ////------------------------

            //2 sayi girdisi al

            ////Take number 1
            //Console.Write("Bir sayi girin: ");
            //double numInput1 = System.Convert.ToInt32(Console.ReadLine());

            //////Take number 2
            //Console.Write("Ikinci bir sayi girin: ");
            //double numInput2 = System.Convert.ToInt32(Console.ReadLine());

            ////Take sum
            //double sumInputs = numInput1 + numInput2;

            ////Print output
            //if (sumInputs > 10)
            //{
            //    Console.WriteLine("toplam 10'dan küçüktür");
            //}
            //else if (sumInputs < 10) {
            //    Console.WriteLine("toplam 10'dan büyüktür");
            //}
            //else
            //{
            //    Console.WriteLine("toplam 10'a eşittir");
            //}





            //--------------------------------------
            //PRATIK 3
            //-------------------------------------

            //1 den 5 e kadar girdiginiz sayi su, geri kalan diger sayialr 5 den buyuktur yazacak

            //Take number
            //Console.Write("Bir sayi girin: ");
            //double num1 = System.Convert.ToInt32(Console.ReadLine());

            //Print output
            //if (num1 <= 5) {
            //Console.WriteLine("Girdiğiniz sayı: " +  num1);
            //} else
            //{
            //    Console.WriteLine("Girdiginiz sayi 5'ten büyüktür.");
            //}




            //--------------------------------------
            //PRATIK 4
            // Aldi[iniz sayi 3 e bolunebiliyorsa 3 e bolunebilen bir sayidir diyoruz,
            // 3'e bolunemiyorsa 2 ye bolunup bolunmedigini kontrol ediyoruz,
            // Bolunebiliyorsa 2 ye bolunebiliyor, degilse bolunemiyor diyoruz.
            
            //-------------------------------------

            //Take number
            Console.Write("Bir sayi girin: ");
            double num1 = System.Convert.ToInt32(Console.ReadLine());

            //Print output
            if (num1 % 3 == 0 && num1 % 2 == 0)
            {
                Console.WriteLine("Girdiğiniz sayı 3'e ve 2'ye bölünebilen bir sayıdır");
            } else if (num1 % 3 == 0)
            {
                Console.WriteLine("Girdiğiniz sayı 3'e bölünebilen bir sayıdır");
            } else if (num1 % 2 == 0)
            {
                Console.WriteLine("Girdiğiniz sayı 2'ye bölünebilen bir sayıdır");
            } else
            {
                Console.WriteLine("Girdiğiniz sayı 2'ye veya 3'e bölünemiyor"); 

            }

            Console.Read();//Console'a Yazdır [Her zaman alt satırda kalsın]
        }
    }
}

//Surekli sayi istesin, x e bastiginizda cikis yapacak
