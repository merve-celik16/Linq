namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>sayilar=new List<int>() {-10,-5,-3,0,1,6,8,10,11,16 };

            Console.WriteLine("----------Çift Sayılar----------");
            var ciftSayilar = sayilar.Where(x => x % 2 == 0);
            foreach (var sayi in ciftSayilar)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("----------Tek Sayılar----------");
            var tekSayilar = sayilar.Where(x => x % 2 != 0);
            foreach (var sayi in tekSayilar)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("----------Negatif Sayılar----------");
            var negatifSayilar = sayilar.Where(x => x < 0);
            foreach (var sayi in negatifSayilar)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("----------Pozitif Sayılar----------");
            var pozitifSayilar = sayilar.Where(x => x > 0);
            foreach (var sayi in pozitifSayilar)
            {
                Console.WriteLine(sayi);
            }

            var sayi1 = sayilar.Where(x => x > 15 && x < 22);//  15'ten büyük ve 22'den küçük sayılar
            foreach (var sayi in sayi1)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("----------Sayıların Karesi----------");
            var karesi = sayilar.Select(x => x*x);
            foreach (var sayi in karesi)
            {
                Console.WriteLine(sayi);
            }

        }
    }
}
