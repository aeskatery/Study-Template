using Study.LabWork2.Abstractions.Feature.Task2.DtoModels;

namespace Study.LabWork2.Abstractions.Feature.Task2;

/// <summary>
/// Общий интерфейс для всех версий приложения
/// </summary>
public interface IServerRequestApp
{
    /// <summary>
    /// Выполняет запросы к серверам
    /// </summary>
    /// <param name="servers">Список конфигураций серверов</param>
    /// <returns>Результат выполнения</returns>
    ExecutionResultDto<TResponse> ExecuteRequests<TResponse>(ServerConfigDto[] servers);

    /// <summary>
    /// Возвращает название версии
    /// </summary>
    /// <returns>Название версии</returns>
    string GetVersion();
}
