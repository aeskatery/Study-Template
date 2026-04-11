using Study.LabWork1.Features.Task1;
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
    public void RunTask2() => throw new NotImplementedException();

    /// <summary>
    /// Задание 3
    /// </summary>
    public void RunTask3() => throw new NotImplementedException();
}
