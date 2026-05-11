using System;
using Study.LabWork2.Feature.Task1.SubTask1;

namespace Study.LabWork2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== ЛАБОРАТОРНАЯ РАБОТА 2 ===\n");
        Console.WriteLine("Задание 1.1 — Синхронизация потоков\n");

        Console.WriteLine("Запуск версии с Monitor...");
        MonitorService.Run();

        Console.WriteLine("Запуск версии с Mutex...");
        MutexService.Run();

        Console.WriteLine("Запуск версии с Semaphore...");
        SemaphoreService.Run();

        Console.WriteLine("\n=== Задание 1.1 успешно завершено ===");
        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
