//0 la biten sayılar
class Program
{

    static void Main(string[] args)
    {
        int[] dizi = new int[5];
        int sayaç = 0;
        Random rnd = new Random();
        for (int i = 0; i < 5; i++)
        {
            dizi[i] = rnd.Next(0, 100);
        }
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(dizi[i]);
            if (dizi[i] % 10 == 0)
            {
                sayaç++;
            }
        }

        Console.WriteLine("{0} kadar 0 la biten vardır", sayaç);
    }
}

// sayısal loto
class Program
{

    static void Main(string[] args)
    {
        int[] dizi = new int[6];
        int sayaç = 0, kolon;
        Random rnd = new Random();

        Console.WriteLine("kaç kolon oynamak istiyorsunuz");
        kolon = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < kolon; i++)
        {
            Console.WriteLine("{0} . kolon", i);
            for (int j = 0; j < 6; j++)
            {
                dizi[j] = rnd.Next(0, 50);
            }
            for (int j = 0; j < 6; j++)
            {
                for (int k = j + 1; k < 6; k++)
                {
                    if (dizi[j] > dizi[k])
                    {
                        sayaç = dizi[j];
                        dizi[j] = dizi[k];
                        dizi[k] = sayaç;
                    }
                }
            }
            for (int j = 0; j < 6; j++)
            {
                Console.Write("{0}\t", dizi[j]);
            }
            Console.Write("\n");
        }

    }
}

//kurallara bağlı soru
class Program
{

