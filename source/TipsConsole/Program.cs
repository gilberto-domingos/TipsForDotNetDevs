using DataLib;

namespace TipsConsole;

internal class Program
{
    private static void Main(string[] args)
    {
        var examples = new Examples();
        examples.RunExample();

        var repo = new DataRepository();

        Console.WriteLine("=== CUSTOMERS ===");
        foreach (var customer in repo.Customers)
            Console.WriteLine(
                $"{customer.FirstName} {customer.LastName} - {customer.EmailAddress} - {customer.Company} - Desde {customer.CustomerSince}");

        Console.WriteLine("\n=== SONGS ===");
        foreach (var song in repo.Songs)
            Console.WriteLine($"{song.SongTitle} - {song.Genre} - {song.Artist} - {song.Label}");

        Console.WriteLine("\n=== PRODUCTS ===");
        foreach (var product in repo.Products)
            Console.WriteLine($"{product.Name} ({product.Color}) - {product.Description} - {product.Department}");
    }
}