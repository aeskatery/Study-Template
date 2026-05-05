namespace Study.LabWork2.Abstractions.Feature.Task2.DtoModels;

/// <summary>
/// Представляет результат выполнения всех запросов к серверам
/// </summary>
public sealed record ExecutionResultDto<T>
{
    /// <summary>
    /// Список ответов от серверов
    /// </summary>
    public List<T> Responses { get; init; }

    /// <summary>
    /// Общее время выполнения всех запросов
    /// </summary>
    public TimeSpan TotalExecutionTime { get; init; }

    /// <summary>
    /// Количество успешных запросов (HTTP статус 2xx)
    /// </summary>
    public int SuccessfulRequests { get; init; }

    /// <summary>
    /// Количество неудачных запросов (ошибки сети, таймауты, HTTP ошибки)
    /// </summary>
    public int FailedRequests { get; init; }

    /// <summary>
    /// Версия приложения (синхронная/асинхронная)
    /// </summary>
    public string Version { get; init; }
}
