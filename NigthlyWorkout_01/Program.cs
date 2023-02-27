internal class Program
{
    private static void Main(string[] args)
    {
        /*Erkeklerin 25 yıl, kadınların da 20 yıl çalıştıktan sonra emekli olacağı varsayılan bir ortamda, klavyeden girilen cinsiyet ve sigorta prim gün sayısına göre kişinin emekliliğine ne kadar süresi kaldığını bulan metodunu yazınız.
 
            Açıklama:
            1 yıl = 360 gün
            1 ay = 30 gün
            Baz alınacaktır.


            Örnek: 1943 gün = 5 yıl 4 ay 23 gün

            Bu örnekteki metoda cinsiyet parametresi de ekleyerek, buna göre sonucu ekrana yazdırınız.

            Örnek: Erkek ve 6643 gün parametreleri girildiğinde "Emekliliğinize 6 yıl 6 ay 17 gün kaldı" şeklinde sonuç döndürecek.*/
        

        Emeklilik();


        Console.ReadKey();
    }
    
    public static int Emeklilik()
    {

        Console.WriteLine("********** Emeklilik Hesaplama **********\n");

        Console.Write("Çalıştığınız toplam gün sayısını giriniz: ");
        int gunCalisma = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nCinsiyet bilgisi giriniz (K/E) :");
        string cinsiyet = Convert.ToString(Console.ReadLine());

        int yil = 0, gun = 0, ay = 0;
        const int emeklilikKadin = 20 * 360;
        const int emelilikErkek = 25 * 360;


        int emeklilik = 0;

        if(cinsiyet=="K" || cinsiyet == "k")
        {
            if (gunCalisma < emeklilikKadin)
            {
                emeklilik= emeklilikKadin-gunCalisma;
                yil = emeklilik / 360;
                ay = (emeklilik % 360) / 30;
                gun = emeklilik % 30;

                Console.WriteLine("\nEmekliliğinize {0} yıl {1} ay {2} gün kalmıştır...", yil, gun, ay);


            }
            else if(gunCalisma>emeklilikKadin) {

                Console.WriteLine("\nEmeklilik gününüzü doldurdunuz... ");
            }



        }
        else if(cinsiyet == "E" || cinsiyet == "e")
        {
            if (gunCalisma < emelilikErkek)
            {
                emeklilik = emelilikErkek - gunCalisma;
                yil = emeklilik / 360;
                ay = (emeklilik % 360) / 30;
                gun = emeklilik % 30;

                Console.WriteLine("\nEmekliliğinize {0} yıl {1} ay {2} gün kalmıştır...", yil, gun, ay);


            }
            else if (gunCalisma > emelilikErkek)
            {

                Console.WriteLine("\nEmeklilik gününüzü doldurdunuz... ");
            }


            
        }

        return emeklilik;
    }
}