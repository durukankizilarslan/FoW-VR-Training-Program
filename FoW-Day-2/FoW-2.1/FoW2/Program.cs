using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FoW2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //-----------------------------------------------------------------
            //PRATIK 2
            //If yapisi kullanarak hesap makinesi yap, 2 sayi iste islem iste
            //1-Toplama, 2-Cikarma vs
            //-----------------------------------------------------------------

            //BAŞLIK
            Console.WriteLine("================================");
            Console.WriteLine("HESAP MAKİNESİNE HOŞ GELDİNİZ");
            Console.WriteLine("================================ \n");

            //1. sayi girisi
            Console.WriteLine("Hoşgeldiniz! Bu bir hesap makinesidir. Lütfen 2 adet sayı giriniz.\n");
            
            //Sayi giris dongusu
            while (true)
            {
                Console.Write("Birinci sayiyi girin: ");
                double num1 = System.Convert.ToDouble(Console.ReadLine());

                //2. sayi girisi
                Console.Write("Ikinci sayiyi girin: ");
                double num2 = System.Convert.ToDouble(Console.ReadLine());

                //İşlem seçimi
                Console.WriteLine("Yapmak istediğiniz işlemi seçin. İstediğiniz işlem için ilgili numaraya basın ve Enter'ı tuşlayın:");
                Console.WriteLine("+ : Toplama \n- : Çıkarma \n* : Çarpma \n/ : Bölme \n");

                char islemIstegi = System.Convert.ToChar(Console.ReadLine());
                Console.WriteLine("");

                //İşlem Uygulanması
                switch(islemIstegi)
                {
                        case '+': 
                        Console.WriteLine("Sayıların toplamı: " + (num1 + num2) + "\n");
                        break;

                        case '-':
                        Console.WriteLine("Sayıların farkı: " + (num1 - num2) + "\n");
                        break;

                        case '*':
                        Console.WriteLine("Sayıların çarpımı: " + (num1 * num2) + "\n");
                        break;

                        case '/':
                        Console.WriteLine("Sayıların bölümü: " + (num1 / num2) + "\n");
                        break;

                        //else durumu için default case kullan
                        default:  Console.WriteLine("Geçersiz bir işlem karakteri seçtiniz");
                        break;
                        
                }

                //if (islemIstegi == 1)
                //{
                //    Console.WriteLine("Sayıların toplamı: " + (num1 + num2) + "\n");
                //}
                //else if (islemIstegi == 2)
                //{
                //    Console.WriteLine("Sayıların farkı: " + (num1 - num2) + "\n");
                //}
                //else if (islemIstegi == 3)
                //{
                //    Console.WriteLine("Sayıların çarpımı: " + (num1 * num2) + "\n");
                //}
                //else if (islemIstegi == 4)
                //{
                //    Console.WriteLine("Sayıların bölümü: " + (num1 / num2) + "\n");
                //}




                //İşlem Çıkış İsteği
                Console.WriteLine("Uygulamadan çıkmak istiyor musunuz? \nÇıkmak İçin 'X' , Devam etmek için 'Y' tuşuna basınız:\n *Başka bir tuşa basmanız halinde işlemlere devam edilecektir \n \n İşlem isteğiniz (X/Y): ");
                string bitisIstek = Console.ReadLine();

                if (bitisIstek.ToLower() == "x") 
                {
                    break;
                } else if (bitisIstek.ToLower() == "y") {
                    Console.WriteLine("Hesaplara devam ediyoruz!");
                } else
                {
                    Console.WriteLine("Geçersiz girdi seçtiniz, işlemlere devam ediyoruz.");
                }
            }

            //-----------------------------------------------
            //Problem 2
            //-----------------------------------------------
            //1 sayı alın. Girilen sayı 50 ile 100 arasındaysa ekrana o sayı kadar merhaba yazdırsın.
            ////50'den küçük veya 100'den büyükse ekrana o sayının 6 ile bölümünden kalanı yazdırsın.

            

            Console.Read();

        }
    }
}
