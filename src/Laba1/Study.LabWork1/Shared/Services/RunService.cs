using Study.LabWork1.Features.Task2;
using Study.LabWork1.Shared.Abstractions;

namespace Study.LabWork1.Shared.Services;

/// <summary>
/// Реализация заданий Л/Р
/// </summary>
public class RunService : IRunService
{
    /// <summary>
    /// Задание 1
    /// </summary>
    public void RunTask1()
    {
        var p1 = new RGBA(100, 150, 200, 0.5f);
        var p2 = new RGBA(50, 100, 100, 0.3f);

        var sum = p1 + p2;
        var diff = p1 - p2;
        var multScalar = p1 * 2;
        var multPixel = p1 * p2;

        Console.WriteLine($"p1: {p1}");
        Console.WriteLine($"p2: {p2}");
        Console.WriteLine();

        Console.WriteLine($"Сложение: {sum}");
        Console.WriteLine($"Вычитание: {diff}");
        Console.WriteLine($"Умножение на число: {multScalar}");
        Console.WriteLine($"Умножение пикселей: {multPixel}");
        Console.WriteLine();

        Console.WriteLine($"HEX p1: {p1.ToHex()}");
        Console.WriteLine($"p1 == p2: {p1 == p2}");
        Console.WriteLine();
    }

    /// <summary>
    /// Задание 2
    /// </summary>
    public void RunTask2()
    {
        Console.WriteLine("=== Задание 2: Паттерн Adapter + Port ===\n");

        // 1. In-Memory репозиторий (каждый раз начинается с чистого листа)
        Console.WriteLine("1. InMemoryOrderRepository (хранение в памяти):");
        IOrderRepository repo = new InMemoryOrderRepository();

        repo.Add(new Order { CustomerName = "Иван Иванов", TotalAmount = 1250.50m });
        repo.Add(new Order { CustomerName = "Александр Воробьев", TotalAmount = 890.00m });

        foreach (var order in repo.GetAll())
            Console.WriteLine($"   {order}");

        repo.Save();
        Console.WriteLine();

        // 2. CSV репозиторий — очищаем файл перед демонстрацией
        Console.WriteLine("2. CsvOrderRepository (хранение в CSV-файле):");

        string testFile = "orders_demo.csv";                    // отдельный файл для демонстрации
        if (File.Exists(testFile))
            File.Delete(testFile);                              // ← очищаем файл

        repo = new CsvOrderRepository(testFile);

        repo.Add(new Order { CustomerName = "Мария Буш", TotalAmount = 3450.75m });
        repo.Add(new Order { CustomerName = "Ольга Смирнова", TotalAmount = 670.25m });

        foreach (var order in repo.GetAll())
            Console.WriteLine($"   {order}");

        repo.Save();

        Console.WriteLine("\nЗадание 2 выполнено.");
        Console.WriteLine("Клиентский код работает только через интерфейс IOrderRepository.");
    }

    /// <summary>
    /// Задание 3
    /// </summary>
    public void RunTask3() => throw new NotImplementedException();
}
