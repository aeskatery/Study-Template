namespace Study.LabWork2.UnitTests.Feature.Task2;

[TestFixture]
public sealed class AsynchronousServerRequestAppTests
{
    // TODO: В тестах не используем прямое обращение к стороннему серверу.
    // Вместо этого используем:
    // 
    // 1. МОК-ОБЪЕКТЫ (Mock) - для unit-тестирования:
    //    - Moq Framework: var mockHttpClient = new Mock<HttpClient>();
    //    - NSubstitute: var substitute = Substitute.For<IHttpClient>();
    //    - FakeItEasy: A.Fake<IHttpClient>();
    // 
    // 2. ТЕСТОВЫЙ HTTP-КЛИЕНТ (TestHttpClient):
    //    - TestServer из Microsoft.AspNetCore.TestHost
    //    - WebApplicationFactory для интеграционных тестов
    //    - HttpMessageHandler с предопределенными ответами
    // 
    // 3. ЛОКАЛЬНЫЙ ТЕСТОВЫЙ СЕРВЕР:
    //    - WireMock.NET - эмуляция HTTP сервера с настраиваемыми ответами
    //    - MockHttp - легковесный эмулятор HTTP
    //    - HttpMock - имитация HTTP запросов
    // 
    // 4. ВНУТРЕННИЙ HTTP-ХЭНДЛЕР (FakeHttpMessageHandler):
    //    - Создание своего обработчика с предопределенными ответами
    //    - Использование DelegatingHandler для перехвата запросов
    // 
    // Примеры использования см. в классе TestHelpers ниже
}
