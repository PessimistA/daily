class geometrik_şekiller
{
    private int taban;
    private int yükselik;
    private double alan;
    private int çevre;
    public void Eşkenarüçgen()
    {
        Console.WriteLine("üçgenin alt tabanını giriniz");
        this.taban = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("üçgenin yüksekliğini giriniz");
        this.yükselik = Convert.ToInt32(Console.ReadLine());

    }
    public void Alan()
    {
        this.alan = this.taban * this.yükselik;
        Console.WriteLine("alan={0}", this.alan);
    }
    public void ÇevreÜçgen()
    {
        this.çevre = 3 * taban;
        Console.WriteLine("çevre={0}", this.çevre);
    }
    public void Kare()
    {
        Console.WriteLine("karenin bir kenarını giriniz");
        this.taban = Convert.ToInt32(Console.ReadLine());
        this.yükselik = this.taban;
    }
    public void Çevrekare()
    {
        this.çevre = 4 * taban;
        Console.WriteLine("çevre={0}", this.çevre);
    }
    public void dikdörtgen()
    {
        Console.WriteLine("dikdörtgenin bir kenarını giriniz");
        this.taban = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("uzun kenarını giriniz");
        this.yükselik = Convert.ToInt32(Console.ReadLine());

    }
    public void Çevredikdörgen()
    {
        this.çevre = (2 * yükselik) + (2 * taban);
        Console.WriteLine("çevre={0}", this.çevre);
    }

}

//
class program
{

    static void Main(string[] args)
    {
        geometrik_şekiller geometrik_ = new geometrik_şekiller();
        Console.WriteLine("lütfen hangi geometrik şekilin alanını bulacağınızı yazınız(dik=dikdörtgen, üç= üçgen, kare)");
        string hangi = Console.ReadLine();
        if (hangi == "dik")
        {
            geometrik_.dikdörtgen();
            geometrik_.Alan();
            geometrik_.Çevredikdörgen();
        }
        else if (hangi == "üç")
        {
            geometrik_.Eşkenarüçgen();
            geometrik_.Alan();
            geometrik_.ÇevreÜçgen();
        }
        else if (hangi == "kare")
        {
            geometrik_.Kare();
            geometrik_.Alan();
            geometrik_.Çevrekare();
        }
    }
}

//
class MyClass
{
    private int uzunluk;
    private int yükseklik;
    private int alan;
    private int çevre;
    public MyClass()
    {
        uzunluk = 0;
        yükseklik = 0;
        alan = 0;
        çevre = 0;
    }
    public MyClass(int uzunluk, int yükseklik, int alan, int çevre)
    {
        this.uzunluk = uzunluk;
        this.yükseklik = yükseklik;
        this.alan = alan;
        this.çevre = çevre;
    }
    public void hesapla()
    {
        this.alan = uzunluk * yükseklik;
        this.çevre = 2 * (uzunluk + yükseklik);
        Console.WriteLine("alan={0} çevre={1}", alan, çevre);
    }

}

// şekillli sorular
    class Program//sola yatık paralelkenar soruları
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (global::System.Int32 j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (global::System.Int32 j = 1; j <= 4; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }

    class Program//sağa yatık paralel
    {
        static void Main(string[] args)
        {
            int sayı = 5;
            for (int i = 1; i <= sayı; i++)
            {
                for (global::System.Int32 j = i; j <= sayı; j++)
                {
                    Console.Write(" ");
                }
                for (global::System.Int32 j = 1; j <= sayı; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }

    class Program// ortaya basılmış üçgen
    {
        static void Main(string[] args)
        {
            int sayı = 5;
            for (int i = 1; i <= sayı; i++)
            {
                for (global::System.Int32 j = sayı; j >= 1 + i; j--)
                {
                    Console.Write(" ");
                }
                for (global::System.Int32 j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }

    class Program// sola yatık üçgen
    {
        static void Main(string[] args)
        {
            int sayı = 5;
            for (int i = 1; i <= sayı; i++)
            {
                for (global::System.Int32 j = 1; j < sayı; j++)// bunun bir faydası yok
                {
                    Console.Write(" ");
                }
                for (global::System.Int32 j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }

    class Program// sağa yatık üçgen
    {
        static void Main(string[] args)
        {
            int sayı = 5;
            for (int i = 1; i <= sayı; i++)
            {
                for (global::System.Int32 j = sayı - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (global::System.Int32 j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }