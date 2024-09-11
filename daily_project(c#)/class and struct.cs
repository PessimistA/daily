// struct ve classlar
class program
{
    struct öğrenci
    {
        public string isim;
        public string numara;
        public double vize;
        public double final;
        public double ortalama;
        private int yaş;
        public öğrenci(int yaş)
        {
            this.yaş = yaş;
        }
        public void basıcı(int yaş)
        {
            Console.Write("yaşı= {0}", this.yaş);
        }
    }
    static void Main(string[] args)
    {
        öğrenci ögr1 = new öğrenci();
        öğrenci ögr2 = new öğrenci(12);
        Console.WriteLine("iki öğrenci içinde sırayla isim giriniz");
        ögr1.isim = Console.ReadLine();
        ögr2.isim = Console.ReadLine();
        Console.WriteLine("iki öğrenci içinde sırayla numara giriniz");
        ögr1.numara = Console.ReadLine();
        ögr2.numara = Console.ReadLine();
        Console.WriteLine("iki öğrenci içinde sırayla vize notlarını giriniz");
        ögr1.vize = Convert.ToDouble(Console.ReadLine());
        ögr2.vize = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("iki öğrenci içinde sırayla final notlarını giriniz giriniz");
        ögr1.final = Convert.ToDouble(Console.ReadLine());
        ögr2.final = Convert.ToDouble(Console.ReadLine());
        ögr1.ortalama = (ögr1.final * 0.4) + (ögr1.vize * 0.6);
        ögr2.ortalama = (ögr2.final * 0.4) + (ögr2.vize * 0.6);
        Console.WriteLine("birinci öğrencinin isim={0} numara={1} vize={2} final={3} ortalama={4} ", ögr1.isim, ögr1.numara, ögr1.vize, ögr1.final, ögr1.ortalama);
        ögr1.basıcı(12);
        Console.WriteLine("birinci öğrencinin isim={0} numara={1} vize={2} final={3} ortalama={4} ", ögr2.isim, ögr2.numara, ögr2.vize, ögr2.final, ögr2.ortalama);
        ögr1.basıcı(23);
    }
}

//
class program
{

    static void Main(string[] args)
    {
        int a = 3, b = 7, c = 11, mim = 0, max;
        if (a > c)
        {
            if (c < b)
            {
                mim = c;
            }
            else
            {
                mim = b;
            }
        }
        if (b > a)
        {
            if (a > c)
            {
                mim = c;
            }
            else
            {
                mim = a;
            }
        }
        if (c > b)
        {
            if (b > a)
            {
                mim = a;
            }
            else
            {
                mim = b;
            }
        }
        Console.WriteLine(mim);
    }

//kitap
class kitaplık
{
    private string ismi;
    private string yazar;
    private string basımyılı;
    public int satış_sayısı;
    public string İsmi
    {
        get
        {
            return ismi;
        }
        set
        {
            ismi = value;
        }
    }
        public string Yazar
        {
            get
            {
                return yazar;
            }
            set
            {
                yazar = value;
            }
        }
            public kitaplık(string basımyılı)
            {
                this.basımyılı = basımyılı;
            }
            public kitaplık()
            {
                this.basımyılı = "2024";
            }
            public string dönüş()
            {
                return this.basımyılı;
            }

}

    //
   struct timing
   {
       public int saat;
       public int dakika;
       public int saniye;
   }
   class Program
   {

       static void Main(string[] args)
       {
           timing timin = new timing();
           Console.WriteLine("lütfen saati giriniz");
           while (true)
           {
               try
               {
                   timin.saat = Convert.ToInt32(Console.ReadLine());
                   if (timin.saat < 0 || timin.saat>23)
                   {
                       Console.WriteLine("lütfen doğru saati giriniz");
                   }
                   else
                   {
                       break;
                   }

               }
               catch (Exception ex)
               {
                   Console.WriteLine($"{ex}");
               }
           }
           Console.WriteLine("lütfen dakikayı giriniz");
           while (true)
           {
               try
               {
                   timin.dakika = Convert.ToInt32(Console.ReadLine());
                   if (timin.dakika < 0 || timin.dakika > 59)
                   {
                       Console.WriteLine("lütfen doğru dakikayı giriniz");
                   }
                   else
                   {
                       break;
                   }

               }
               catch (Exception ex)
               {
                   Console.WriteLine($"{ex.Message}");
               }
           }
           Console.WriteLine("lütfen saniyeyi giriniz");
           while (true)
           {
               try
               {
                   timin.saniye = Convert.ToInt32(Console.ReadLine());
                   if (timin.saniye < 0 || timin.saniye > 59)
                   {
                       Console.WriteLine("lütfen doğru saniyeyi giriniz");
                   }
                   else
                   {
                       break;
                   }

               }
               catch (Exception ex)
               {
                   Console.WriteLine($"{ex.Message}");
               }
           }
           Console.WriteLine(timin.saat + "." + timin.dakika + "." + timin.saniye);

       }
   }

    //
   struct card
   {
       public String type;
       public int num;
   }
   class MyClass
   {
       static void Main(string[] args)
       {
           card[] deck = new card[52];
           int card_type = 0;
           int card_num = 0;
           for (int i = 0; i < 52; i++)
           {
               if (card_num == 13)
               {
                   card_num = 0;
                   card_type++;

               }
               if (card_type == 0)
                   deck[i].type = "KARO" + "" + (card_num + 1);
               if (card_type == 1)
                   deck[i].type = "KUPA" + "" + (card_num + 1);
               if (card_type == 2)
                   deck[i].type = "MACA" + "" + (card_num + 1);
               if (card_type == 3)
                   deck[i].type = "SİNEK" + "" + (card_num + 1);
               deck[i].num = card_num + 1;
               card_num++;
           }

           Random rnd = new Random();
           for (int i = 51; i > 0; i--)
           {
               int j = rnd.Next(i + 1);
               card temp = deck[i];
               deck[i] = deck[j];
               deck[j] = temp;
           }
           kural();
           for (int k = 0; k < 52; k++)
           {
               Console.WriteLine(deck[k].type);

           }
       }
       static void kural()
       {
           card[] deck = new card[52];
           for (int i = 0; i < 52; i++)
           {
               for (global::System.Int32 j = i; j < i + 1; j++)
               {
                   if ((deck[j].num == (deck[i].num + 1)) || (deck[j].num == (deck[i].num - 1)))
                   {
                       card temp = deck[i];
                       deck[i] = deck[i + 1];
                       deck[i + 1] = temp;
                   }
               }
               for (global::System.Int32 j = i; j < i - 1; j--)
               {
                   if ((deck[j].num == (deck[i].num + 1)) || (deck[j].num == (deck[i].num - 1)))
                   {
                       card temp = deck[i];
                       deck[i] = deck[i + 1];
                       deck[i + 1] = temp;
                   }
               }
           }

       }
   }

    //
   namespace program
   {
       class program
       {
           struct cards
           {
               public string cardname;
               public int number;
               public int rastgelesıra;
               public string sonisim;
           }
           static void Main(string[] args)
           {
               int sayaç = 0, kardsıfırlayıcı = 0, tür_için = 1;
               int[] geç = new int[52];
               bool[] kontrol = new bool[52];
               cards[] card = new cards[52];
               int[][] dizi = new int[4][];
               dizi[0] = new int[13];
               dizi[1] = new int[13];
               dizi[2] = new int[13];
               dizi[3] = new int[13];
               Random r = new Random();
               string[] dizi2 = { "maça","sinek","kupa","karo" };
               int[, ] dizirandom = new int[4, 13];
               for (int i = 0; i < 52; i++)
               {
                   card[i].cardname = dizi2[i / 13];
               }
               for (int i = 0; i < 52; i++)
               {
                   int yeniSayi;
                   do
                   {
                       yeniSayi = r.Next(1, 53);
                   } while (kontrol[yeniSayi - 1]);
                   geç[i] = yeniSayi;
                   kontrol[yeniSayi - 1] = true;
               }
               for (int i = 0; i < 52; i++)
               {
                   card[i].number = geç[i];
               }
               yerleştir(dizi, card);
           }
           static void yerleştir(int[][] dizi, cards[] card)
           {
               string[] isimler = new string[52];
               for (int i = 0; i < 52; i++)
               {
                   isimler[i] = (card[card[i].number - 1].cardname) + "" + (card[i].number);
                   Console.WriteLine(isimler[i]);
               }
               for (int i = 0; i < 52; i++)
               {
                   //Console.WriteLine(card[i].sonisim);
               }
           }
       }
   }
//
   namespace program
   {
       class oyuncular
       {
           public string oyuncu1;
           public string oyuncu2;
       }
       class program
       {
           struct cards
           {
               public string cardname;
               public int number;
               public int rastgelesıra;
               public string sonisim;
           }
           static void Main(string[] args)
           {
               oyuncular[] oyuncu = new oyuncular[5];
               int sayaç = 0, kardsıfırlayıcı = 0, tür_için = 1;
               int[] geç = new int[52];
               bool[] kontrol = new bool[52];
               cards[] card = new cards[52];
               int[][] dizi = new int[4][];
               dizi[0] = new int[13];
               dizi[1] = new int[13];
               dizi[2] = new int[13];
               dizi[3] = new int[13];
               Random r = new Random();
               string[] dizi2 = { "maça","sinek","kupa","karo" };
               int[, ] dizirandom = new int[4, 13];
               for (int i = 0; i < 52; i++)
               {
                   card[i].cardname = dizi2[i / 13];
               }
               for (int i = 0; i < 52; i++)
               {
                   int yeniSayi;
                   do
                   {
                       yeniSayi = r.Next(1, 53);
                   } while (kontrol[yeniSayi - 1]);
                   geç[i] = yeniSayi;
                   kontrol[yeniSayi - 1] = true;
               }
               for (int i = 0; i < 52; i++)
               {
                   card[i].number = geç[i];
               }
               yerleştir(dizi, card, oyuncu);
           }
           static void yerleştir(int[][] dizi, cards[] card, oyuncular[] oyuncu)
           {
               for (int i = 0; i < oyuncu.Length; i++)
               {
                   oyuncu[i] = new oyuncular();
               }
               string[] isimler = new string[52];
               for (int i = 0; i < 52; i++)
               {
                   isimler[i] = (card[card[i].number - 1].cardname) + "" + (card[i].number);
                   card[i].sonisim = isimler[i];
               }
               for (int i = 0; i < 52; i++)
               {
                   // Console.WriteLine(card[i].sonisim);
               }
               Random r = new Random();
               for (int i = 0; i < 5; i++)
               {
                   int geç = r.Next(1, 52);
                   int geç2 = r.Next(1, 52);
                   oyuncu[i].oyuncu1 = card[geç].sonisim;
                   oyuncu[i].oyuncu2 = card[geç2].sonisim;
               }
               for (int i = 0; i < 5; i++)
               {
                   Console.WriteLine("oyuncu1 " + oyuncu[i].oyuncu1);

               }
               Console.WriteLine(" ");
               for (int i = 0; i < 5; i++)
               {

                   Console.WriteLine("oyuncu2 " + oyuncu[i].oyuncu2);
               }
           }
       }
   }
//
   namespace program
   {
       class program
       {
           struct zaman
           {
               public int gün;
               public int ay;
               public int yıl;
           }

           static void Main(string[] args)
           {
               zaman zaman1 = new zaman();
               zaman zaman2 = new zaman();

               try
               {
                   Console.WriteLine("Lütfen 1. yılı giriniz");
                   zaman1.yıl = Convert.ToInt32(Console.ReadLine());

                   Console.WriteLine("Lütfen 2. yılı giriniz");
                   zaman2.yıl = Convert.ToInt32(Console.ReadLine());

                   Console.WriteLine("Lütfen 1. ayı giriniz");
                   zaman1.ay = Convert.ToInt32(Console.ReadLine());

                   Console.WriteLine("Lütfen 2. ayı giriniz");
                   zaman2.ay = Convert.ToInt32(Console.ReadLine());

                   Console.WriteLine("Lütfen 1. günü giriniz");
                   zaman1.gün = Convert.ToInt32(Console.ReadLine());

                   Console.WriteLine("Lütfen 2. günü giriniz");
                   zaman2.gün = Convert.ToInt32(Console.ReadLine());

                   // Toplam gün sayısını hesapla
                   int toplamGün1 = zaman1.yıl * 365 + zaman1.ay * 31 + zaman1.gün;
                   int toplamGün2 = zaman2.yıl * 365 + zaman2.ay * 31 + zaman2.gün;

                   Console.WriteLine("1. zamanın toplam gün sayısı: " + toplamGün1);
                   Console.WriteLine("2. zamanın toplam gün sayısı: " + toplamGün2);
               }
               catch (Exception ex)
               {
                   Console.WriteLine($"{ex.Message}");
               }
           }
       }
   }
