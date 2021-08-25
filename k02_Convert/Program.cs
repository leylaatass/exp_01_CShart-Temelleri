using System;

namespace k02_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Sayıyı giriniz");
            var sayi1 = Console.ReadLine();
            int intsayi1 = Convert.ToInt32(sayi1);
            Console.WriteLine("2.sayıyı giriniz");
            var sayi2 = Console.ReadLine();
            int intsayi2 = Convert.ToInt32(sayi2);
            var toplam = sayi1 + sayi2;
            var gerçektoplam = intsayi1 + intsayi2;
            Console.WriteLine($"toplam:{toplam}");
            Console.WriteLine($"gerçektoplam:{gerçektoplam}");

        }
    }  
      
   
}
