//asal sayı soru tipleri
class program//dizi kulllanarak asalları bulmak
{

    static void Main(string[] args)
    {
        int[] asallar;
        int sayaç = 1;
        Console.WriteLine("bir son sayı veriniz");
        int sayı = Convert.ToInt32(Console.ReadLine());
        asallar = new int[sayı];
        asallar[0] = 2;
        for (int i = 3; i < sayı; i++)
        {
            bool dön = true;
            for (global::System.Int32 j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    dön = false;
                }
            }
            if (dön)
            {
                asallar[sayaç] = i;
                sayaç++;
            }
        }
        for (int i = 0; i < sayaç; i++)
        {
            Console.WriteLine(asallar[i]);
        }
    }
}

class program// dizi kullanmadan bulmak 
{

    static void Main(string[] args)
    {
        //dizi kulllanarak asalları bulmak
        int[] asallar;
        int sayaç = 1;
        Console.WriteLine("bir son sayı veriniz");
        int sayı = Convert.ToInt32(Console.ReadLine());
        asallar = new int[sayı];
        asallar[0] = 2;
        for (int i = 3; i < sayı; i++)
        {
            Console.WriteLine(asal(i));
        }
    }
    static int asal(int i)
    {
        bool dön = true;
        for (global::System.Int32 j = 2; j < i; j++)
        {
            if (i % j == 0)
            {
                dön = false;
                break;
            }
        }
        if (dön)
        {
            return i;
        }
        return 0;
    }
}

//recursive soru tipleri
class Program// üs alma
{
    static void Main(string[] args)
    {
        int sayı;
        Console.WriteLine("sayı giriniz");
        sayı = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("hangi katını almak istediğinizi giriniz");
        int kat = Convert.ToInt32(Console.ReadLine());
        int sonuç = üs(sayı, kat);
        Console.WriteLine(sonuç);
    }
    static int üs(int sayı, int kat)
    {

        if (kat == 0)
        {
            return 1;
        }
        else
        {
            return üs(sayı, kat - 1) * sayı;
        }
    }
}

class Program// faktoriyel hesaplama
{
    static void Main(string[] args)
    {
        int sayı;
        Console.WriteLine("faktoriyelini alacağımız sayıyı gir");
        sayı = Convert.ToInt32(Console.ReadLine());
        int sonuç = fak(sayı);
        Console.WriteLine(sonuç);
    }
    static int fak(int sayı)
    {

        if (sayı == 0)
        {
            return 1;
        }
        else
        {
            return fak(sayı - 1) * sayı;
        }
    }
}

class Program//fibonacci
{
    static void Main(string[] args)
    {
        int sayı;
        Console.WriteLine("fibonacci için sayı giriniz alacağımız sayıyı gir");
        sayı = Convert.ToInt32(Console.ReadLine());
        int sonuç = fibonaccı(sayı);
        Console.WriteLine(sonuç);
    }
    static int fibonaccı(int sayı)
    {

        if (sayı == 0 || sayı == 1)
        {
            return sayı;
        }
        else
        {
            return fibonaccı(sayı - 1) + fibonaccı(sayı - 2);
        }
    }
}

class Program// basamaklarını veren program
{
    static void Main(string[] args)
    {
        int sayı;
        string boş = " ";
        Console.WriteLine("basamaklarını alacağınız sayıyı giriniz");
        sayı = Convert.ToInt32(Console.ReadLine());
        int sonuç = basamakdeğeri(sayı, ref boş);
        int uzunluk = boş.Length;
        for (int i = 0; i < uzunluk; i++)
        {
            Console.Write($"{ boş[i]}\t");
        }
    }
    static int basamakdeğeri(int sayı, ref string boş)
    {

        if (sayı == 0)
        {
            return 1;
        }
        else
        {
            boş = (sayı % 10) + boş;
            sayı = sayı / 10;
            return basamakdeğeri(sayı, ref boş);
        }
    }
}

class program// iki sayı arasını toplayan recursive
{

