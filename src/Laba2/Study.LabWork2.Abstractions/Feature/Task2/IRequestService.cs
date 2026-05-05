namespace Study.LabWork2.Abstractions.Feature.Task2;

/// <summary>
/// Интерфейс для реализации методов опроса другого сервиса
/// </summary>
public interface IRequestService
{
    /// <summary>
    /// Отправить запрос к сервису
    /// </summary>
    /// <param name="url">Веб-адрес</param>
    /// <returns>Ответ от сервиса</returns>
    string FetchData(string url);

    /// <summary>
    /// Отправить запрос к сервису
    /// </summary>
    /// <param name="url">Веб-адрес</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Ответ от сервиса</returns>
    Task<string> FetchDataAsync(string url, CancellationToken cancellationToken = default);
}
