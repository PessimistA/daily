//random
static void Main(string[] args)
{
    int sayı;
    char[] dizi = { 'a', 'A', 'b', 'B', 'c', 'C', 'd', 'D', 'e', 'E', 'f', 'F', 'g', 'G', 'h', 'H', 'X', 'x', 'Z', 'z', 'w', 'W', 'r', 'R', 't', 'T', 'y', 'Y' };
    char[] şifre = new char[7];
    Random rnd = new Random();
    for (int i = 0; i < 7; i++)
    {
        sayı = rnd.Next(0, 28);
        şifre[i] = dizi[sayı];
    }

    for (int i = 0; i < 7; i++)
    {
        Console.WriteLine("{0}. sayı {1}", i + 1, şifre[i]);//alt alta
    }
    Console.WriteLine(şifre);//yan yana yazılmış hali
}
//random sayılarla işlemler
static void Main(string[] args)
{
    int toplam = 0, sayı = 0;
    int[] dizi = new int[10];
    Random ran = new Random();
    for (int i = 0; i < 10; i++)
    {
        dizi[i] = ran.Next(1, 1000);
    }
    for (int i = 0; i < 10; i++)
    {
        if (dizi[i] > 499 && dizi[i] < 601)
        {
            toplam = toplam + dizi[i];
        }
        if (dizi[i] > 99 && dizi[i] < 501)
        {
            sayı++;
        }
    }
    Console.WriteLine("toplam{0}", toplam);
    Console.WriteLine("sayı{0}", sayı);
}
//şifre üretmek
class Program
{
    static void Main(string[] args)
    {
        char[] dizi = { 'A', 'b', 'a', '1', '3', '4', '5', '6' };
        string birarada = " ";
        Random rnd = new Random();
        for (int i = 0; i < 4; i++)
        {
            int sayı = rnd.Next(0, 6);
            birarada = dizi[sayı] + birarada;
        }
        Console.WriteLine(birarada);
    }
}
//binary çevirici
static void Main(string[] args)
{
    int sayı, a, b = 0;
    string dizisi = "";
    sayı = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < sayı; i++)
    {
        b = sayı % 2;
        a = sayı / 2;
        sayı = a;
        dizisi = b + dizisi;
    }
    dizisi = 1 + dizisi;
    Console.WriteLine(dizisi);
}

// sıralama
static void Main(string[] args)
{
    int sayı, max = 0, b = 0, mim = 0, geç;
    int[] dizisi = new int[10];
    int[] dizisisıralama = new int[5];
    while (b < 5)
    {
        Console.WriteLine("sayı giriniz");
        sayı = Convert.ToInt32(Console.ReadLine());
        dizisi[b] = sayı;
        b++;
    }
    for (int i = 0; i < b; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            if (dizisi[i] > dizisi[j])// işarete bağlı büyüktür işaretinde büyükten küçşüğe küçüktürde küçükten büyüğe sıralanır
            {
                mim = dizisi[j];
                geç = dizisi[i];
                dizisi[i] = dizisi[j];
                dizisi[j] = geç;
            }
        }
    }
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(dizisi[i]);
    }
}