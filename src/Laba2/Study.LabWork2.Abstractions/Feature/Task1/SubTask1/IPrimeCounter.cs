using Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels;

namespace Study.LabWork2.Abstractions.Feature.Task1.SubTask1;

/// <summary>
/// Общий интерфейс для всех версий счетчика простых чисел
/// </summary>
public interface IPrimeCounter
{
    /// <summary>
    /// Запускает подсчет простых чисел в заданном диапазоне
    /// </summary>
    /// <param name="start">Начало диапазона (включительно)</param>
    /// <param name="end">Конец диапазона (включительно)</param>
    /// <param name="threadCount">Количество потоков для подсчета</param>
    /// <returns>Результат подсчета</returns>
    PrimeCountResultDto CountPrimes(int start, int end, int threadCount);

    /// <summary>
    /// Возвращает название версии счетчика
    /// </summary>
    string GetVersionName();
}
