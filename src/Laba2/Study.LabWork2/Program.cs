using Study.LabWork2.Feature.Task1.SubTask2;
using System;
using System.IO;

namespace Study.LabWork2;

public static class Program
{
    public static void Main(string[] args)
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
}
