namespace Study.LabWork2.Abstractions.Feature.Task1.SubTask2.DtoModels;

/// <summary>
/// Представляет результат обработки наборов чисел
/// </summary>
public sealed record ProcessingResultDto
{
    /// <summary>
    /// Список результатов по каждому набору
    /// </summary>
    public List<ResultEntryDto> Results { get; init; }

    /// <summary>
    /// Общая сумма всех наборов
    /// </summary>
    public int TotalSum { get; init; }

    /// <summary>
    /// Время выполнения обработки
    /// </summary>
    public TimeSpan ExecutionTime { get; init; }

    /// <summary>
    /// Количество обработанных наборов
    /// </summary>
    public int ProcessedSetsCount { get; init; }
}
