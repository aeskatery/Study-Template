using Study.LabWork2.Abstractions.Feature.Task1.SubTask2.DtoModels;

namespace Study.LabWork2.Abstractions.Feature.Task1.SubTask2;

/// <summary>
/// Определяет контракт для процессора наборов чисел
/// </summary>
public interface INumberSetProcessor
{
    /// <summary>
    /// Запускает процесс обработки наборов чисел
    /// </summary>
    void Process();

    /// <summary>
    /// Возвращает результат обработки
    /// </summary>
    /// <returns>Объект с результатами обработки</returns>
    ProcessingResultDto GetResult();
}
