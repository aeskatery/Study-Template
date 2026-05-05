<a name='assembly'></a>
# Study.LabWork2.Abstractions

## Contents

- [ExecutionResultDto\`1](#T-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ExecutionResultDto`1 'Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ExecutionResultDto`1')
  - [FailedRequests](#P-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ExecutionResultDto`1-FailedRequests 'Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ExecutionResultDto`1.FailedRequests')
  - [Responses](#P-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ExecutionResultDto`1-Responses 'Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ExecutionResultDto`1.Responses')
  - [SuccessfulRequests](#P-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ExecutionResultDto`1-SuccessfulRequests 'Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ExecutionResultDto`1.SuccessfulRequests')
  - [TotalExecutionTime](#P-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ExecutionResultDto`1-TotalExecutionTime 'Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ExecutionResultDto`1.TotalExecutionTime')
  - [Version](#P-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ExecutionResultDto`1-Version 'Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ExecutionResultDto`1.Version')
- [INumberSetProcessor](#T-Study-LabWork2-Abstractions-Feature-Task1-SubTask2-INumberSetProcessor 'Study.LabWork2.Abstractions.Feature.Task1.SubTask2.INumberSetProcessor')
  - [GetResult()](#M-Study-LabWork2-Abstractions-Feature-Task1-SubTask2-INumberSetProcessor-GetResult 'Study.LabWork2.Abstractions.Feature.Task1.SubTask2.INumberSetProcessor.GetResult')
  - [Process()](#M-Study-LabWork2-Abstractions-Feature-Task1-SubTask2-INumberSetProcessor-Process 'Study.LabWork2.Abstractions.Feature.Task1.SubTask2.INumberSetProcessor.Process')
- [IPrimeCounter](#T-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-IPrimeCounter 'Study.LabWork2.Abstractions.Feature.Task1.SubTask1.IPrimeCounter')
  - [CountPrimes(start,end,threadCount)](#M-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-IPrimeCounter-CountPrimes-System-Int32,System-Int32,System-Int32- 'Study.LabWork2.Abstractions.Feature.Task1.SubTask1.IPrimeCounter.CountPrimes(System.Int32,System.Int32,System.Int32)')
  - [GetVersionName()](#M-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-IPrimeCounter-GetVersionName 'Study.LabWork2.Abstractions.Feature.Task1.SubTask1.IPrimeCounter.GetVersionName')
- [IRequestService](#T-Study-LabWork2-Abstractions-Feature-Task2-IRequestService 'Study.LabWork2.Abstractions.Feature.Task2.IRequestService')
  - [FetchData(url)](#M-Study-LabWork2-Abstractions-Feature-Task2-IRequestService-FetchData-System-String- 'Study.LabWork2.Abstractions.Feature.Task2.IRequestService.FetchData(System.String)')
  - [FetchDataAsync(url,cancellationToken)](#M-Study-LabWork2-Abstractions-Feature-Task2-IRequestService-FetchDataAsync-System-String,System-Threading-CancellationToken- 'Study.LabWork2.Abstractions.Feature.Task2.IRequestService.FetchDataAsync(System.String,System.Threading.CancellationToken)')
- [IServerRequestApp](#T-Study-LabWork2-Abstractions-Feature-Task2-IServerRequestApp 'Study.LabWork2.Abstractions.Feature.Task2.IServerRequestApp')
  - [ExecuteRequests\`\`1(servers)](#M-Study-LabWork2-Abstractions-Feature-Task2-IServerRequestApp-ExecuteRequests``1-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto[]- 'Study.LabWork2.Abstractions.Feature.Task2.IServerRequestApp.ExecuteRequests``1(Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto[])')
  - [GetVersion()](#M-Study-LabWork2-Abstractions-Feature-Task2-IServerRequestApp-GetVersion 'Study.LabWork2.Abstractions.Feature.Task2.IServerRequestApp.GetVersion')
- [PrimeCountResultDto](#T-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-DtoModels-PrimeCountResultDto 'Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels.PrimeCountResultDto')
  - [ExecutionTime](#P-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-DtoModels-PrimeCountResultDto-ExecutionTime 'Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels.PrimeCountResultDto.ExecutionTime')
  - [FoundPrimes](#P-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-DtoModels-PrimeCountResultDto-FoundPrimes 'Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels.PrimeCountResultDto.FoundPrimes')
  - [PrimeCount](#P-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-DtoModels-PrimeCountResultDto-PrimeCount 'Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels.PrimeCountResultDto.PrimeCount')
  - [SynchronizationType](#P-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-DtoModels-PrimeCountResultDto-SynchronizationType 'Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels.PrimeCountResultDto.SynchronizationType')
  - [ThreadCount](#P-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-DtoModels-PrimeCountResultDto-ThreadCount 'Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels.PrimeCountResultDto.ThreadCount')
  - [IsValid(expectedCount)](#M-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-DtoModels-PrimeCountResultDto-IsValid-System-Int32- 'Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels.PrimeCountResultDto.IsValid(System.Int32)')
  - [ToShortString()](#M-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-DtoModels-PrimeCountResultDto-ToShortString 'Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels.PrimeCountResultDto.ToShortString')
  - [ToString()](#M-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-DtoModels-PrimeCountResultDto-ToString 'Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels.PrimeCountResultDto.ToString')
- [ProcessingResultDto](#T-Study-LabWork2-Abstractions-Feature-Task1-SubTask2-DtoModels-ProcessingResultDto 'Study.LabWork2.Abstractions.Feature.Task1.SubTask2.DtoModels.ProcessingResultDto')
  - [ExecutionTime](#P-Study-LabWork2-Abstractions-Feature-Task1-SubTask2-DtoModels-ProcessingResultDto-ExecutionTime 'Study.LabWork2.Abstractions.Feature.Task1.SubTask2.DtoModels.ProcessingResultDto.ExecutionTime')
  - [ProcessedSetsCount](#P-Study-LabWork2-Abstractions-Feature-Task1-SubTask2-DtoModels-ProcessingResultDto-ProcessedSetsCount 'Study.LabWork2.Abstractions.Feature.Task1.SubTask2.DtoModels.ProcessingResultDto.ProcessedSetsCount')
  - [Results](#P-Study-LabWork2-Abstractions-Feature-Task1-SubTask2-DtoModels-ProcessingResultDto-Results 'Study.LabWork2.Abstractions.Feature.Task1.SubTask2.DtoModels.ProcessingResultDto.Results')
  - [TotalSum](#P-Study-LabWork2-Abstractions-Feature-Task1-SubTask2-DtoModels-ProcessingResultDto-TotalSum 'Study.LabWork2.Abstractions.Feature.Task1.SubTask2.DtoModels.ProcessingResultDto.TotalSum')
- [ResultEntryDto](#T-Study-LabWork2-Abstractions-Feature-Task1-SubTask2-DtoModels-ResultEntryDto 'Study.LabWork2.Abstractions.Feature.Task1.SubTask2.DtoModels.ResultEntryDto')
  - [SetNumber](#P-Study-LabWork2-Abstractions-Feature-Task1-SubTask2-DtoModels-ResultEntryDto-SetNumber 'Study.LabWork2.Abstractions.Feature.Task1.SubTask2.DtoModels.ResultEntryDto.SetNumber')
  - [Sum](#P-Study-LabWork2-Abstractions-Feature-Task1-SubTask2-DtoModels-ResultEntryDto-Sum 'Study.LabWork2.Abstractions.Feature.Task1.SubTask2.DtoModels.ResultEntryDto.Sum')
  - [ThreadId](#P-Study-LabWork2-Abstractions-Feature-Task1-SubTask2-DtoModels-ResultEntryDto-ThreadId 'Study.LabWork2.Abstractions.Feature.Task1.SubTask2.DtoModels.ResultEntryDto.ThreadId')
  - [ToString()](#M-Study-LabWork2-Abstractions-Feature-Task1-SubTask2-DtoModels-ResultEntryDto-ToString 'Study.LabWork2.Abstractions.Feature.Task1.SubTask2.DtoModels.ResultEntryDto.ToString')
- [ServerConfigDto](#T-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto 'Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto')
  - [Body](#P-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto-Body 'Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto.Body')
  - [Headers](#P-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto-Headers 'Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto.Headers')
  - [Method](#P-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto-Method 'Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto.Method')
  - [Name](#P-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto-Name 'Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto.Name')
  - [TimeoutSeconds](#P-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto-TimeoutSeconds 'Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto.TimeoutSeconds')
  - [Url](#P-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto-Url 'Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto.Url')
  - [IsValid()](#M-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto-IsValid 'Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto.IsValid')
  - [ToString()](#M-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto-ToString 'Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto.ToString')

<a name='T-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ExecutionResultDto`1'></a>
## ExecutionResultDto\`1 `type`

##### Namespace

Study.LabWork2.Abstractions.Feature.Task2.DtoModels

##### Summary

Представляет результат выполнения всех запросов к серверам

<a name='P-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ExecutionResultDto`1-FailedRequests'></a>
### FailedRequests `property`

##### Summary

Количество неудачных запросов (ошибки сети, таймауты, HTTP ошибки)

<a name='P-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ExecutionResultDto`1-Responses'></a>
### Responses `property`

##### Summary

Список ответов от серверов

<a name='P-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ExecutionResultDto`1-SuccessfulRequests'></a>
### SuccessfulRequests `property`

##### Summary

Количество успешных запросов (HTTP статус 2xx)

<a name='P-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ExecutionResultDto`1-TotalExecutionTime'></a>
### TotalExecutionTime `property`

##### Summary

Общее время выполнения всех запросов

<a name='P-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ExecutionResultDto`1-Version'></a>
### Version `property`

##### Summary

Версия приложения (синхронная/асинхронная)

<a name='T-Study-LabWork2-Abstractions-Feature-Task1-SubTask2-INumberSetProcessor'></a>
## INumberSetProcessor `type`

##### Namespace

Study.LabWork2.Abstractions.Feature.Task1.SubTask2

##### Summary

Определяет контракт для процессора наборов чисел

<a name='M-Study-LabWork2-Abstractions-Feature-Task1-SubTask2-INumberSetProcessor-GetResult'></a>
### GetResult() `method`

##### Summary

Возвращает результат обработки

##### Returns

Объект с результатами обработки

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-Abstractions-Feature-Task1-SubTask2-INumberSetProcessor-Process'></a>
### Process() `method`

##### Summary

Запускает процесс обработки наборов чисел

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-IPrimeCounter'></a>
## IPrimeCounter `type`

##### Namespace

Study.LabWork2.Abstractions.Feature.Task1.SubTask1

##### Summary

Общий интерфейс для всех версий счетчика простых чисел

<a name='M-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-IPrimeCounter-CountPrimes-System-Int32,System-Int32,System-Int32-'></a>
### CountPrimes(start,end,threadCount) `method`

##### Summary

Запускает подсчет простых чисел в заданном диапазоне

##### Returns

Результат подсчета

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| start | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Начало диапазона (включительно) |
| end | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Конец диапазона (включительно) |
| threadCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Количество потоков для подсчета |

<a name='M-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-IPrimeCounter-GetVersionName'></a>
### GetVersionName() `method`

##### Summary

Возвращает название версии счетчика

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork2-Abstractions-Feature-Task2-IRequestService'></a>
## IRequestService `type`

##### Namespace

Study.LabWork2.Abstractions.Feature.Task2

##### Summary

Интерфейс для реализации методов опроса другого сервиса

<a name='M-Study-LabWork2-Abstractions-Feature-Task2-IRequestService-FetchData-System-String-'></a>
### FetchData(url) `method`

##### Summary

Отправить запрос к сервису

##### Returns

Ответ от сервиса

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Веб-адрес |

<a name='M-Study-LabWork2-Abstractions-Feature-Task2-IRequestService-FetchDataAsync-System-String,System-Threading-CancellationToken-'></a>
### FetchDataAsync(url,cancellationToken) `method`

##### Summary

Отправить запрос к сервису

##### Returns

Ответ от сервиса

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Веб-адрес |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='T-Study-LabWork2-Abstractions-Feature-Task2-IServerRequestApp'></a>
## IServerRequestApp `type`

##### Namespace

Study.LabWork2.Abstractions.Feature.Task2

##### Summary

Общий интерфейс для всех версий приложения

<a name='M-Study-LabWork2-Abstractions-Feature-Task2-IServerRequestApp-ExecuteRequests``1-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto[]-'></a>
### ExecuteRequests\`\`1(servers) `method`

##### Summary

Выполняет запросы к серверам

##### Returns

Результат выполнения

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| servers | [Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto[]](#T-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto[] 'Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto[]') | Список конфигураций серверов |

<a name='M-Study-LabWork2-Abstractions-Feature-Task2-IServerRequestApp-GetVersion'></a>
### GetVersion() `method`

##### Summary

Возвращает название версии

##### Returns

Название версии

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-DtoModels-PrimeCountResultDto'></a>
## PrimeCountResultDto `type`

##### Namespace

Study.LabWork2.Abstractions.Feature.Task1.SubTask1.DtoModels

##### Summary

Представляет результат подсчета простых чисел

<a name='P-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-DtoModels-PrimeCountResultDto-ExecutionTime'></a>
### ExecutionTime `property`

##### Summary

Время выполнения подсчета от начала до конца

##### Remarks

Измеряется с помощью Stopwatch с высоким разрешением.
Включает время на создание потоков, проверку чисел и синхронизацию.

<a name='P-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-DtoModels-PrimeCountResultDto-FoundPrimes'></a>
### FoundPrimes `property`

##### Summary

Список найденных простых чисел

##### Remarks

Используется для отладки и проверки корректности подсчета.
Может быть большим (до 1229 элементов), поэтому в production
рекомендуется отключать сбор этой информации.

<a name='P-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-DtoModels-PrimeCountResultDto-PrimeCount'></a>
### PrimeCount `property`

##### Summary

Количество найденных простых чисел в заданном диапазоне

##### Remarks

Для диапазона 1-10000 ожидаемое значение: 1229 простых чисел
Используется для проверки корректности работы алгоритма

<a name='P-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-DtoModels-PrimeCountResultDto-SynchronizationType'></a>
### SynchronizationType `property`

##### Summary

Тип используемой синхронизации

##### Remarks

Возможные значения:
- "Monitor (lock)" - легковесная синхронизация на основе монитора
- "Mutex" - синхронизация с использованием мьютекса
- "Semaphore" - синхронизация с использованием семафора

<a name='P-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-DtoModels-PrimeCountResultDto-ThreadCount'></a>
### ThreadCount `property`

##### Summary

Количество потоков, использованных для параллельного подсчета

##### Remarks

Диапазон значений зависит от параметров запуска.
Обычно используется 2-8 потоков для оптимальной производительности.

<a name='M-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-DtoModels-PrimeCountResultDto-IsValid-System-Int32-'></a>
### IsValid(expectedCount) `method`

##### Summary

Проверяет корректность подсчета

##### Returns

true, если подсчет выполнен корректно

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expectedCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Ожидаемое количество простых чисел |

<a name='M-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-DtoModels-PrimeCountResultDto-ToShortString'></a>
### ToShortString() `method`

##### Summary

Возвращает краткое строковое представление для сравнения

##### Returns

Строка с ключевыми параметрами в компактном формате

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-Abstractions-Feature-Task1-SubTask1-DtoModels-PrimeCountResultDto-ToString'></a>
### ToString() `method`

##### Summary

Возвращает форматированное строковое представление результата

##### Returns

Строка с информацией о типе синхронизации, количестве простых чисел,
времени выполнения и количестве потоков

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork2-Abstractions-Feature-Task1-SubTask2-DtoModels-ProcessingResultDto'></a>
## ProcessingResultDto `type`

##### Namespace

Study.LabWork2.Abstractions.Feature.Task1.SubTask2.DtoModels

##### Summary

Представляет результат обработки наборов чисел

<a name='P-Study-LabWork2-Abstractions-Feature-Task1-SubTask2-DtoModels-ProcessingResultDto-ExecutionTime'></a>
### ExecutionTime `property`

##### Summary

Время выполнения обработки

<a name='P-Study-LabWork2-Abstractions-Feature-Task1-SubTask2-DtoModels-ProcessingResultDto-ProcessedSetsCount'></a>
### ProcessedSetsCount `property`

##### Summary

Количество обработанных наборов

<a name='P-Study-LabWork2-Abstractions-Feature-Task1-SubTask2-DtoModels-ProcessingResultDto-Results'></a>
### Results `property`

##### Summary

Список результатов по каждому набору

<a name='P-Study-LabWork2-Abstractions-Feature-Task1-SubTask2-DtoModels-ProcessingResultDto-TotalSum'></a>
### TotalSum `property`

##### Summary

Общая сумма всех наборов

<a name='T-Study-LabWork2-Abstractions-Feature-Task1-SubTask2-DtoModels-ResultEntryDto'></a>
## ResultEntryDto `type`

##### Namespace

Study.LabWork2.Abstractions.Feature.Task1.SubTask2.DtoModels

##### Summary

Представляет результат обработки одного набора чисел

<a name='P-Study-LabWork2-Abstractions-Feature-Task1-SubTask2-DtoModels-ResultEntryDto-SetNumber'></a>
### SetNumber `property`

##### Summary

Номер набора чисел (порядковый номер от 1 до 15)

<a name='P-Study-LabWork2-Abstractions-Feature-Task1-SubTask2-DtoModels-ResultEntryDto-Sum'></a>
### Sum `property`

##### Summary

Сумма всех чисел в наборе

<a name='P-Study-LabWork2-Abstractions-Feature-Task1-SubTask2-DtoModels-ResultEntryDto-ThreadId'></a>
### ThreadId `property`

##### Summary

Идентификатор управляемого потока, выполнившего обработку набора

<a name='M-Study-LabWork2-Abstractions-Feature-Task1-SubTask2-DtoModels-ResultEntryDto-ToString'></a>
### ToString() `method`

##### Summary

Возвращает строковое представление результата обработки

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto'></a>
## ServerConfigDto `type`

##### Namespace

Study.LabWork2.Abstractions.Feature.Task2.DtoModels

##### Summary

Представляет конфигурацию сервера для выполнения HTTP запроса

<a name='P-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto-Body'></a>
### Body `property`

##### Summary

Тело запроса для методов POST/PUT (в формате объекта)

##### Remarks

Будет автоматически сериализован в JSON.
Для GET запросов игнорируется.

<a name='P-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto-Headers'></a>
### Headers `property`

##### Summary

Заголовки HTTP запроса (опционально)

<a name='P-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto-Method'></a>
### Method `property`

##### Summary

HTTP метод запроса (GET/POST/PUT/DELETE)

##### Remarks

По умолчанию используется GET

<a name='P-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto-Name'></a>
### Name `property`

##### Summary

Название сервера (для идентификации в логах)

<a name='P-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto-TimeoutSeconds'></a>
### TimeoutSeconds `property`

##### Summary

Таймаут запроса в секундах

##### Remarks

По умолчанию 30 секунд.
При превышении таймаута будет выброшено исключение.

<a name='P-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto-Url'></a>
### Url `property`

##### Summary

URL сервера (полный адрес с протоколом)

##### Example

https://jsonplaceholder.typicode.com/users

<a name='M-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto-IsValid'></a>
### IsValid() `method`

##### Summary

Проверяет корректность конфигурации

##### Returns

true, если конфигурация валидна

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto-ToString'></a>
### ToString() `method`

##### Summary

Возвращает строковое представление конфигурации сервера

##### Returns

Строка в формате "Название: URL (Метод)"

##### Parameters

This method has no parameters.
