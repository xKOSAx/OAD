using System;

namespace Rabaty
{
    // Interfejs
    interface IRabat
    {
        double Oblicz(double kwota);
    }

    // Brak rabatu
    class BrakRabatu : IRabat
    {
        public double Oblicz(double kwota)
        {
            return kwota;
        }
    }

    // Rabat procentowy
    class RabatProcentowy : IRabat
    {
        private double procent;

        public RabatProcentowy(double procent)
        {
            this.procent = procent;
        }

        public double Oblicz(double kwota)
        {
            return kwota - (kwota * procent / 100);
        }
    }

    // Rabat stały
    class RabatStaly : IRabat
    {
        private double kwotaRabatu;

        public RabatStaly(double kwotaRabatu)
        {
            this.kwotaRabatu = kwotaRabatu;
        }

        public double Oblicz(double kwota)
        {
            double wynik = kwota - kwotaRabatu;

            if (wynik < 0)
            {
                return 0;
            }

            return wynik;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double cena = PobierzCene();

            WyswietlMenu();

            int wybor = PobierzWybor();

            IRabat rabat = WybierzRabat(wybor);

            double nowaCena = rabat.Oblicz(cena);

            if (nowaCena < 0)
            {
                nowaCena = 0;
            }

            WyswietlWynik(nowaCena);
        }

        // Pobieranie ceny
        static double PobierzCene()
        {
            double cena;

            while (true)
            {
                Console.Write("Podaj cenę produktu: ");

                if (double.TryParse(Console.ReadLine(), out cena) && cena >= 0)
                {
                    return cena;
                }

                Console.WriteLine("Błędna wartość. Spróbuj ponownie.");
            }
        }

        // Wyświetlanie menu
        static void WyswietlMenu()
        {
            Console.WriteLine("\nWybierz rodzaj rabatu:");
            Console.WriteLine("1 - Brak rabatu");
            Console.WriteLine("2 - Rabat 10%");
            Console.WriteLine("3 - Rabat 20 zł");
        }

        // Pobieranie wyboru
        static int PobierzWybor()
        {
            int wybor;

            while (true)
            {
                Console.Write("Twój wybór: ");

                if (int.TryParse(Console.ReadLine(), out wybor) &&
                    wybor >= 1 && wybor <= 3)
                {
                    return wybor;
                }

                Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");
            }
        }

        // Wybór odpowiedniego rabatu
        static IRabat WybierzRabat(int wybor)
        {
            switch (wybor)
            {
                case 1:
                    return new BrakRabatu();

                case 2:
                    return new RabatProcentowy(10);

                case 3:
                    return new RabatStaly(20);

                default:
                    return new BrakRabatu();
            }
        }

        // Wyświetlenie wyniku
        static void WyswietlWynik(double wynik)
        {
            Console.WriteLine($"\nCena po rabacie: {wynik} zł");
        }
    }
}