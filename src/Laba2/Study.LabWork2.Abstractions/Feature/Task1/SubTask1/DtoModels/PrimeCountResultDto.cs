namespace Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels;

/// <summary>
/// Представляет результат подсчета простых чисел
/// </summary>
public sealed record PrimeCountResultDto
{
    /// <summary>
    /// Количество найденных простых чисел в заданном диапазоне
    /// </summary>
    /// <remarks>
    /// Для диапазона 1-10000 ожидаемое значение: 1229 простых чисел
    /// Используется для проверки корректности работы алгоритма
    /// </remarks>
    public int PrimeCount { get; init; }

    /// <summary>
    /// Время выполнения подсчета от начала до конца
    /// </summary>
    /// <remarks>
    /// Измеряется с помощью Stopwatch с высоким разрешением.
    /// Включает время на создание потоков, проверку чисел и синхронизацию.
    /// </remarks>
    public TimeSpan ExecutionTime { get; init; }

    /// <summary>
    /// Количество потоков, использованных для параллельного подсчета
    /// </summary>
    /// <remarks>
    /// Диапазон значений зависит от параметров запуска.
    /// Обычно используется 2-8 потоков для оптимальной производительности.
    /// </remarks>
    public int ThreadCount { get; init; }

    /// <summary>
    /// Тип используемой синхронизации
    /// </summary>
    /// <remarks>
    /// Возможные значения:
    /// - "Monitor (lock)" - легковесная синхронизация на основе монитора
    /// - "Mutex" - синхронизация с использованием мьютекса
    /// - "Semaphore" - синхронизация с использованием семафора
    /// </remarks>
    public string SynchronizationType { get; init; }

    /// <summary>
    /// Список найденных простых чисел
    /// </summary>
    /// <remarks>
    /// Используется для отладки и проверки корректности подсчета.
    /// Может быть большим (до 1229 элементов), поэтому в production
    /// рекомендуется отключать сбор этой информации.
    /// </remarks>
    public List<int> FoundPrimes { get; init; }

    /// <summary>
    /// Возвращает форматированное строковое представление результата
    /// </summary>
    /// <returns>
    /// Строка с информацией о типе синхронизации, количестве простых чисел,
    /// времени выполнения и количестве потоков
    /// </returns>
    public override string ToString()
    {
        return $"Тип синхронизации: {SynchronizationType}\n" +
               $"Найдено простых чисел: {PrimeCount:N0}\n" +
               $"Время выполнения: {ExecutionTime.TotalMilliseconds:F2} мс " +
               $"({ExecutionTime.TotalSeconds:F2} сек)\n" +
               $"Количество потоков: {ThreadCount}";
    }

    /// <summary>
    /// Возвращает краткое строковое представление для сравнения
    /// </summary>
    /// <returns>Строка с ключевыми параметрами в компактном формате</returns>
    public string ToShortString()
    {
        return $"{SynchronizationType,-20} | " +
               $"Время: {ExecutionTime.TotalMilliseconds,8:F2} мс | " +
               $"Простых чисел: {PrimeCount,4} | " +
               $"Потоков: {ThreadCount}";
    }

    /// <summary>
    /// Проверяет корректность подсчета
    /// </summary>
    /// <param name="expectedCount">Ожидаемое количество простых чисел</param>
    /// <returns>true, если подсчет выполнен корректно</returns>
    public bool IsValid(int expectedCount)
    {
        return PrimeCount == expectedCount;
    }
}
