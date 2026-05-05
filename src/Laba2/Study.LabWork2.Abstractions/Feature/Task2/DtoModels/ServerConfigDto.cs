namespace Study.LabWork2.Abstractions.Feature.Task2.DtoModels;

/// <summary>
/// Представляет конфигурацию сервера для выполнения HTTP запроса
/// </summary>
public sealed record ServerConfigDto
{
    /// <summary>
    /// Название сервера (для идентификации в логах)
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// URL сервера (полный адрес с протоколом)
    /// </summary>
    /// <example>https://jsonplaceholder.typicode.com/users</example>
    public string Url { get; set; }

    /// <summary>
    /// HTTP метод запроса (GET/POST/PUT/DELETE)
    /// </summary>
    /// <remarks>По умолчанию используется GET</remarks>
    public string Method { get; set; } = "GET";

    /// <summary>
    /// Тело запроса для методов POST/PUT (в формате объекта)
    /// </summary>
    /// <remarks>
    /// Будет автоматически сериализован в JSON.
    /// Для GET запросов игнорируется.
    /// </remarks>
    public object Body { get; set; }

    /// <summary>
    /// Таймаут запроса в секундах
    /// </summary>
    /// <remarks>
    /// По умолчанию 30 секунд.
    /// При превышении таймаута будет выброшено исключение.
    /// </remarks>
    public int TimeoutSeconds { get; set; } = 30;

    /// <summary>
    /// Заголовки HTTP запроса (опционально)
    /// </summary>
    public Dictionary<string, string> Headers { get; set; } = new Dictionary<string, string>();

    /// <summary>
    /// Возвращает строковое представление конфигурации сервера
    /// </summary>
    /// <returns>Строка в формате "Название: URL (Метод)"</returns>
    public override string ToString()
    {
        return $"{Name}: {Url} ({Method})";
    }

    /// <summary>
    /// Проверяет корректность конфигурации
    /// </summary>
    /// <returns>true, если конфигурация валидна</returns>
    public bool IsValid()
    {
        if (string.IsNullOrWhiteSpace(Name))
            return false;

        if (string.IsNullOrWhiteSpace(Url))
            return false;

        if (!Uri.IsWellFormedUriString(Url, UriKind.Absolute))
            return false;

        if (string.IsNullOrWhiteSpace(Method))
            return false;

        var validMethods = new[] { "GET", "POST", "PUT", "DELETE", "PATCH" };
        if (!validMethods.Contains(Method.ToUpper()))
            return false;

        if (TimeoutSeconds <= 0)
            return false;

        return true;
    }
}
