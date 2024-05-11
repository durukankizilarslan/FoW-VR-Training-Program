namespace FoW_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------
            //Problem 2
            //-----------------------------------------------
            //1 sayı alın. Girilen sayı 50 ile 100 arasındaysa ekrana o sayı kadar merhaba yazdırsın.
            //50'den küçük veya 100'den büyükse ekrana o sayının 6 ile bölümünden kalanı yazdırsın.

            //Console.WriteLine("Bir sayı girin: ");

            //double sayiGirdi = System.Convert.ToDouble(Console.ReadLine());

            ////50 - 100 arası değerlerin çıktısı
            //if (sayiGirdi > 50 && sayiGirdi < 100)
            //{
            //    //Sayı girdisinin 0'a eşit oluncaya kadar "Merhaba" yazdırılması
            //    for (int i = 0; i < sayiGirdi; i++)
            //    {
            //        Console.WriteLine((i+1) + ".Merhaba");
            //    }
            //}
            ////Girdi 50'den küçük veya 100'den büyük ise
            //else if(sayiGirdi < 50 || sayiGirdi > 100)
            //{
            //    Console.WriteLine(sayiGirdi % 6);

            //}


            //-----------------------------------------------
            //Problem 3
            //-----------------------------------------------
            //Kullanici 5 sayi isteyecek, toplam bu diye yazdiracak

            double toplam = 0;

            for (int i = 0; i < 5; i++)
            {
                
                Console.WriteLine((i + 1) + ". Sayıyı Girin");
                double numInput = System.Convert.ToDouble(Console.ReadLine());
                toplam += numInput;

            }

            Console.WriteLine("Sayilarınızın toplamı: " + toplam);


            Console.Read();
        }
    }
}
