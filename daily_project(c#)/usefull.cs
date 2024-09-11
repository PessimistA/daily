//kullanışlılar
//metin analiz aracı
class Program
{

    static void Main(string[] args)
    {
        int harf_sayısı = 0, boşluk_sayısı = 0, noktalam_sayısı = 0;
        char[] met;
        Console.WriteLine("lütfen metini giriniz");
        string metin = Console.ReadLine();
        int size = metin.Length;
        met = new char[size];
        Console.WriteLine(size);
        for (int i = 0; i < size; i++)
        {
            if (metin[i] <= 'z' && metin[i] >= 'a')
            {
                harf_sayısı++;
            }
            else if (metin[i] == ' ')
            {
                boşluk_sayısı++;
            }
            else if (metin[i] == ',' || metin[i] == '.' || metin[i] == ';' || metin[i] == ':' || metin[i] == '!' || metin[i] == '?')
            {
                noktalam_sayısı++;
            }
        }
        Console.WriteLine("harf sayısı {0} boşluk sayısı {1} noktalama sayısı {2}", harf_sayısı, boşluk_sayısı, noktalam_sayısı);
    }
}

//polindrom
class Program
{

    static void Main(string[] args)
    {
        string kontrol;
        Console.WriteLine("kontrol edilecek kelime ya da cümleyi giriniz");
        kontrol = Console.ReadLine();
        int uzunluk = kontrol.Length;
        çevirici(kontrol, uzunluk);

    }
    static void çevirici(string kontrol, int uzunluk)
    {
        string yeni = "";
        for (int i = uzunluk - 1; i >= 0; i--)
        {
            yeni = yeni + kontrol[i];
        }
        Console.WriteLine(yeni);
        if (yeni == kontrol)
        {
            Console.WriteLine("polindromdur");
        }
        else
        {
            Console.WriteLine("polindrom değildir");
        }
    }
}
//binary
class Program// binary yazan program
{

    static void Main(string[] args)
    {
        int sayı;
        int ikihesaplama = 0;
        int[] ikilik = new int[50];
        int[] yeni = new int[50];
        Console.WriteLine("sayıyı giriniz");
        sayı = Convert.ToInt32(Console.ReadLine());
        int sayı2 = sayı;
        while (true)
        {
            if (sayı2 == 1)
            {
                ikihesaplama++;
                break;
            }
            else
            {
                sayı2 = sayı2 / 2;
                ikihesaplama++;
            }
        }
        Console.WriteLine("ikilik sayısı = {0}", ikihesaplama);
        for (int i = 0; i < ikihesaplama; i++)
        {
            if (sayı == 1)
            {
                ikilik[i] = 1;
            }
            else
            {
                ikilik[i] = sayı % 2;
                sayı = sayı / 2;
            }
        }
        for (int i = 0; i < ikihesaplama; i++)
        {
            Console.Write(ikilik[i]);
        }
        for (int i = 0; i < ikihesaplama; i++)
        {
            yeni[ikihesaplama - i - 1] = ikilik[i];
        }
        Console.WriteLine(" ");
        for (int i = 0; i < ikihesaplama; i++)
        {
            Console.Write(yeni[i]);
        }
    }
}

// tekrar eden harfleri sayan program
class Program{

    static void Main(string[] args)
    {
        string kontrol;
        int kelimesayısı = 0, harfsayısı = 0, sayaç = 0, içsayaç;
        int[] kaçtane = new int[100];
        string tekrarEtmiyenler = " ";
        Console.WriteLine("lütfen metni giriniz");
        kontrol = Console.ReadLine();
        int uzunluk = kontrol.Length;
        Console.WriteLine(uzunluk);
        for (int i = 0; i < uzunluk; i++)
        {
            if (kontrol[i] >= 'a' && kontrol[i] <= 'z')
            {
                harfsayısı++;
            }
            else if (kontrol[i] == ' ')
            {
                kelimesayısı++;
            }
        }
        for (int i = 0; i < uzunluk; i++)
        {
            if (!tekrarEtmiyenler.Contains(kontrol[i]))
            {
                tekrarEtmiyenler += kontrol[i];
                sayaç++;
            }
        }
        for (int i = 0; i < sayaç + 1; i++)
        {
            içsayaç = 0;
            for (global::System.Int32 j = 0; j < uzunluk; j++)
            {
                if (tekrarEtmiyenler[i] == kontrol[j])
                {
                    içsayaç++;
                }
            }
            kaçtane[i] = içsayaç;
        }
        for (int i = 0; i < sayaç + 1; i++)
        {
            Console.Write(tekrarEtmiyenler[i]);
            Console.Write(" --{0}\n", kaçtane[i]);
        }
        Console.WriteLine("kelime sayısı={0} ve harf sayısı{1}", kelimesayısı + 1, harfsayısı);
    }
}

// mesela metinden istediğimiz bir harfi çıkarma şansımız da olsun 
class Program
{//split kullanımı önemli

    static void Main(string[] args)
    {
        string girilenmetin, yenimetin = " ";
        char istenmeyenkarakter;
        string istenmeyenmetin;
        char deneme;
        Console.WriteLine("istediğiniz metini giriniz");
        girilenmetin = Console.ReadLine();
        int uzunluk = girilenmetin.Length;
        Console.WriteLine("istemediğiniz bir harf ise h metin ise m giriniz");
        deneme = Convert.ToChar(Console.ReadLine());
        if (deneme == 'h')
        {
            Console.WriteLine("istemedşiğiniz karakteri giriniz");
            istenmeyenkarakter = Convert.ToChar(Console.ReadLine());
            for (global::System.Int32 i = 0; i < uzunluk; i++)
            {
                if (istenmeyenkarakter != girilenmetin[i])
                {
                    yenimetin += girilenmetin[i];
                }
            }
        }
        if (deneme == 'm')
        {
            Console.WriteLine("istemedşiğiniz metini giriniz");
            istenmeyenmetin = Console.ReadLine();
            string[] kelimeler = girilenmetin.Split(' ');
            foreach(var kelime in kelimeler)
            {
                if (kelime != istenmeyenmetin)
                {
                    yenimetin = yenimetin + " " + kelime;
                }
            }
        }
        Console.WriteLine(yenimetin);

    }
}

// recursive ile ters çevrilen dizi
class Program
{

    static void Main(string[] args)
    {
        int[] dizi = new int[6] { 1, 2, 3, 55, 34, 65 };
        int ilk = 0, son = 5;
        ters(dizi, ilk, son);
        Console.WriteLine("");
        for (int i = 0; i < dizi.Length; i++)
        {
            Console.Write(dizi[i] + " ");
        }


    }
    static void ters(int[] dizi, int ilk, int son)
    {
        if (ilk >= son)
        {
            return;
        }
        else
        {
            int temp = dizi[ilk];
            dizi[ilk] = dizi[son];
            dizi[son] = temp;
            ters(dizi, ilk + 1, son - 1);
        }
    }
}

// kelimeyi stringi ters çeviren program
class Program
{

    static void Main(string[] args)
    {
        string dizi;
        Console.WriteLine("lütfen istediğiniz kelimeyi giriniz");
        dizi = Console.ReadLine();
        char[] tersdizi = dizi.ToCharArray();
        int ilk = 0, son;
        son = dizi.Length;
        ters(tersdizi, ilk, son);
        Console.WriteLine("");
        for (int i = 0; i < dizi.Length; i++)
        {
            Console.Write(tersdizi[i] + " ");
        }


    }
    static void ters(char[] dizi, int ilk, int son)
    {
        if (ilk >= son)
        {
            return;
        }
        else
        {
            char temp = dizi[ilk];
            dizi[ilk] = dizi[son - 1];
            dizi[son - 1] = temp;
            ters(dizi, ilk + 1, son - 1);
        }
    }
}

// isimleri alfabetik olarak sıralayan program
class Program
{
    static void Main(string[] args)
    {
        string[] isimler = new string[5];
        Console.WriteLine("5 tane isim giriniz");
        for (int i = 0; i < 5; i++)
        {
            isimler[i] = Console.ReadLine();
        }
        Console.WriteLine();
        for (int i = 0; i < 5; i++)
        {
            for (global::System.Int32 j = 0; j < 5; j++)
            {
                if (string.Compare(isimler[i], isimler[j]) < 0)
                {
                    string geç = isimler[i];
                    isimler[i] = isimler[j];
                    isimler[j] = geç;
                }
            }
        }
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(isimler[i]);
        }
    }
}