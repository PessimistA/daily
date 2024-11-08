namespace program
{
    class MyClass
    {
        static void Main()
        {
            string metin = "rüzmaaaaar rüzmr rüzr Elma rüzlar rüzmar rüzGr rüzağacıcın altında otururken hafif bir rüzgar esti ve yapraklar hışırdadı. Etrafta kuşların cıvıltısı ve çimenlerin hışırtısı huzur vericiydi.";
            Regex rgx = new Regex(@"rüz.ar");
            foreach (Match matches in rgx.Matches(metin))
            {
                //string bu hali ="rüzmar Elma ağacıcın altında otururken hafif bir rüzgar esti ve yapraklar hışırdadı. Etrafta kuşların cıvıltısı ve çimenlerin hışırtısı huzur vericiydi.";
                Console.WriteLine("{0}->{1}", matches.ToString(), matches.Index);
                //bastığı şey rüzmar ->0
                //rüzgar -> 49
            }
            Regex rgx2 = new Regex(@"rüzm[a-z A-Z]r");// aralık verir [] işlevi budur
            foreach (Match matches in rgx2.Matches(metin))// sadece konulduğu yerdeki gelen ifade için yazılır
            {
                // metin = "rüzmaaaaar rüzmar Elma rüzlar rüzGr rüzağacıcın altında otururken hafif bir rüzgar esti ve yapraklar hışırdadı. Etrafta kuşların cıvıltısı ve çimenlerin hışırtısı huzur vericiydi.";
                Console.WriteLine("{0}->{1}", matches.ToString(), matches.Index);
                // rüzmar-> 11
            }
            Regex rgx3 = new Regex(@"rüzm?r");// kendisinden önceki var mı yok mu ona bakar
            foreach (Match matches in rgx3.Matches(metin))
            {
                // string metin = "rüzmaaaaar rüzmr rüzr Elma rüzlar rüzGr rüzağacıcın altında otururken hafif bir rüzgar esti ve yapraklar hışırdadı. Etrafta kuşların cıvıltısı ve çimenlerin hışırtısı huzur vericiydi.";
                Console.WriteLine("{0}->{1}", matches.ToString(), matches.Index);
                // rüzmr->11
                //rüzr->17
            }
            Regex rgx3 = new Regex(@"rüzma+r");// kendisinden önceki en az 1 tane ya da daha çok olacak
            foreach (Match matches in rgx3.Matches(metin))
            {
                // string metin = "rüzmaaaaar rüzmr rüzr Elma rüzlar rüzGr rüzağacıcın altında otururken hafif bir rüzgar esti ve yapraklar hışırdadı. Etrafta kuşların cıvıltısı ve çimenlerin hışırtısı huzur vericiydi.";
                Console.WriteLine("{0}->{1}", matches.ToString(), matches.Index);
                //rüzmaaaaar->0
            }
            Regex rgx3 = new Regex(@"rüzma*r");// kendisinden önceki hiç olmayacak  ya da daha çok olacak
            foreach (Match matches in rgx3.Matches(metin))
            {
                // string metin = "rüzmaaaaar rüzmr rüzr Elma rüzlar rüzmar rüzGr rüzağacıcın altında otururken hafif bir rüzgar esti ve yapraklar hışırdadı. Etrafta kuşların cıvıltısı ve çimenlerin hışırtısı huzur vericiydi.";
                Console.WriteLine("{0}->{1}", matches.ToString(), matches.Index);
                //rüzmaaaaar->0
                //rüzmr->11
                //rüzmar->34 // 1 tane olma durumu da var yani
            }
            “\” koyarak noktalama harfini kullanabilirsin
            { n}
            bir önceki harfin bu sayıda olmasını ister ya da { n,m}
            n ile m arasında olmasını ister
            "^" ile başında olmasını "$" ile de sonunda olmasını ifade eder
            \s Boşluk(whitespaces)
            /* ÖNEMLİ*/
             \S Boşluk dışındaki tüm karakterler
             \d 0 - 9 arasında rakamlar
             \D Sayısal olmayan karakterler
             \w Harfler, rakamlar veya altçizgi
             \W Harf, rakam veya altçizgi dışındaki tüm karakterler
            string metin2 = "Merhaba,\n\nGeçen hafta, support@example.com adresine gönderdiğim e-postaya henüz bir yanıt alamadım. Acil bir konu hakkında bilgi almam gerekiyor. Ayrıca, info@test-email.org adresine de bir e-posta gönderdim fakat oradan da geri dönüş yapılmadı.\n\nMüşteri hizmetleriyle iletişime geçmemin başka bir yolu var mı? Yardımcı olursanız çok sevinirim.\n\nTeşekkürler,\nAli";
            Regex rgx = new Regex(@"[a-zA-Z.-_0-9%+]+@[a-zA-Z0-9-]+\.[a-zA-Z]{2,}");
            foreach (Match found in rgx.Matches(metin2))
            {
                Console.WriteLine(found.Value);
            }
            string İletişim_bilgileri = "123 456 7890, 123 456 7890 veya 123 456 7890 ";
            Regex rgx = new Regex(@"(\d{3})\s(\d{3})\s(\d{4})");// aralarında boşluk olduğundan kolay
            foreach (Match found in rgx.Matches(İletişim_bilgileri))
            {
                Console.WriteLine(found.Value);
            }
            string İletişim_bilgileri = "123 456 7890, 123,456,7890 veya 123.456.7890 (123) 456 7890 ";
            Regex rgx = new Regex(@"(.\d{3}.)(\.||\s||,)(\d{3})(\.||\s||,)(\d{4})");
            foreach (Match found in rgx.Matches(İletişim_bilgileri))
            {
                Console.WriteLine(found.Value);
            }
            string url = 
                "C:\\Users\\Kullanıcı\\Belgeler\n" +
                "D:\\Program Files\\OpenAI\\ChatGPT\n" +
                "E:\\Resimler\\Vakit Geçirme\n" +
                "F:\\Müzik\\Yeni Albüm\n" +
                "C:\\Windows\\System32\n" +
                "D:\\Veri\\Projeler\\2024";
            Regex rgx = new Regex(@"([A-Z]:\\)([a-zA-Z])(\\)([a-zA-Z])(\\)([a-zA-Z])?(\\)?([a-zA-Z])?(\\)?([a-zA-Z])?");
            foreach (Match found in rgx.Matches(url))
            {
                Console.WriteLine(found.Value);
            }
        }
    }
}
