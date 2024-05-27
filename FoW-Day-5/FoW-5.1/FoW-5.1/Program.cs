using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace FoW_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //=================================
            //PROBLEM 1
            //=================================

            //Ne yapmak istersin diye sorulacak...
            //1 - 4 islem yapan hesap makinesi olacak, "Hesaplamadan cik" secenegi olacak
            // Listeye ekleme icin, silme icin, arama icin, listeleme icin ve  cikis icin birer fonksiyon yazilacak
            //Kapat secenegi olacak

            bool donguGenel = true;


            // PROGRAM DONGUSU
            while (donguGenel) {
                
                Console.WriteLine("Uygulamaya hoşgeldiniz. Aşağıdaki seçeneklerin rakamını tuşlayarak yapmak istediğiniz işlemi seçin:\n1 - Hesap Makinesi | 2 - Liste programı | 3 - Çıkış");
                int programSecim = Convert.ToInt32(Console.ReadLine());

                switch (programSecim)
                {
                    case 1:
                    HesapMakinesi();
                    break;


                    case 2:
                    ListeProgrami();
                    break;

                    case 3:
                    donguGenel = false;
                    break;
                }
            }



            Console.ReadLine();
            
        }

        //FUNCTION DECLERATIONS


        private static void HesapMakinesi()
        {
            bool hesapDongu = true;

            while (hesapDongu) 
            {
                Console.WriteLine("İşlemciye hoşgeldiniz. 2 sayı giriniz:");
                Console.Write("Sayi bir: ");
                double sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Sayi iki: ");
                double sayi2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Yapmak istediğiniz işlemi seçin: \n1 - Toplama | 2 - Çıkarma | 3 - Çarpma | 4 - Bölme");
                double secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        Topla(sayi1, sayi2);
                        break;

                    case 2:
                        Cikar(sayi1, sayi2);
                        break;

                    case 3:
                        Carp(sayi1, sayi2);
                        break;

                    case 4:
                        Bol(sayi1, sayi2);
                        break;
                }

                Console.WriteLine("Hesap makinesini kullanmaya devam etmek istiyor musunuz?\n1 - Devam Et | 2 - Çıkış");
                int hesapDevam = Convert.ToInt32(Console.ReadLine());

                if (hesapDevam == 1)
                {
                }
                else if (hesapDevam == 2) 
                { 
                    hesapDongu = false; 
                }
            }
            
        }

        private static void Topla(double a, double b)
        {
            Console.Write("Sayi bir: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sayi iki: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            string sonuc = Convert.ToString(sayi1 + sayi2);
            Console.WriteLine("Toplamin sonucu: " + sonuc);
        }

        private static void Cikar(double a, double b)
        {

            double sonuc = a - b;
            Console.WriteLine("Sayinin farki: " + sonuc);
        }

        private static void Carp(double a, double b)
        {

            double sonuc = a * b;
            Console.WriteLine("Sayinin carpimi: " + sonuc);
        }

        private static void Bol(double a, double b)
        {

            double sonuc = a / b;
            Console.WriteLine("Sayinin bolumu: " + sonuc);
        }

        private static void ListeProgrami()
        {
            List<string> kitaplik = new List<string>();
            bool dongu = true;

            while (dongu)
            {
                Console.WriteLine("Hoşgeldiniz! Listeniz oluşturulmuştur. Listenizle alakalı yapmak istediğiniz işlemi seçiniz:\n1-Ekleme | 2-Silme | 3-Listeleme | 4-Arama | 5-Çıkış");
                int istek = Convert.ToInt32(Console.ReadLine());

                switch(istek) 
                {
                    case 1:
                        Console.WriteLine("Eklemek istediginiz degeri girin:");
                        string eklenen = Console.ReadLine();
                        kitaplik.Add(eklenen);
                        Console.WriteLine("Ekeldiğiniz değer: " + eklenen + "\n");
                        break;

                    case 2:

                        if (kitaplik.Count == 0)
                        {
                            Console.WriteLine("Kitaplıkta silinecek bir şey yok");
                            break;
                        }


                        Console.WriteLine("Silmek istediginiz degerin listedeki numarasını girin:");
                        int silinen = Convert.ToInt32(Console.ReadLine());
                        kitaplik.RemoveAt(silinen - 1);
                        Console.WriteLine("\n");
                        break;

                    case 3:
                        Console.WriteLine("Listenizin çıktısı: ");
                        foreach (var item in kitaplik)
                        {
                            Console.Write(item + " - ");
                        }
                        Console.WriteLine("\n");
                        break;

                    case 4:
                        Console.WriteLine("Aradığınız kitabın ismini girin: ");
                        string aranan = Console.ReadLine();

                        for (int i = 0; i < kitaplik.Count; i++)
                        {
                            if(aranan.ToLower() == kitaplik[i].ToLower())
                            {
                                Console.WriteLine("Aradiginiz kitap kitaplikta var.");
                            } else
                            {
                                Console.WriteLine("Aradiginiz kitap kitaplikta yok .");
                            }

                        }
                        break;

                    case 5:
                        Console.WriteLine("Uygulamadan çıkıyoruz:");
                        dongu = false;
                        break;
                }                

            }
        }
    }
}
