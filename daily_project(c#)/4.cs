//klasör oluşturma
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("oluşturulacak dosyanın ismini girini");
        //string yol = Console.ReadLine() ; klasör için kullanılır
        string yol = Console.ReadLine() + ".txt";//txt klasörde sil
        if (File.Exists(yol) != true)// yoksa bir tane daha oluştur
        {
            //Directory.CreateDirectory(yol); klasör oluşturulken kullanılır
            File.Create(yol);
            Console.WriteLine("dosya oluşturuldu");
        }
        else
        {
            Console.WriteLine("zaten klasör var");
        }
    }
}

// içine klavyeden girdiklerini kaydediyor
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("oluşturulacak dosyanın ismini girini");
        //string yol = Console.ReadLine() ; klasör için kullanılır
        string yol = Console.ReadLine() + ".txt";//txt klasörde sil
        if (File.Exists(yol) != true)// yoksa bir tane daha oluştur
        {

            File.Create(yol).Close(); // Dosyayı oluştur ve kapat
            Console.WriteLine("Dosya oluşturuldu. Lütfen içeriği girin:");
            string icerik = Console.ReadLine();
            File.WriteAllText(yol, icerik);
        }
        else
        {
            Console.WriteLine("zaten klasör var");
        }
    }
}

