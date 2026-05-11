using System.Diagnostics;
using System;
using Study.LabWork2.Abstractions.Feature.Task1.SubTask1;
using Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels;

namespace Study.LabWork2.Feature.Task1.SubTask1;

/// <summary>
/// Версия 1. Использует Monitor (lock) для синхронизации
/// </summary>
public class MonitorService
{
    private static readonly object _locker = new();
    private static int _primeCount = 0;
    private const int MaxNumber = 10000;
    private const int ThreadCount = 8;

    public static void Run()
    {
        Console.WriteLine("=== Версия 1: Monitor ===");
        var stopwatch = Stopwatch.StartNew();
        _primeCount = 0;

        var threads = new Thread[ThreadCount];
        int rangeSize = MaxNumber / ThreadCount;

        for (int i = 0; i < ThreadCount; i++)
        {
            int start = i * rangeSize + 1;
            int end = (i == ThreadCount - 1) ? MaxNumber : (i + 1) * rangeSize;
            int threadId = i + 1;

            threads[i] = new Thread(() => CountPrimes(start, end, threadId));
            threads[i].Start();
        }

        foreach (var t in threads) t.Join();

        stopwatch.Stop();
        Console.WriteLine($"Общее количество простых чисел: {_primeCount}");
        Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс\n");
    }

    private static void CountPrimes(int start, int end, int threadId)
    {
        for (int num = start; num <= end; num++)
        {
            if (IsPrime(num))
            {
                lock (_locker)
                {
                    _primeCount++;
                    Console.WriteLine($"Поток {threadId} нашёл простое число: {num}");
                }
            }
        }
    }

    public static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n <= 3) return true;
        if (n % 2 == 0 || n % 3 == 0) return false;

        for (int i = 5; i * i <= n; i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0) return false;
        }
        return true;
    }
}
