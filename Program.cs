Console.Write("Başlangıçta bir bakiye girin (TL): ");
double bakiye = Convert.ToDouble(Console.ReadLine());
int secim;

//hakan not.

do
{
    Console.WriteLine("\n--- ATM Menüsü ---");
    Console.WriteLine("1: Para Çekme");
    Console.WriteLine("2: Para Yatırma");
    Console.WriteLine("3: Bakiye Sorgulama");
    Console.WriteLine("4: Çıkış");
    Console.Write("Seçiminizi yapın: ");
    secim = Convert.ToInt32(Console.ReadLine());

    switch (secim)
    {
        case 1:
            Console.Write("Çekmek istediğiniz tutarı girin (TL): ");
            double cekilecekTutar = Convert.ToDouble(Console.ReadLine());

            if (cekilecekTutar > bakiye)
            {
                Console.WriteLine("Yetersiz bakiye.");
            }
            else
            {
                bakiye -= cekilecekTutar;
                Console.WriteLine($"{cekilecekTutar} TL başarıyla çekildi. Yeni bakiye: {bakiye} TL");
            }
            break;

        case 2:
            Console.Write("Yatırmak istediğiniz tutarı girin (TL): ");
            double yatirilacakTutar = Convert.ToDouble(Console.ReadLine());

            bakiye += yatirilacakTutar;
            Console.WriteLine($"{yatirilacakTutar} TL başarıyla yatırıldı. Yeni bakiye: {bakiye} TL");
            break;

        case 3:
            Console.WriteLine($"Mevcut bakiye: {bakiye} TL");
            break;

        case 4:
            Console.WriteLine("Çıkış yapılıyor...");
            break;

        default:
            Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
            break;
    }
} while (secim != 4);