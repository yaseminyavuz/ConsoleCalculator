using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Hesap Makinesi");
            Console.WriteLine("1. Toplama");
            Console.WriteLine("2. Çıkarma");
            Console.WriteLine("3. Çarpma");
            Console.WriteLine("4. Bölme");
            Console.WriteLine("5. Çıkış");
            Console.Write("Bir seçenek seçin: ");
            string secim = Console.ReadLine();

            if (secim == "5")
            {
                Console.WriteLine("Programdan çıkılıyor...");
                break;
            }

            Console.Write("Birinci sayıyı girin: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci sayıyı girin: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            double sonuc = 0;

            switch (secim)
            {
                case "1":
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine($"Sonuç: {sonuc}");
                    break;
                case "2":
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine($"Sonuç: {sonuc}");
                    break;
                case "3":
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine($"Sonuç: {sonuc}");
                    break;
                case "4":
                    if (sayi2 != 0)
                    {
                        sonuc = sayi1 / sayi2;
                        Console.WriteLine($"Sonuç: {sonuc}");
                    }
                    else
                    {
                        Console.WriteLine("Hata: Sıfıra bölme yapılamaz!");
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz seçenek!");
                    break;
            }

            Console.WriteLine(); // Yeni bir satır için boşluk bırak
        }
    }
}

