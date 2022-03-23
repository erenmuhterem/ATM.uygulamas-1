Console.WriteLine("Atm ye hoşgeldiniz");
Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
string secim = Console.ReadLine();
int bakiye = 1000;

if (secim == "1")
{
    Console.WriteLine("Şuanki bakiyeniz :" + bakiye);
}
else if (secim == "2")
{
    Console.WriteLine("Çekmek istediğiniz tutarı giriniz");
    int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());

    if (cekilecek_tutar <= bakiye)
    {
        Console.WriteLine("Kalan tutar : " + (bakiye - cekilecek_tutar));
    }

    else
    {
        Console.WriteLine("Bakiyenizden fazla para çekemezsiniz");
    }
}

else if (secim == "3")
{
    Console.WriteLine("Yatırmak istediğiniz tutarı giriniz : ");
    int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Yeni bakiyeniz : " + (bakiye + yatirilacak_tutar));
}

else if (secim == "q")
{
    Console.WriteLine("ATM den çıkış yapılıyor");
    Console.WriteLine("Çıkış yapıldı iyi günler");
}

else
{
    Console.WriteLine("Lütfen geçerli bir değer giriniz");
}
