// çalışmıyor tekrar dene
class program
{
    struct unite7
    {
        public string ingkelime;
        public string türkkelime;

    }
    struct unite8
    {
        public string ingkelime;
        public string türkkelime;
    }
    struct unite9
    {
        public string ingkelime;
        public string türkkelime;
    }
    static void Main(string[] args)
    {
        unite7[] u7 = new unite7[50];
        unite8[] u8 = new unite8[50];
        unite9[] u9 = new unite9[50];
        int seçim1, seçim2, sayaç1 = 0, sayaç2 = 0, sayaç3 = 0;
        Console.WriteLine("7. unite için 7 ye basınız");
        Console.WriteLine("8. ünite için 8 e basınız");
        Console.WriteLine("9. ünite için 9 a basınız");
        seçim1 = Convert.ToInt32(Console.ReadLine());
        if (seçim1 == 7)
        {

            Console.WriteLine("kelime eklemek için 1 e basınız");
            Console.WriteLine("kelimenin anlamını öğrenmek için 2 ye basınız");
            Console.WriteLine("çıkış yapmak için 0 a basınız");
            seçim2 = Convert.ToInt32(Console.ReadLine());

            if (seçim2 == 1)
            {
                seçimfonk1(u7[sayaç1].ingkelime, u7[sayaç1].türkkelime);
            }
            if (seçim2 == 2)
            {
                seçimfonk2(u7[sayaç1].ingkelime, u7[sayaç1].türkkelime, sayaç1, u7, u8, u9);
            }
            if (seçim2 == 0)
            {
                Console.WriteLine("görüşmek üzere");
            }
            while (true)
            {
                Console.WriteLine("7. unite için 7 ye basınız");
                Console.WriteLine("8. ünite için 8 e basınız");
                Console.WriteLine("9. ünite için 9 a basınız");
                seçim1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("kelime eklemek için 1 e basınız");
                Console.WriteLine("kelimenin anlamını öğrenmek için 2 ye basınız");
                Console.WriteLine("çıkış yapmak için 0 a basınız");
                seçim2 = Convert.ToInt32(Console.ReadLine());

                if (seçim2 == 1)
                {
                    seçimfonk1(u7[sayaç1].ingkelime, u7[sayaç1].türkkelime);
                }
                if (seçim2 == 2)
                {
                    seçimfonk2(u7[sayaç1].ingkelime, u7[sayaç1].türkkelime, sayaç1, u7, u8, u9);
                }
                if (seçim2 == 0)
                {
                    Console.WriteLine("görüşmek üzere");
                    break;
                }
            }
            sayaç1++;
        }
        if (seçim1 == 8)
        {
            Console.WriteLine("7. unite için 7 ye basınız");
            Console.WriteLine("8. ünite için 8 e basınız");
            Console.WriteLine("9. ünite için 9 a basınız");
            seçim1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kelime eklemek için 1 e basınız");
            Console.WriteLine("kelimenin anlamını öğrenmek için 2 ye basınız");
            Console.WriteLine("çıkış yapmak için 0 a basınız");
            seçim2 = Convert.ToInt32(Console.ReadLine());

            if (seçim2 == 1)
            {
                seçimfonk1(u8[sayaç2].ingkelime, u8[sayaç2].türkkelime);
            }
            if (seçim2 == 2)
            {
                seçimfonk2(u8[sayaç2].ingkelime, u8[sayaç2].türkkelime, sayaç2, u7, u8, u9);
            }
            if (seçim2 == 0)
            {
                Console.WriteLine("görüşmek üzere");

            }
            while (true)
            {
                Console.WriteLine("7. unite için 7 ye basınız");
                Console.WriteLine("8. ünite için 8 e basınız");
                Console.WriteLine("9. ünite için 9 a basınız");
                seçim1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("kelime eklemek için 1 e basınız");
                Console.WriteLine("kelimenin anlamını öğrenmek için 2 ye basınız");
                Console.WriteLine("çıkış yapmak için 0 a basınız");
                seçim2 = Convert.ToInt32(Console.ReadLine());

                if (seçim2 == 1)
                {
                    seçimfonk1(u8[sayaç2].ingkelime, u8[sayaç2].türkkelime);
                }
                if (seçim2 == 2)
                {
                    seçimfonk2(u8[sayaç2].ingkelime, u8[sayaç2].türkkelime, sayaç2, u7, u8, u9);
                }
                if (seçim2 == 0)
                {
                    Console.WriteLine("görüşmek üzere");
                    break;
                }
            }
            sayaç2++;
        }
        if (seçim1 == 9)
        {
            Console.WriteLine("7. unite için 7 ye basınız");
            Console.WriteLine("8. ünite için 8 e basınız");
            Console.WriteLine("9. ünite için 9 a basınız");
            seçim1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kelime eklemek için 1 e basınız");
            Console.WriteLine("kelimenin anlamını öğrenmek için 2 ye basınız");
            Console.WriteLine("çıkış yapmak için 0 a basınız");
            seçim2 = Convert.ToInt32(Console.ReadLine());

            if (seçim2 == 1)
            {
                seçimfonk1(u8[sayaç2].ingkelime, u8[sayaç2].türkkelime);
            }
            if (seçim2 == 2)
            {
                seçimfonk2(u8[sayaç2].ingkelime, u8[sayaç2].türkkelime, sayaç2, u7, u8, u9);
            }
            if (seçim2 == 0)
            {
                Console.WriteLine("görüşmek üzere");

            }
            while (true)
            {
                Console.WriteLine("7. unite için 7 ye basınız");
                Console.WriteLine("8. ünite için 8 e basınız");
                Console.WriteLine("9. ünite için 9 a basınız");
                seçim1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("kelime eklemek için 1 e basınız");
                Console.WriteLine("kelimenin anlamını öğrenmek için 2 ye basınız");
                Console.WriteLine("çıkış yapmak için 0 a basınız");
                seçim2 = Convert.ToInt32(Console.ReadLine());

                if (seçim2 == 1)
                {
                    seçimfonk1(u9[sayaç3].ingkelime, u9[sayaç3].türkkelime);
                }
                if (seçim2 == 2)
                {
                    seçimfonk2(u9[sayaç3].ingkelime, u9[sayaç3].türkkelime, sayaç3, u7, u8, u9);
                }
                if (seçim2 == 0)
                {
                    Console.WriteLine("görüşmek üzere");
                    break;
                }
            }
            sayaç3++;
        }
        while (true)
        {
            Console.WriteLine("7. unite için 7 ye basınız");
            Console.WriteLine("8. ünite için 8 e basınız");
            Console.WriteLine("9. ünite için 9 a basınız");
            seçim1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("7. unite için 7 ye basınız");
            Console.WriteLine("8. ünite için 8 e basınız");
            Console.WriteLine("9. ünite için 9 a basınız");
            seçim1 = Convert.ToInt32(Console.ReadLine());
            if (seçim1 == 7)
            {
                Console.WriteLine("7. unite için 7 ye basınız");
                Console.WriteLine("8. ünite için 8 e basınız");
                Console.WriteLine("9. ünite için 9 a basınız");
                seçim1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("kelime eklemek için 1 e basınız");
                Console.WriteLine("kelimenin anlamını öğrenmek için 2 ye basınız");
                Console.WriteLine("çıkış yapmak için 0 a basınız");
                seçim2 = Convert.ToInt32(Console.ReadLine());

                if (seçim2 == 1)
                {
                    seçimfonk1(u7[sayaç1].ingkelime, u7[sayaç1].türkkelime);
                }
                if (seçim2 == 2)
                {
                    seçimfonk2(u7[sayaç1].ingkelime, u7[sayaç1].türkkelime, sayaç1, u7, u8, u9);
                }
                if (seçim2 == 0)
                {
                    Console.WriteLine("görüşmek üzere");
                }
                while (true)
                {
                    Console.WriteLine("7. unite için 7 ye basınız");
                    Console.WriteLine("8. ünite için 8 e basınız");
                    Console.WriteLine("9. ünite için 9 a basınız");
                    seçim1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("kelime eklemek için 1 e basınız");
                    Console.WriteLine("kelimenin anlamını öğrenmek için 2 ye basınız");
                    Console.WriteLine("çıkış yapmak için 0 a basınız");
                    seçim2 = Convert.ToInt32(Console.ReadLine());

                    if (seçim2 == 1)
                    {
                        seçimfonk1(u7[sayaç1].ingkelime, u7[sayaç1].türkkelime);
                    }
                    if (seçim2 == 2)
                    {
                        seçimfonk2(u7[sayaç1].ingkelime, u7[sayaç1].türkkelime, sayaç1, u7, u8, u9);
                    }
                    if (seçim2 == 0)
                    {
                        Console.WriteLine("görüşmek üzere");
                        break;
                    }
                }
                sayaç1++;
            }
            if (seçim1 == 8)
            {
                Console.WriteLine("7. unite için 7 ye basınız");
                Console.WriteLine("8. ünite için 8 e basınız");
                Console.WriteLine("9. ünite için 9 a basınız");
                seçim1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("kelime eklemek için 1 e basınız");
                Console.WriteLine("kelimenin anlamını öğrenmek için 2 ye basınız");
                Console.WriteLine("çıkış yapmak için 0 a basınız");
                seçim2 = Convert.ToInt32(Console.ReadLine());

                if (seçim2 == 1)
                {
                    seçimfonk1(u8[sayaç2].ingkelime, u8[sayaç2].türkkelime);
                }
                if (seçim2 == 2)
                {
                    seçimfonk2(u8[sayaç2].ingkelime, u8[sayaç2].türkkelime, sayaç2, u7, u8, u9);
                }
                if (seçim2 == 0)
                {
                    Console.WriteLine("görüşmek üzere");

                }
                while (true)
                {
                    Console.WriteLine("7. unite için 7 ye basınız");
                    Console.WriteLine("8. ünite için 8 e basınız");
                    Console.WriteLine("9. ünite için 9 a basınız");
                    seçim1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("kelime eklemek için 1 e basınız");
                    Console.WriteLine("kelimenin anlamını öğrenmek için 2 ye basınız");
                    Console.WriteLine("çıkış yapmak için 0 a basınız");
                    seçim2 = Convert.ToInt32(Console.ReadLine());

                    if (seçim2 == 1)
                    {
                        seçimfonk1(u8[sayaç2].ingkelime, u8[sayaç2].türkkelime);
                    }
                    if (seçim2 == 2)
                    {
                        seçimfonk2(u8[sayaç2].ingkelime, u8[sayaç2].türkkelime, sayaç2, u7, u8, u9);
                    }
                    if (seçim2 == 0)
                    {
                        Console.WriteLine("görüşmek üzere");
                        break;
                    }
                }
                sayaç2++;
            }
            if (seçim1 == 9)
            {
                Console.WriteLine("7. unite için 7 ye basınız");
                Console.WriteLine("8. ünite için 8 e basınız");
                Console.WriteLine("9. ünite için 9 a basınız");
                seçim1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("kelime eklemek için 1 e basınız");
                Console.WriteLine("kelimenin anlamını öğrenmek için 2 ye basınız");
                Console.WriteLine("çıkış yapmak için 0 a basınız");
                seçim2 = Convert.ToInt32(Console.ReadLine());

                if (seçim2 == 1)
                {
                    seçimfonk1(u8[sayaç2].ingkelime, u8[sayaç2].türkkelime);
                }
                if (seçim2 == 2)
                {
                    seçimfonk2(u8[sayaç2].ingkelime, u8[sayaç2].türkkelime, sayaç2, u7, u8, u9);
                }
                if (seçim2 == 0)
                {
                    Console.WriteLine("görüşmek üzere");

                }
                while (true)
                {
                    Console.WriteLine("7. unite için 7 ye basınız");
                    Console.WriteLine("8. ünite için 8 e basınız");
                    Console.WriteLine("9. ünite için 9 a basınız");
                    seçim1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("kelime eklemek için 1 e basınız");
                    Console.WriteLine("kelimenin anlamını öğrenmek için 2 ye basınız");
                    Console.WriteLine("çıkış yapmak için 0 a basınız");
                    seçim2 = Convert.ToInt32(Console.ReadLine());

                    if (seçim2 == 1)
                    {
                        seçimfonk1(u9[sayaç3].ingkelime, u9[sayaç3].türkkelime);
                    }
                    if (seçim2 == 2)
                    {
                        seçimfonk2(u9[sayaç3].ingkelime, u9[sayaç3].türkkelime, sayaç3, u7, u8, u9);
                    }
                    if (seçim2 == 0)
                    {
                        Console.WriteLine("görüşmek üzere");
                        break;
                    }
                }
                sayaç3++;
            }
        }
    }
    static void seçimfonk1(string ing, string türk)
    {
        Console.WriteLine(" ingilizce lütfen kelimeyi giriniz");
        ing = Console.ReadLine();
        Console.WriteLine("lütfen türkçe anlamını giriniz");
        türk = Console.ReadLine();
    }
    static void seçimfonk2(string ing, string türk, int sayaç, unite7[] u7, unite8[] u8, unite9[] u9)
    {
        char seç;
        Console.WriteLine(" ingilizce kelime arıyorsanız (i) türkçe kelime arıyorsanız (t) yazınız");
        seç = Convert.ToChar(Console.ReadLine());
        if (seç == 'i')
        {
            string aranan;
            Console.WriteLine("lütfen aranan ingilizce kelimeyi giriniz");
            aranan = Console.ReadLine();
            for (global::System.Int32 i = 0; i < sayaç; i++)
            {
                if (aranan == u7[i].ingkelime)
                {
                    Console.WriteLine("{0} = {1}", u8[i].ingkelime, u8[i].türkkelime);
                }
                if (aranan == u8[i].ingkelime)
                {
                    Console.WriteLine($"{u8[i].ingkelime} = {u8[i].türkkelime}");
                }
                if (aranan == u9[i].ingkelime)
                {
                    Console.WriteLine($"{u9[i].ingkelime} = {u9[i].türkkelime}");
                }
            }
        }
        if (seç == 't')
        {
            string aranan;
            Console.WriteLine("lütfen aranan türkçe kelimeyi giriniz");
            aranan = Console.ReadLine();
            for (global::System.Int32 i = 0; i < sayaç; i++)
            {
                if (aranan == u7[i].türkkelime)
                {
                    Console.WriteLine($"{u7[i].türkkelime} = {u7[i].ingkelime}");
                }
                if (aranan == u8[i].türkkelime)
                {
                    Console.WriteLine($"{u8[i].türkkelime} = {u8[i].ingkelime}");
                }
                if (aranan == u9[i].türkkelime)
                {
                    Console.WriteLine($"{u9[i].türkkelime} = {u9[i].ingkelime}");
                }
            }

        }
    }
}