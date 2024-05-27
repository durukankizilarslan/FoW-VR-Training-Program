namespace _5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Ucgen ucgenim = new Ucgen(10, 5, 3);
            //int sayi = ucgenim.CevreHesapla();
            //Console.WriteLine(sayi);
            //Console.WriteLine(ucgenim.CevreHesapla());
            //Console.Read();
        }
    }

    //class Ucgen
    //{
    //    // Global variables
    //    public int kenar1;
    //    public int kenar2;
    //    public int kenar3;

    //    // Constructor
    //    public Ucgen(int k1, int k2, int k3)
    //    {
    //        kenar1 = k1;
    //        kenar2 = k2;
    //        kenar3 = k3;
                
    //    }

    //    public int CevreHesapla()
    //    {
    //        return kenar1 + kenar2 + kenar3;
    //    }

        

    //    public static void EskenarKontrol(int kenar1, int kenar2, int kenar3)
    //    {


    //        if (kenar1 == kenar2 && kenar2== kenar3)
    //        {
    //            Console.WriteLine("Eşkenar Üçgendir");
    //        }
    //    }
    //    public static void IkizkenarKontrol(int side1, int side2, int side3)
    //    {
    //        if ((side1 == side2 && side1 != side3) ||
    //           (side1 == side3 && side1 != side2) ||
    //           (side2 == side3 && side2 != side1))
    //        {
    //            Console.WriteLine("İkizkenardır...");
    //        }
    //    }

    //    public static void YaziYaz()
    //    {
    //        string asd = Console.ReadLine();
    //        Console.WriteLine(asd);
    //    }
    //}

    //======================
    //PROBLEM 2
    //======================

    //University class i olusturun. Ve class a ait bir yapici metod olusturun.
    //Isim yaz, yil yaz ve sehir yaz fonk. Olsun.
    //Mainde bir liste olsuturun. University classina ait bir liste olsun.
    //1 - Uni ekle(isim sehir yil ayri olacak
    //2 - Uni sil/ 3 -UniListele/4-UniAra/5-Cikis

    class University
    {
        public string isim;
        public int yil;
        public string sehir;

        public University(string isim, int yil, string sehir)
        {
            this.isim = isim;
            this.yil = yil;
            this.sehir = sehir;
        }
    }
}
