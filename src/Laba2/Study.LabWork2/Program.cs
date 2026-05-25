using System;
using System.IO;
using Study.LabWork2.Feature.Task1.SubTask1;
using Study.LabWork2.Feature.Task1.SubTask2;

namespace Study.LabWork2;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== ЛАБОРАТОРНАЯ РАБОТА 2 ===\n");

        RunTask12();
        RunTask11();

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    static void RunTask12()
    {
        string filePath = "numbers.txt";

        if (!File.Exists(filePath))
        {
            NumberSetProcessor.GenerateDataFile(filePath);
            Console.WriteLine("Файл с наборами чисел создан.\n");
        }

        int maxThreads = 3;

        NumberSetProcessor processor =
            new NumberSetProcessor(filePath, maxThreads);

        processor.ProcessSets();

        Console.WriteLine("Результаты обработки:\n");

        foreach (string result in processor.Results)
        {
            Console.WriteLine(result);
        }

        Console.WriteLine();
        Console.WriteLine($"Общий итог: {processor.TotalSum}");
        Console.WriteLine($"Время выполнения: {processor.ExecutionTimeMs} мс");
    }

    static void RunTask11()
    {
        Console.WriteLine("\nЗадание 1.1 — Синхронизация потоков\n");

        Console.WriteLine("Запуск версии с Monitor...");
        MonitorService.Run();

        Console.WriteLine("Запуск версии с Mutex...");
        MutexService.Run();

        Console.WriteLine("Запуск версии с Semaphore...");
        SemaphoreService.Run();

        Console.WriteLine("\nЗадание 1.1 успешно завершено");
    }
}