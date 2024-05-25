using System.Linq.Expressions;

namespace FoW_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //================
            //PROBLEM 1
            //================


            //// Liste ve döngü değişkeni olşturma
            //List<string> girdiler = new List<string>();
            //bool dongu = true;

            //Console.WriteLine("===================\n   Hoşgeldiniz!\n===================\nListeniz oluşturulmuştur.\nLütfen listenize eklemek istediğiniz elemanı yazınız: ");

            //while (dongu) // Girdi kabul edilen döngü
            //{
            //    string girdi = Console.ReadLine(); // Girdi kabulü ve listeye ekleme
            //    Console.WriteLine("Eklediğiniz eleman: " + girdi);

            //    if (girdi.ToLower() == "bitti") // Girdinin "bitti" olup olmadığını kontrol etme
            //    {
            //        dongu = false; // Döngüyü bitir
            //        Console.WriteLine("Döngüyü bitirdiniz. İşte listeniz: ");

            //        foreach (var item in girdiler) // Listeyi yazdır
            //        {
            //            Console.Write(item + " - ");
            //        }
            //    } else
            //    {
            //        girdiler.Add(girdi); // Girdiyi ekle
            //        Console.WriteLine("Yeni eleman ekleyin. Eklemek istemiyorsanız 'bitti' yazın ve Enter'a basarak döngüden çıkın");
            //    }


            //}

            //================
            //PROBLEM 2
            //================

            //List<string> kitaplik = new List<string>();
            ////1-Ekleme
            ////2-Silme
            ////3-Listeleme
            ////4-Çıkış
            ////switch-case

            //bool dongu = true;

            //while (dongu)
            //{
            //    Console.WriteLine("Hoşgeldiniz! Listeniz oluşturulmuştur. Listenizle alakalı yapmak istediğiniz işlemi seçiniz:\n1-Ekleme | 2-Silme | 3-Listeleme | 4-Arama | 5-Çıkış");
            //    int istek = Convert.ToInt32(Console.ReadLine());

            //    switch(istek) 
            //    {
            //        case 1:
            //            Console.WriteLine("Eklemek istediginiz degeri girin:");
            //            string eklenen = Console.ReadLine();
            //            kitaplik.Add(eklenen);
            //            Console.WriteLine("Ekeldiğiniz değer: " + eklenen + "\n");
            //            break;

            //        case 2:

            //            if (kitaplik.Count == 0)
            //            {
            //                Console.WriteLine("Kitaplıkta silinecek bir şey yok");
            //                break;
            //            }

            //            Console.WriteLine("Silmek istediginiz degerin listedeki numarasını girin:");
            //            int silinen = Convert.ToInt32(Console.ReadLine());
            //            kitaplik.RemoveAt(silinen - 1);
            //            Console.WriteLine("\n");
            //            break;

            //        case 3:
            //            Console.WriteLine("Listenizin çıktısı: ");
            //            foreach (var item in kitaplik)
            //            {
            //                Console.Write(item + " - ");
            //            }
            //            Console.WriteLine("\n");
            //            break;

            //        case 4:
            //            Console.WriteLine("Aradığınız kitabın ismini girin: ");
            //            string aranan = Console.ReadLine();

            //            break;

            //        case 5:
            //            Console.WriteLine("Uygulamadan çıkıyoruz:");
            //            dongu = false;
            //            break;
            //    }                

            //}




            



        }
    }
}
