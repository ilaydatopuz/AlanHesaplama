using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Geometrik şekli seçin (Daire, Üçgen, Kare, Dikdörtgen):");
        string shape = Console.ReadLine();

        switch (shape.ToLower())
        {
            case "daire":
                CalculateDaire();
                break;
            case "üçgen":
                CalculateUcgen();
                break;
            case "kare":
                CalculateKare();
                break;
            case "dikdörtgen":
                CalculateDikdortgen();
                break;
            default:
                Console.WriteLine("Geçersiz geometrik şekil.");
                break;
        }
    }

    static void CalculateDaire()
    {
        Console.Write("Dairenin yarıçapını girin: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double alan = Math.PI * radius * radius;
        double cevre = 2 * Math.PI * radius;

        Console.WriteLine("Dairenin Alanı: " + alan);
        Console.WriteLine("Dairenin Çevresi: " + cevre);
    }

    static void CalculateUcgen()
    {
        Console.Write("Üçgenin taban uzunluğunu girin: ");
        double baseLength = Convert.ToDouble(Console.ReadLine());

        Console.Write("Üçgenin yüksekliğini girin: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double alan = (baseLength * height) / 2;
        Console.WriteLine("Üçgenin Alanı: " + alan);
    }

    static void CalculateKare()
    {
        Console.Write("Karenin kenar uzunluğunu girin: ");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        double alan = sideLength * sideLength;
        double cevre = 4 * sideLength;

        Console.WriteLine("Karenin Alanı: " + alan);
        Console.WriteLine("Karenin Çevresi: " + cevre);
    }

    static void CalculateDikdortgen()
    {
        Console.Write("Dikdörtgenin uzun kenar uzunluğunu girin: ");
        double uzunKenar = Convert.ToDouble(Console.ReadLine());

        Console.Write("Dikdörtgenin kısa kenar uzunluğunu girin: ");
        double kisaKenar = Convert.ToDouble(Console.ReadLine());

        double alan = uzunKenar * kisaKenar;
        double cevre = 2 * (uzunKenar + kisaKenar);

        Console.WriteLine("Dikdörtgenin Alanı: " + alan);
        Console.WriteLine("Dikdörtgenin Çevresi: " + cevre);
    }
}

