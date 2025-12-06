using Sana04;

internal class Program
{
    private static void Main(string[] args)
    {
        MyDate start = new MyDate(2025, 12, 6, 12, 00);
        MyDate finish = new MyDate(2025, 12, 6, 15, 30);
        Airplane plane = new Airplane("Kyiv", "Paris", start, finish);
        Console.WriteLine("Час польоту в хвилинах: " + plane.GetTotalTime());
        Console.WriteLine("Прибуття у той самий день? " + plane.IsArrivingToday());
        Currency usd = new Currency("USD", 42);
        Product phone = new Product("Football boots", 1000, usd, 2, "NIKE", 0.3);
        Console.WriteLine("Ціна в гривнях: " + phone.GetPriceInUAH());
        Console.WriteLine("Загальна вартість у гривнях: " + phone.GetTotalPriceInUAH());
        Console.WriteLine("Загальна вага товарів: " + phone.GetTotalWeight());
    }
}
