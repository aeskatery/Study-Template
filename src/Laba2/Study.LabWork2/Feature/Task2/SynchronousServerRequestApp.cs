using Study.LabWork2.Abstractions.Feature.Task2;
using Study.LabWork2.Abstractions.Feature.Task2.DtoModels;

namespace Study.LabWork2.Feature.Task2;

/// <summary>
/// Синхронная версия приложения (без использования async/await)
/// </summary>
public sealed class SynchronousServerRequestApp : IServerRequestApp
{
    public ExecutionResultDto<TResponse> ExecuteRequests<TResponse>(ServerConfigDto[] servers) => throw new NotImplementedException();

    public string GetVersion() => throw new NotImplementedException();
}
