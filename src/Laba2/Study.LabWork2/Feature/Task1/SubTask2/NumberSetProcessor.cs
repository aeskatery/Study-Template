using System.Diagnostics;
using Study.LabWork2.Abstractions.Feature.Task1.SubTask2;
using Study.LabWork2.Abstractions.Feature.Task1.SubTask2.DtoModels;

namespace Study.LabWork2.Feature.Task1.SubTask2;

/// <summary>
/// Определяет реализацию для процессора наборов чисел
/// </summary>
public class NumberSetProcessor
{
    private readonly List<int[]> _numberSets;

    private readonly List<string> _results = new List<string>();

    private readonly object _lockObject = new object();

    private readonly Mutex _mutex = new Mutex();

    private readonly Semaphore _semaphore;

    private int _totalSum = 0;

    public NumberSetProcessor(string filePath, int maxThreads)
    {
        _numberSets = LoadSetsFromFile(filePath);

        _semaphore = new Semaphore(maxThreads, maxThreads);
    }

    public IReadOnlyList<string> Results => _results;

    public int TotalSum => _totalSum;

    public long ExecutionTimeMs { get; private set; }

    public void ProcessSets()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        List<Thread> threads = new List<Thread>();

        for (int i = 0; i < _numberSets.Count; i++)
        {
            int setIndex = i;

            Thread thread = new Thread(() => ProcessSingleSet(setIndex));

            threads.Add(thread);

            thread.Start();
        }

        foreach (Thread thread in threads)
        {
            thread.Join();
        }

        stopwatch.Stop();

        ExecutionTimeMs = stopwatch.ElapsedMilliseconds;
    }

    private void ProcessSingleSet(int setIndex)
    {
        _semaphore.WaitOne();

        try
        {
            int[] numbers = _numberSets[setIndex];

            int sum = numbers.Sum();

            string result =
                $"Поток {Thread.CurrentThread.ManagedThreadId} " +
                $"обработал набор #{setIndex + 1}. " +
                $"Сумма = {sum}";

            lock (_lockObject)
            {
                _results.Add(result);
            }

            _mutex.WaitOne();

            try
            {
                _totalSum += sum;
            }
            finally
            {
                _mutex.ReleaseMutex();
            }
        }
        finally
        {
            _semaphore.Release();
        }
    }

    private List<int[]> LoadSetsFromFile(string filePath)
    {
        List<int[]> sets = new List<int[]>();

        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            int[] numbers = line
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            sets.Add(numbers);
        }

        return sets;
    }

    public static void GenerateDataFile(string filePath)
    {
        Random random = new Random();

        List<string> lines = new List<string>();

        for (int i = 0; i < 15; i++)
        {
            List<int> numbers = new List<int>();

            for (int j = 0; j < 100; j++)
            {
                numbers.Add(random.Next(1, 101));
            }

            lines.Add(string.Join(" ", numbers));
        }

        File.WriteAllLines(filePath, lines);
    }
}