    static void Main(string[] args)
    {
        int gün;
        int[] kişi;
        char[] hava;
        float[] sıcaklık;
        int kişit;
        float sıcaklıkt;
        char havat;
        Console.WriteLine("bir ayda kaç gün vardır");
        gün = Convert.ToInt32(Console.ReadLine());
        kişi = new int[gün];
        sıcaklık = new float[gün];
        hava = new char[gün];
        for (int i = 0; i < gün; i++)
        {

            Console.WriteLine("{0}.gün kaç kişi oynayacağını giriniz", i + 1);
            kişi[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}.gün sıcaklık girdilerini giriniz", i + 1);
            sıcaklık[i] = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("{0}.gün hava girdilerini küçük harfle giriniz(y/g/b)", i + 1);
            hava[i] = Convert.ToChar(Console.ReadLine());
            while (true)
            {
                if (hava[i] != 'y' && hava[i] != 'g' && hava[i] != 'b')
                {
                    Console.WriteLine("lütfen geçerli ve küçük karakterli bir harf giriniz");
                    hava[i] = Convert.ToChar(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }
        }
        for (int i = 0; i < gün; i++)
        {
            if (hava[i] == 'g')
            {
                Console.Write("hava güneşli");
            }
            else if (hava[i] == 'b')
            {
                Console.Write("hava bulutlu");
            }
            else if (hava[i] == 'b')
            {
                Console.Write("hava bulutlu");
            }
            Console.Write("sıcaklık {0}  ", sıcaklık[i]);
            Console.Write("kişi sayısı {0}   ", kişi[i]);
            Console.Write("tenis\t");
            if (hava[i] == 'g')
            {
                havat = hava[i];
                kişit = kişi[i];
                sıcaklıkt = sıcaklık[i];

                tahmin(kişit, sıcaklıkt, havat);
            }
            else if (hava[i] == 'b')
            {
                havat = hava[i];
                kişit = kişi[i];
                sıcaklıkt = sıcaklık[i];
                tahmin(kişit, havat, sıcaklıkt);
            }
            else if (hava[i] == 'y')
            {
                havat = hava[i];
                kişit = kişi[i];
                sıcaklıkt = sıcaklık[i];
                tahmin(sıcaklıkt, havat, kişit);
            }
        }
    }
    static void tahmin(int kişi, float sıcaklık, char hava)
    {
        if (hava == 'g' && kişi % 2 == 0)
        {
            Console.WriteLine("evet");
        }
        else
        {
            Console.WriteLine("hayır");
        }
    }
    static void tahmin(int kişi, char hava, float sıcaklık)
    {
        if (hava == 'b' && kişi % 2 == 0)
        {
            if (sıcaklık > 23.5)
            {
                Console.WriteLine("evet");
            }
            else
            {
                Console.WriteLine("hayır");
            }
        }
    }
    static void tahmin(float sıcaklık, char hava, int kişi)
    {
        if (hava == 'y')
        {
            Console.WriteLine("hayır");
        }
    }
}

//kütüphane uygulaması
class Program
{

    static void Main(string[] args)
    {
        string[] isimler = new string[50];
        int sayı = 0, d_v, seçim;
        Console.WriteLine("lütfen aşağıdaki işlemlerden birisini seçiniz");
        Console.WriteLine("1)okuduğunuz bir kitabı ekleyiniz");
        Console.WriteLine("2)kitapları görüntüleyin");
        Console.WriteLine("3)kitapları çıkartın");
        Console.WriteLine("çıkış için q ya basınız");
        seçim = Convert.ToInt32(Console.ReadLine());
        if (seçim == 1)
        {
            sayı = ekle(sayı, isimler);
        }
        else if (seçim == 2)
        {
            göster(sayı, isimler);
        }
        else if (seçim == 3)
        {
            sil(sayı, isimler);
        }
        else if (seçim == 'q')
        {

        }
        while (true)
        {
            Console.WriteLine("devam etmek için 1 e çıkmak için 0 a basınız");
            d_v = Convert.ToInt32(Console.ReadLine());
            if (d_v == 1)
            {
                Console.WriteLine("lütfen aşağıdaki işlemlerden birisini seçiniz");
                Console.WriteLine("1)okuduğunuz bir kitabı ekleyiniz");
                Console.WriteLine("2)kitapları görüntüleyin");
                Console.WriteLine("3)kitapları çıkartın");
                Console.WriteLine("çıkış için q ya basınız");
                seçim = Convert.ToInt32(Console.ReadLine());
                if (seçim == 1)
                {
                    sayı = ekle(sayı, isimler);
                }
                else if (seçim == 2)
                {
                    göster(sayı, isimler);
                }
                else if (seçim == 3)
                {
                    sil(sayı, isimler);
                }
                else if (seçim == 'q')
                {
                    break;
                }
            }
            else
            {
                break;
            }
        }

    }
    static int ekle(int sayaç, string[] isimler)
    {
        Console.WriteLine("eklemek istediğiniz kitabın ismini giriniz");
        isimler[sayaç] = Console.ReadLine();
        sayaç++;
        return sayaç;
    }
    static void göster(int sayaç, string[] isimler)
    {
        for (int i = 0; i < sayaç; i++)
        {
            Console.WriteLine(isimler[i]);
        }
    }
    static void sil(int sayaç, string[] isimler)
    {
        Console.WriteLine("silmek istediğiniz kitabın ismini yazınız");
        string adios = Console.ReadLine();
        for (int i = 0; i < sayaç; i++)
        {
            if (isimler[i] == adios)
            {
                isimler[i] = isimler[i + 1];
            }
        }
    }
}

// combinasyon bulan program
class Program
{
    static void Main(string[] args)
    {
        int r, n;
        Console.WriteLine("lütfen sırayla kombinasyonu alınacak C(n,r) yani n ve  r sayısını giriniz");
        n = Convert.ToInt32(Console.ReadLine());
        r = Convert.ToInt32(Console.ReadLine());
        int farkınsayısı = n - r;
        int nsa = nf(n);
        int rsa = rf(r);
        int fark = fark1(farkınsayısı);
        int kombinasyon = (nsa) / (fark * rsa);
        Console.WriteLine(nsa);
        Console.WriteLine(rsa);
        Console.WriteLine(fark);
        Console.WriteLine("C(n,r)={0}", kombinasyon);
    }
    static int nf(int sayı)
    {
        if (sayı == 1)
        {
            return 1;
        }
        else
        {
            return sayı * nf(sayı - 1);
        }
    }
    static int rf(int sayı)
    {
        if (sayı == 1)
        {
            return 1;
        }
        else
        {
            return sayı * rf(sayı - 1);
        }
    }
    static int fark1(int sayı)
    {
        if (sayı == 1 || sayı == 0)
        {
            return 1;
        }
        else
        {
            return sayı * fark1(sayı - 1);
        }
    }
}

// matris yapan program
class Program 
{
    static void Main(string[] args)
    {
        int[, ] dizi;
        Console.WriteLine("lütfen dizinin satır ve sütün sayılarını giriniz");
        int satır, sütün;
        satır = Convert.ToInt32(Console.ReadLine());
        sütün = Convert.ToInt32(Console.ReadLine());
        dizi = new int[satır, sütün];
        Console.WriteLine("lütfen değerleri giriniz");
        for (int i = 0; i < satır; i++)
        {
            for (global::System.Int32 j = 0; j < sütün; j++)
            {
                dizi[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        for (int i = 0; i < satır; i++)
        {
            for (global::System.Int32 j = 0; j < sütün; j++)
            {
                Console.Write(dizi[i, j]);
                Console.Write("\t");
            }
            Console.Write("\n");
        }
    }

}
