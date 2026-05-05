using Study.LabWork2.Abstractions.Feature.Task2;
using Study.LabWork2.Abstractions.Feature.Task2.DtoModels;

namespace Study.LabWork2.Feature.Task2;

/// <summary>
/// Асинхронная версия приложения (с использованием async/await)
/// </summary>
public sealed class AsynchronousServerRequestApp : IServerRequestApp
{
    public ExecutionResultDto<TResponse> ExecuteRequests<TResponse>(ServerConfigDto[] servers)
    {
        // Для асинхронной версии вызываем асинхронный метод
        return ExecuteRequestsAsync<TResponse>(servers).GetAwaiter().GetResult();
    }

    public string GetVersion() => throw new NotImplementedException();

    /// <summary>
    /// Асинхронное выполнение запросов
    /// </summary>
    private async Task<ExecutionResultDto<TResponse>> ExecuteRequestsAsync<TResponse>(ServerConfigDto[] servers) => throw new NotImplementedException();
}