    static void Main(string[] args)
    {
        int sayı, toplam = 0;
        Console.WriteLine("iki sayı giriniz ve aralığını recursive ile toplayınız");
        int ilk = Convert.ToInt32(Console.ReadLine());
        int son = Convert.ToInt32(Console.ReadLine());
        toplam = topla(ilk, son);
        Console.WriteLine(toplam);

    }
    static int topla(int ilk, int son)
    {

        if (ilk > son)
        {
            return 0;
        }
        if (ilk == son)
        {
            return ilk;
        }
        else
        {
            return ilk + son + topla(ilk + 1, son - 1);
        }
    }
}

class program// dizi elemanlarını toplayan recursive
{

    static void Main(string[] args)
    {
        int[] dizi = { 1,2,3,4,5,6 };
        int son = dizi.Length - 1;
        int ilk = 0;
        int toplam = topla(ilk, son, dizi);
        Console.WriteLine(toplam);

    }
    static int topla(int ilk, int son, int[] dizi)
    {

        if (ilk == son)
        {
            return dizi[ilk];
        }
        if (ilk > son)
        {
            return 0;
        }
        else
        {
            int toplam = dizi[ilk] + dizi[son];
            return toplam + topla(ilk + 1, son - 1, dizi);
        }
    }
}

class Uygulama//a üssü a ve karesini recursive ile bulan program
{
    static void Main(string[] args)
    {
        int ilk, son;
        Console.WriteLine("lütfen ilk sayıyı giriniz");
        ilk = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("son sayıyı giriniz");
        son = Convert.ToInt32(Console.ReadLine());
        for (int i = ilk; i < son; i++)
        {
            Console.Write("{0}\t", aüssüa(i, i));
            Console.Write("{0}\t", kare(i, 2));
        }
    }
    static int aüssüa(int n, int sayaç)
    {
        if (sayaç <= 0)
        {
            return 1;
        }
        else
        {
            return n * aüssüa(n, sayaç - 1);
        }
    }
    static int kare(int n, int sayaç)
    {
        if (sayaç <= 0)
        {
            return 1;
        }
        else
        {
            return n * kare(n, sayaç - 1);
        }
    }
}

class Uygulama// daha temiz sıralama
{
    static void Main(string[] args)
    {
        Console.WriteLine("kaç sayı gireceğinizi yazınız");
        int kaç = Convert.ToInt32(Console.ReadLine());
        int[] dizi = new int[kaç];
        for (int i = 0; i < kaç; i++)
        {
            dizi[i] = Convert.ToInt32(Console.ReadLine());
        }
        bul(dizi, 0, kaç - 1, kaç - 1, kaç - 1);
        for (int i = 0; i < kaç; i++)
        {
            Console.WriteLine(dizi[i]);
        }

    }
    static int bul(int[] dizi, int ilk, int son, int fark1, int fark)
    {
        if (ilk == son)
        {
            return 0;
        }
        else
        {
            if (fark == ilk)
            {
                fark = fark1;
                return bul(dizi, ilk + 1, son, fark1, fark);
            }
            else
            {
                if (dizi[ilk] > dizi[fark])//döngüden farklı olarak küçük işareti büyükten küçüğe büyük işareti küçükten büyüğe sıralar
                {
                    int geç = dizi[ilk];
                    dizi[ilk] = dizi[fark];
                    dizi[fark] = geç;
                }
                return bul(dizi, ilk, son, fark1, fark - 1);

            }
        }
    }

}
}

class Program// metin için void ile recursive
{
    static void Main(string[] args)
    {
        string alınan;
        Console.WriteLine("bir metin giriniz");
        alınan = Console.ReadLine();
        char[] charkardeş = alınan.ToCharArray();
        int uzunluk = alınan.Length;
        çevirici(charkardeş, 0, uzunluk-1);
        for (global::System.Int32 i = 0; i < uzunluk; i++)
        {
            Console.WriteLine(charkardeş[i]);
        }

    }
    static void çevirici(char[] dizi, int ilk, int son)
    {
        if (ilk >= son)
        {
            return;
        }
        else
        {
            char geç = dizi[ilk];
            dizi[ilk] = dizi[son];
            dizi[son] = geç;
            çevirici(dizi, ilk + 1, son - 1);
        }

    }
}