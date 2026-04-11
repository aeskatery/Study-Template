<a name='assembly'></a>
# Study.LabWork1

## Contents

- [CsvOrderRepository](#T-Study-LabWork1-Features-Task2-CsvOrderRepository 'Study.LabWork1.Features.Task2.CsvOrderRepository')
  - [#ctor(filePath)](#M-Study-LabWork1-Features-Task2-CsvOrderRepository-#ctor-System-String-)
  - [Add()](#M-Study-LabWork1-Features-Task2-CsvOrderRepository-Add-Study-LabWork1-Features-Task2-Order-)
  - [GetAll()](#M-Study-LabWork1-Features-Task2-CsvOrderRepository-GetAll)
  - [GetById()](#M-Study-LabWork1-Features-Task2-CsvOrderRepository-GetById-System-Int32-)
  - [Save()](#M-Study-LabWork1-Features-Task2-CsvOrderRepository-Save)

- [IOrderRepository](#T-Study-LabWork1-Features-Task2-IOrderRepository 'Study.LabWork1.Features.Task2.IOrderRepository')
  - [Add()](#M-Study-LabWork1-Features-Task2-IOrderRepository-Add-Study-LabWork1-Features-Task2-Order-)
  - [GetAll()](#M-Study-LabWork1-Features-Task2-IOrderRepository-GetAll)
  - [GetById()](#M-Study-LabWork1-Features-Task2-IOrderRepository-GetById-System-Int32-)
  - [Save()](#M-Study-LabWork1-Features-Task2-IOrderRepository-Save)

- [InMemoryOrderRepository](#T-Study-LabWork1-Features-Task2-InMemoryOrderRepository 'Study.LabWork1.Features.Task2.InMemoryOrderRepository')
  - [Add()](#M-Study-LabWork1-Features-Task2-InMemoryOrderRepository-Add-Study-LabWork1-Features-Task2-Order-)
  - [GetAll()](#M-Study-LabWork1-Features-Task2-InMemoryOrderRepository-GetAll)
  - [GetById()](#M-Study-LabWork1-Features-Task2-InMemoryOrderRepository-GetById-System-Int32-)
  - [Save()](#M-Study-LabWork1-Features-Task2-InMemoryOrderRepository-Save)

- [Order](#T-Study-LabWork1-Features-Task2-Order 'Study.LabWork1.Features.Task2.Order')
  - [CustomerName](#P-Study-LabWork1-Features-Task2-Order-CustomerName)
  - [Id](#P-Study-LabWork1-Features-Task2-Order-Id)
  - [OrderDate](#P-Study-LabWork1-Features-Task2-Order-OrderDate)
  - [TotalAmount](#P-Study-LabWork1-Features-Task2-Order-TotalAmount)
  - [ToString()](#M-Study-LabWork1-Features-Task2-Order-ToString)

- [IRunService](#T-Study-LabWork1-Shared-Abstractions-IRunService)
  - [RunTask1()](#M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask1)
  - [RunTask2()](#M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask2)
  - [RunTask3()](#M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask3)

- [Program](#T-Study-LabWork1-Program)
  - [RUN_TASK_NUMBER](#F-Study-LabWork1-Program-RUN_TASK_NUMBER)
  - [Main()](#M-Study-LabWork1-Program-Main)

- [RunService](#T-Study-LabWork1-Shared-Services-RunService)
  - [RunTask1()](#M-Study-LabWork1-Shared-Services-RunService-RunTask1)
  - [RunTask2()](#M-Study-LabWork1-Shared-Services-RunService-RunTask2)
  - [RunTask3()](#M-Study-LabWork1-Shared-Services-RunService-RunTask3)

<a name='T-Study-LabWork1-Features-Task2-CsvOrderRepository'></a>
## CsvOrderRepository `type`

##### Namespace

Study.LabWork1.Features.Task2

##### Summary

Адаптер для хранения заказов в CSV-файле.
Реализует порт [IOrderRepository](#T-Study-LabWork1-Features-Task2-IOrderRepository 'Study.LabWork1.Features.Task2.IOrderRepository').

<a name='M-Study-LabWork1-Features-Task2-CsvOrderRepository-#ctor-System-String-'></a>
### #ctor(filePath) `constructor`

##### Summary

Создаёт экземпляр репозитория с указанным путём к CSV-файлу

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Путь к CSV-файлу |

<a name='M-Study-LabWork1-Features-Task2-CsvOrderRepository-Add-Study-LabWork1-Features-Task2-Order-'></a>
### Add() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task2-CsvOrderRepository-GetAll'></a>
### GetAll() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task2-CsvOrderRepository-GetById-System-Int32-'></a>
### GetById() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task2-CsvOrderRepository-Save'></a>
### Save() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork1-Features-Task2-IOrderRepository'></a>
## IOrderRepository `type`

##### Namespace

Study.LabWork1.Features.Task2

<a name='M-Study-LabWork1-Features-Task2-IOrderRepository-Add-Study-LabWork1-Features-Task2-Order-'></a>
### Add() `method`

##### Summary

Добавляет новый заказ

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task2-IOrderRepository-GetAll'></a>
### GetAll() `method`

##### Summary

Возвращает все заказы

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task2-IOrderRepository-GetById-System-Int32-'></a>
### GetById() `method`

##### Summary

Возвращает заказ по идентификатору

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task2-IOrderRepository-Save'></a>
### Save() `method`

##### Summary

Сохраняет изменения (актуально для файловых репозиториев)

##### Parameters

This method has no parameters.

>>>>>>> 3f20d13 ([Feature] выполнено задание 2)
<a name='T-Study-LabWork1-Shared-Abstractions-IRunService'></a>
## IRunService `type`

##### Namespace

Study.LabWork1.Shared.Abstractions

##### Summary

Интерфейс для реализации заданий Л/Р

<a name='M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask1'></a>
### RunTask1() `method`

##### Summary

Запуск выполнения задания 1

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask2'></a>
### RunTask2() `method`

##### Summary

Запуск выполнения задания 2

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask3'></a>
### RunTask3() `method`

##### Summary

Запуск выполнения задания 3

##### Parameters

This method has no parameters.
<<<<<<< HEAD
=======

<a name='T-Study-LabWork1-Features-Task2-InMemoryOrderRepository'></a>
## InMemoryOrderRepository `type`

##### Namespace

Study.LabWork1.Features.Task2

##### Summary

Адаптер для хранения заказов в оперативной памяти (In-Memory).
Реализует порт [IOrderRepository](#T-Study-LabWork1-Features-Task2-IOrderRepository 'Study.LabWork1.Features.Task2.IOrderRepository').

<a name='M-Study-LabWork1-Features-Task2-InMemoryOrderRepository-Add-Study-LabWork1-Features-Task2-Order-'></a>
### Add() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task2-InMemoryOrderRepository-GetAll'></a>
### GetAll() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task2-InMemoryOrderRepository-GetById-System-Int32-'></a>
### GetById() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task2-InMemoryOrderRepository-Save'></a>
### Save() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork1-Features-Task2-Order'></a>
## Order `type`

##### Namespace

Study.LabWork1.Features.Task2

##### Summary

Модель заказа

<a name='P-Study-LabWork1-Features-Task2-Order-CustomerName'></a>
### CustomerName `property`

##### Summary

Имя клиента

<a name='P-Study-LabWork1-Features-Task2-Order-Id'></a>
### Id `property`

##### Summary

Уникальный идентификатор заказа

<a name='P-Study-LabWork1-Features-Task2-Order-OrderDate'></a>
### OrderDate `property`

##### Summary

Дата создания заказа

<a name='P-Study-LabWork1-Features-Task2-Order-TotalAmount'></a>
### TotalAmount `property`

##### Summary

Общая сумма заказа

<a name='M-Study-LabWork1-Features-Task2-Order-ToString'></a>
### ToString() `method`

##### Summary



##### Returns



##### Parameters

This method has no parameters.
>>>>>>> 3f20d13 ([Feature] выполнено задание 2)

<a name='T-Study-LabWork1-Program'></a>
## Program `type`

##### Namespace

Study.LabWork1

##### Summary

Начальная точка входа

<a name='F-Study-LabWork1-Program-RUN_TASK_NUMBER'></a>
### RUN_TASK_NUMBER `constants`

##### Summary

Номер выполняемой задачи

<a name='M-Study-LabWork1-Program-Main'></a>
### Main() `method`

##### Summary

Старт программы

##### Parameters

This method has no parameters.

<<<<<<< HEAD
<a name='T-Study-LabWork1-Features-Task1-RGBA'></a>
## RGBA `type`

##### Namespace

Study.LabWork1.Features.Task1

##### Summary

RGBA class

<a name='M-Study-LabWork1-Features-Task1-RGBA-#ctor-System-Byte,System-Byte,System-Byte,System-Single-'></a>
### #ctor(r,g,b,a) `constructor`

##### Summary

создаём новый RGBA пиксель

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| r | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') |  |
| g | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') |  |
| b | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') |  |
| a | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') |  |

<a name='P-Study-LabWork1-Features-Task1-RGBA-Alpha'></a>
### Alpha `property`

##### Summary

Прозрасность

<a name='P-Study-LabWork1-Features-Task1-RGBA-Blue'></a>
### Blue `property`

##### Summary

Синий канал

<a name='P-Study-LabWork1-Features-Task1-RGBA-Green'></a>
### Green `property`

##### Summary

Зеленый канал

<a name='P-Study-LabWork1-Features-Task1-RGBA-Red'></a>
### Red `property`

##### Summary

Красный канал

<a name='M-Study-LabWork1-Features-Task1-RGBA-Clamp-System-Int32-'></a>
### Clamp(value) `method`

##### Summary

Ограничиваем значение канала в диапозоне 0 - 255

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-Study-LabWork1-Features-Task1-RGBA-ClampFloat-System-Single-'></a>
### ClampFloat(value) `method`

##### Summary

Ограничиваем значение Альфв-канала в диапазоне 0 - 1

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') |  |

<a name='M-Study-LabWork1-Features-Task1-RGBA-Equals-System-Object-'></a>
### Equals(obj) `method`

##### Summary

Сравнение с другим объектом

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |

<a name='M-Study-LabWork1-Features-Task1-RGBA-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

Возращает хэш код

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task1-RGBA-ToHex'></a>
### ToHex() `method`

##### Summary

Возвращает цвет в HEX-формате

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task1-RGBA-ToString'></a>
### ToString() `method`

##### Summary

Возращает строку rgba(r, g, b, a)

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Features-Task1-RGBA-op_Addition-Study-LabWork1-Features-Task1-RGBA,Study-LabWork1-Features-Task1-RGBA-'></a>
### op_Addition(a,b) `method`

##### Summary

Сложение двух пикселей

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Study.LabWork1.Features.Task1.RGBA](#T-Study-LabWork1-Features-Task1-RGBA 'Study.LabWork1.Features.Task1.RGBA') |  |
| b | [Study.LabWork1.Features.Task1.RGBA](#T-Study-LabWork1-Features-Task1-RGBA 'Study.LabWork1.Features.Task1.RGBA') |  |

<a name='M-Study-LabWork1-Features-Task1-RGBA-op_Equality-Study-LabWork1-Features-Task1-RGBA,Study-LabWork1-Features-Task1-RGBA-'></a>
### op_Equality(a,b) `method`

##### Summary

Проверка равенства двух пикселей

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Study.LabWork1.Features.Task1.RGBA](#T-Study-LabWork1-Features-Task1-RGBA 'Study.LabWork1.Features.Task1.RGBA') |  |
| b | [Study.LabWork1.Features.Task1.RGBA](#T-Study-LabWork1-Features-Task1-RGBA 'Study.LabWork1.Features.Task1.RGBA') |  |

<a name='M-Study-LabWork1-Features-Task1-RGBA-op_Inequality-Study-LabWork1-Features-Task1-RGBA,Study-LabWork1-Features-Task1-RGBA-'></a>
### op_Inequality(a,b) `method`

##### Summary

Проверка неравенста двух пикселей

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Study.LabWork1.Features.Task1.RGBA](#T-Study-LabWork1-Features-Task1-RGBA 'Study.LabWork1.Features.Task1.RGBA') |  |
| b | [Study.LabWork1.Features.Task1.RGBA](#T-Study-LabWork1-Features-Task1-RGBA 'Study.LabWork1.Features.Task1.RGBA') |  |

<a name='M-Study-LabWork1-Features-Task1-RGBA-op_Multiply-Study-LabWork1-Features-Task1-RGBA,System-Single-'></a>
### op_Multiply(a,scalar) `method`

##### Summary

Умножение пикселя на скаляр

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Study.LabWork1.Features.Task1.RGBA](#T-Study-LabWork1-Features-Task1-RGBA 'Study.LabWork1.Features.Task1.RGBA') |  |
| scalar | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') |  |

<a name='M-Study-LabWork1-Features-Task1-RGBA-op_Multiply-Study-LabWork1-Features-Task1-RGBA,Study-LabWork1-Features-Task1-RGBA-'></a>
### op_Multiply(a,b) `method`

##### Summary

Умножение двух пикселей

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Study.LabWork1.Features.Task1.RGBA](#T-Study-LabWork1-Features-Task1-RGBA 'Study.LabWork1.Features.Task1.RGBA') |  |
| b | [Study.LabWork1.Features.Task1.RGBA](#T-Study-LabWork1-Features-Task1-RGBA 'Study.LabWork1.Features.Task1.RGBA') |  |

<a name='M-Study-LabWork1-Features-Task1-RGBA-op_Subtraction-Study-LabWork1-Features-Task1-RGBA,Study-LabWork1-Features-Task1-RGBA-'></a>
### op_Subtraction(a,b) `method`

##### Summary

Вычитание двух пикселей

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Study.LabWork1.Features.Task1.RGBA](#T-Study-LabWork1-Features-Task1-RGBA 'Study.LabWork1.Features.Task1.RGBA') |  |
| b | [Study.LabWork1.Features.Task1.RGBA](#T-Study-LabWork1-Features-Task1-RGBA 'Study.LabWork1.Features.Task1.RGBA') |  |

=======
>>>>>>> 3f20d13 ([Feature] выполнено задание 2)
<a name='T-Study-LabWork1-Shared-Services-RunService'></a>
## RunService `type`

##### Namespace

Study.LabWork1.Shared.Services

##### Summary

Реализация заданий Л/Р

<a name='M-Study-LabWork1-Shared-Services-RunService-RunTask1'></a>
### RunTask1() `method`

##### Summary

Задание 1

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Shared-Services-RunService-RunTask2'></a>
### RunTask2() `method`

##### Summary

Задание 2

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork1-Shared-Services-RunService-RunTask3'></a>
### RunTask3() `method`

##### Summary

Задание 3

##### Parameters

This method has no parameters.
