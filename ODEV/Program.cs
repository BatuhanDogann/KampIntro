using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("******\nhoşgeldiniz\n******\nisminiz nedir\n");
        string isim;
        isim = Console.ReadLine(); //kullanıcıdan input al
        Console.WriteLine("\nhoşgeldin " + isim + "\n");

        Product p1 = new Product(); //class yapısını tanımla
        p1.ayakkabı_markası = "X";
        p1.numara = 43;
        p1.adet = 20;
        p1.renk = "yeşil";
        p1.fiyat = 120;

        Product p2 = new Product();
        p2.ayakkabı_markası = "Y";
        p2.numara = 42;
        p2.adet = 25;
        p2.renk = "kırmızı";
        p2.fiyat = 162;

        Product p3 = new Product();
        p3.ayakkabı_markası = "Z";
        p3.numara = 41;
        p3.adet = 10;
        p3.renk = "siyah";
        p3.fiyat = 250;


        Product[] product = new Product[] { p1, p2, p3 };
        foreach (Product pro in product)
        {
            //classların içindeki tüm değişkenleri bastır
            Console.WriteLine(pro.ayakkabı_markası + " markasının ayakkabısının şu numaraları mevcuttur\n" + pro.numara + "\nrenk ve adet : " + pro.renk + " " + pro.adet + "fiyat :" + pro.fiyat + "tl\n");


        }
        Console.WriteLine("Almak istediğin markayı seç çıkmak için E'ye bas \n");
        //kullanıcıdan secenek al
        string secenek;
        secenek = Console.ReadLine();//input
        sepet s1 = new sepet();
        s1.sayi = 0; //sepetteki ürünlerimiz başta 0dır
        s1.tutar = 0; //ödeyeceğimiz miktar başta 0dır
        while (secenek != "E")
        {
            if (secenek == "X")
            {
                Console.WriteLine("ÜRÜNÜNÜZ EKLENDİ\n");
                s1.sayi += 1; //sepetteki ürünümüz bir artar
                p1.adet -= 1; //markanın stoğu 1 azalır
                s1.tutar += p1.fiyat;
            }
            else if (secenek == "Y")
            {
                Console.WriteLine("ÜRÜNÜNÜZ EKLENDİ\n");
                s1.sayi += 1; //sepetteki ürünümüz bir artar
                p2.adet -= 1; //markanın stoğu 1 azalır
                s1.tutar += p2.fiyat;
            }
            else if (secenek == "Z")
            {
                Console.WriteLine("ÜRÜNÜNÜZ EKLENDİ\n");
                s1.sayi += 1; //sepetteki ürünümüz bir artar
                p3.adet -= 1; //markanın stoğu 1 azalır
                s1.tutar += p2.fiyat;
            }
            else
            {
                break;
            }
           
            Console.WriteLine("Almak istediğin markayı seç çıkmak için E'ye bas \n");
            secenek = Console.ReadLine();
        }

        foreach (Product pro in product)
        {
            Console.WriteLine(pro.ayakkabı_markası + " markasının ayakkabısının şu numaraları mevcuttur\n" + pro.numara + "\nrenk ve adet : " + pro.renk + " " + pro.adet + "\nfiyat :" + pro.fiyat + "tl\n");


        }

        Console.WriteLine("sepetinizde " + s1.sayi + " adet ürün bulunmaktadır\nTOPLAM TUTAR " + s1.tutar + " tl'dir\n");





    }
}
class Product
{
    public string ayakkabı_markası { get; set; }

    public int numara { get; set; }

    public int adet { get; set; }

    public int fiyat { get; set; }

    public string renk { get; set; }

}
class sepet
{
    public int sayi { get; set; }

    public int tutar { get; set; }
}