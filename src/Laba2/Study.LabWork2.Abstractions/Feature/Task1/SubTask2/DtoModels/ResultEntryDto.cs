namespace Study.LabWork2.Abstractions.Feature.Task1.SubTask2.DtoModels;

/// <summary>
/// Представляет результат обработки одного набора чисел
/// </summary>
public sealed record ResultEntryDto
{
    /// <summary>
    /// Номер набора чисел (порядковый номер от 1 до 15)
    /// </summary>
    public int SetNumber { get; init; }

    /// <summary>
    /// Сумма всех чисел в наборе
    /// </summary>
    public int Sum { get; init; }

    /// <summary>
    /// Идентификатор управляемого потока, выполнившего обработку набора
    /// </summary>
    public int ThreadId { get; init; }

    /// <summary>
    /// Возвращает строковое представление результата обработки
    /// </summary>
    public override string ToString()
    {
        return $"Набор {SetNumber}: сумма = {Sum} (поток {ThreadId})";
    }
}
