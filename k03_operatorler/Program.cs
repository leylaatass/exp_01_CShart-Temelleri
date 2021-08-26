using System;

namespace k03_operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
         //var sayi3=330;
         //   sayi3 += 10;
         //   Console.WriteLine(sayi3);
         //   //dışarıdan alınan iki sayının toplamının karesini bulunuz.
         //   Console.WriteLine("birinci sayıyı giriniz");
         //   var girilensayi1 = Console.ReadLine();
         //   var sayi1 = Convert.ToInt32(girilensayi1);

         //  Console .WriteLine("ikinci sayıyı giriniz");
         //   var girilensayi2 = Console.ReadLine();
         //   var sayi2 = Convert.ToInt32(girilensayi2);
         //   var toplam = sayi1 + sayi2;
         //   var karesi = toplam * toplam;
         //   Console.WriteLine($"toplamlarının karesi={karesi}");


            //vize notunun %30u,final notunun %70 ini hesaplayarak ortalamayı bulunuz ve ekranda gösteriniz.
            Console.WriteLine("vize notunu giriniz");
            var girilenVize= Console.ReadLine();
            var vize= Convert.ToDouble(girilenVize);

            Console.WriteLine("final notunu giriniz");
            var girilenFinal = Console.ReadLine();
            var final = Convert.ToDouble(girilenFinal);

            var vizeAgirlik = vize * 0.3;
            var finalagirlik = final * 0.7;

            var ortalama = vizeAgirlik + finalagirlik;
            Console.WriteLine($"Dersin ortalaması:{ortalama}");


            //kullanıcıdan adını,soyadını,mail uzantısını alınız ve ad.soyad@uzanti.com mailini oluşturunuz ve ekranda gösteriniz.
            Console.WriteLine("adini giriniz");
            var girilenAdi = Console.ReadLine();
     
            Console.WriteLine("soyadini giriniz");
            var girilenSoyadi = Console.ReadLine();

            Console.WriteLine("mail uzantisi giriniz");
            var uzanti = Console.ReadLine();
            var mailAdresi = $"{girilenAdi}.{girilenSoyadi}@{uzanti}.com";

            Console.WriteLine($"Mail adresiniz:{mailAdresi}");

              

               







        }
    }
}
