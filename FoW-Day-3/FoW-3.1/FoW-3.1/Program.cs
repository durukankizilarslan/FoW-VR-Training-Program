using System;
using System.Collections;

namespace FoW_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------------------------------------------------------------------
            //Problem 3 (Diziyle Çözüm)
            //Girilen 10 sayinin en kucugunu ve en buyugunu ve toplamlarini bulan ve ekrana yazdiran kodlari yaziniz.


            //Array olustur 
            //int[] dizi;

            //10 sayi icin for loop u ile sayi girdisi iste
            //for (int i = 0; i < 10; i++)
            //{
            //    int numInput = Console.ReadLine();
            //}
            //Sayi girdisini array icerisine at


            //array icerisinden en kucugu ve en buyugu bul, ekrana yazdir

            //Sayilarin toplamlarini bul ve ekrana yazdir

            //-----------------------------------------------------------------------------



            //==============================================================================

            //Problem 3 (if ile cozum)


            //Console.Write("Bir rakam girin:");

            //Değişkenler yazımı
            //int ilk = System.Convert.ToInt32(Console.ReadLine()); //ilk sayiyi iste
            //int enBuyuk = ilk;
            //int enKucuk = ilk;
            //int toplam = ilk;

            //For loopu ile 10 tane sayi iste
            //for (int i = 0; i <9 ; i++)
            //{
            //    Console.Write((i+2) + ". Sayıyı gir:");
            //    int girilen = Convert.ToInt32(Console.ReadLine());//Girdi iste
            //    toplam += girilen;//toplami guncellestir

            //    if (girilen > enBuyuk) //en buyuk sayi ile karsilastir
            //    {
            //        enBuyuk = girilen;
            //    }

            //    if (girilen < enKucuk)//en kucuk sayi ile karsilastir
            //    {
            //        enKucuk = girilen; 
            //    }
            //}

            //Console.WriteLine("Sayilarınızın toplamı: " + toplam);
            //Console.WriteLine("En buyuk sayi: " + enBuyuk);
            //Console.WriteLine("En kucuk sayi: " + enKucuk);


            //==================================================================

            //ARRAYS

            //int[] dizi1 = new int[10];
            //int[] dizi2 = { 1, 2, 3, 4, 5 };
            //dizi1[0] = 3;
            //Console.WriteLine(dizi1[0]);

            //for (int i = 0; i < dizi2.Length; i++)
            //{
            //    Console.WriteLine((i+1) + ". Sayi: " + dizi2[i]);
            //}


            //-------------------------
            //PROBLEM 1
            //-------------------------

            //5 elemanli bir dizi olustur, Elemanlari kullanici girecek, en sonunda girilen elemanlari yazdir
            //int[] dizi3 = new int[5];

            //for (int i = 0; i < dizi3.Length; i++)
            //{
            //    Console.Write((i+1) + ". sayıyı girin: ");
            //    dizi3[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //foreach (int item in dizi3)
            //{
            //    if (item == dizi3[4])
            //    {

            //        Console.Write(item);
            //    } else
            //    {
            //        Console.Write(item + ", ");
            //    }

            //}


            //-------------------------
            //PROBLEM 2
            //-------------------------

            //Dizideki butun tek sayilari elle girip degistirin


            //int[] dizi1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            //-------------------------------------------

            //Alternatif 1
            //for (int i = 0; i < dizi1.Length; i++)
            //{
            //    if (dizi1[i] % 2 != 0)
            //    {
            //        Console.WriteLine("Dizinin " + (i + 1) + " elemani tek sayidir, yeni eleman girin:");
            //        dizi1[i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //-------------------------------------------

            //Alternatif 2
            //for (int i = 0; i < dizi1.Length; i+=2)
            //    {
            //    dizi1[i] = 5;
            //    }

            //-------------------------------------------

            //Console.WriteLine("Dizinin elemanlari: ");
            //foreach (int item in dizi1)
            //{
            //    if (item == dizi1[dizi1.Length - 1])
            //    {
            //        Console.Write(item);
            //    }
            //    else
            //    {
            //        Console.Write(item + ", ");
            //    }
            //}

            //------------------------
            //PROBLEM3
            //------------------------

            //Diziyi tersten yazdir

            //int[] dizi1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] tersDizi = new int[dizi1.Length];

            //for (int i = 0; i <dizi1.Length; i++)
            //{
            //    tersDizi[i] = dizi1[dizi1.Length - 1 - i];
            //}

            ////Dizi 1 Çıktısı
            //Console.WriteLine("Dizi 1 çıktısı: ");
            //foreach (int item in dizi1)
            //{
            //    if (item == dizi1[dizi1.Length - 1])
            //    {
            //        Console.Write(item + "\n");
            //    }
            //    else
            //    {
            //        Console.Write(item + ", ");
            //    }
            //}

            ////Ters Dizi Çıktısı
            //Console.WriteLine("Ters Dizi çıktısı: ");
            //foreach (int item in tersDizi)
            //{
            //    if (item == tersDizi[tersDizi.Length - 1])
            //    {
            //        Console.Write(item + "\n");
            //    }
            //    else
            //    {
            //        Console.Write(item + ", ");
            //    }
            //}

            //---------------------------------
            //PROBLEM 4
            //Bu çıktıyı al
            //*
            //**
            //***
            //****
            //*****
            //---------------------------------


            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < i+1; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();    
            //}


            //Dizilere eleman atama
            //int[] dizi1 = new int[5];

            //dizi1[0] = 1;
            //dizi1[1] = 2;
            //dizi1[2] = 3;
            //dizi1[3] = 4;
            //dizi1[4] = 5;


            //---------------------------------
            //PROBLEM 4
            //Bu çıktıyı al
            //Aşağıdaki diziyi küçükten büyüğe sırala
            //---------------------------------

            //int[] dizi1 = { 3, 5, 1, 45, 67, 8, 4, 2 };

            // Diziyi küçükten büyüğe sıralayacak for döngüsü
            //for (int i = 0; i < dizi1.Length - 1; i++)
            //{
            //    for (int j = 0; j < dizi1.Length - 1 -i ; j++)
            //    {
            //        if (dizi1[j] > dizi1[j + 1])
            //        {
            //            // Küçükten büyüğe rakamların yerlerini değiştir
            //            int temp = dizi1[j];
            //            dizi1[j] = dizi1[j + 1];
            //            dizi1[j + 1] = temp;
            //        }
            //    }
            //}

            //Console.WriteLine("Küçükten büyüğe sıralanmış sizi:");
            //foreach (int num in dizi1)
            //{
            //    Console.Write(num + ",");
            //}



            //-----------------------------------------------------------------------------------


            //LISTS

            //Listler array gibidir ama buyukluk belirtmek gerekmez

            List<int> list1 = new List<int>();

            //list1.Add(1);
            //list1.Add(2);
            //list1.Add(3);
            //list1.Add(4);
            //list1.Remove(3);
            //list1.RemoveAt(2);
            //list1.Contains(3);


            for (int i = 0; i < 10; i++)
            {
                Console.Write((i+1) + ". Sayıyı girin:");
                list1.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine(list1[i]);
            }


            Console.Read();
        
        }
    }
}
