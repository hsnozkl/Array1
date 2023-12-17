namespace Array1;

class Program
{
    static void Main(string[] args)
    {
        //Dizi Tanimlama
        string[] renkler = new string[5];

        string[] hayvanlar = {"Kedi","Kus","Maymun"};
        int[] dizi;
        dizi = new int[5];

        //Dizilere deger atama ve erisim
        renkler[0] = "Mavi";
        dizi[3] = 10;
        Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);

        //Dongolerle dizi
        //Klavyeden girilen n tane sayinin ortalamasini hesaplayin.
        Console.WriteLine("Lutfen dizinin eleman sayisini giriniz!");
        int diziUzunlugu = int.Parse(Console.ReadLine());
        int[] sayiDizisi = new int[diziUzunlugu];
        for (int i = 0; i < diziUzunlugu; i++)
        {
            Console.Write("Lutfen {0}. sayiyi giriniz: ", i + 1);
            sayiDizisi[i] = int.Parse(Console.ReadLine());
        }
        int toplam = 0;
        foreach (var sayi in sayiDizisi)
        {
            toplam += sayi;
        }
        Console.WriteLine("Ortalma :" + toplam / diziUzunlugu);
    }
}
