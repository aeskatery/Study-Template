<a name='assembly'></a>
# Study.LabWork1

## Contents

- [IRunService](#T-Study-LabWork1-Shared-Abstractions-IRunService 'Study.LabWork1.Shared.Abstractions.IRunService')
  - [RunTask1()](#M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask1 'Study.LabWork1.Shared.Abstractions.IRunService.RunTask1')
  - [RunTask2()](#M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask2 'Study.LabWork1.Shared.Abstractions.IRunService.RunTask2')
  - [RunTask3()](#M-Study-LabWork1-Shared-Abstractions-IRunService-RunTask3 'Study.LabWork1.Shared.Abstractions.IRunService.RunTask3')
- [Program](#T-Study-LabWork1-Program 'Study.LabWork1.Program')
  - [RUN_TASK_NUMBER](#F-Study-LabWork1-Program-RUN_TASK_NUMBER 'Study.LabWork1.Program.RUN_TASK_NUMBER')
  - [Main()](#M-Study-LabWork1-Program-Main 'Study.LabWork1.Program.Main')
- [RGBA](#T-Study-LabWork1-Features-Task1-RGBA 'Study.LabWork1.Features.Task1.RGBA')
  - [#ctor(r,g,b,a)](#M-Study-LabWork1-Features-Task1-RGBA-#ctor-System-Byte,System-Byte,System-Byte,System-Single- 'Study.LabWork1.Features.Task1.RGBA.#ctor(System.Byte,System.Byte,System.Byte,System.Single)')
  - [Alpha](#P-Study-LabWork1-Features-Task1-RGBA-Alpha 'Study.LabWork1.Features.Task1.RGBA.Alpha')
  - [Blue](#P-Study-LabWork1-Features-Task1-RGBA-Blue 'Study.LabWork1.Features.Task1.RGBA.Blue')
  - [Green](#P-Study-LabWork1-Features-Task1-RGBA-Green 'Study.LabWork1.Features.Task1.RGBA.Green')
  - [Red](#P-Study-LabWork1-Features-Task1-RGBA-Red 'Study.LabWork1.Features.Task1.RGBA.Red')
  - [Clamp(value)](#M-Study-LabWork1-Features-Task1-RGBA-Clamp-System-Int32- 'Study.LabWork1.Features.Task1.RGBA.Clamp(System.Int32)')
  - [ClampFloat(value)](#M-Study-LabWork1-Features-Task1-RGBA-ClampFloat-System-Single- 'Study.LabWork1.Features.Task1.RGBA.ClampFloat(System.Single)')
  - [Equals(obj)](#M-Study-LabWork1-Features-Task1-RGBA-Equals-System-Object- 'Study.LabWork1.Features.Task1.RGBA.Equals(System.Object)')
  - [GetHashCode()](#M-Study-LabWork1-Features-Task1-RGBA-GetHashCode 'Study.LabWork1.Features.Task1.RGBA.GetHashCode')
  - [ToHex()](#M-Study-LabWork1-Features-Task1-RGBA-ToHex 'Study.LabWork1.Features.Task1.RGBA.ToHex')
  - [ToString()](#M-Study-LabWork1-Features-Task1-RGBA-ToString 'Study.LabWork1.Features.Task1.RGBA.ToString')
  - [op_Addition(a,b)](#M-Study-LabWork1-Features-Task1-RGBA-op_Addition-Study-LabWork1-Features-Task1-RGBA,Study-LabWork1-Features-Task1-RGBA- 'Study.LabWork1.Features.Task1.RGBA.op_Addition(Study.LabWork1.Features.Task1.RGBA,Study.LabWork1.Features.Task1.RGBA)')
  - [op_Equality(a,b)](#M-Study-LabWork1-Features-Task1-RGBA-op_Equality-Study-LabWork1-Features-Task1-RGBA,Study-LabWork1-Features-Task1-RGBA- 'Study.LabWork1.Features.Task1.RGBA.op_Equality(Study.LabWork1.Features.Task1.RGBA,Study.LabWork1.Features.Task1.RGBA)')
  - [op_Inequality(a,b)](#M-Study-LabWork1-Features-Task1-RGBA-op_Inequality-Study-LabWork1-Features-Task1-RGBA,Study-LabWork1-Features-Task1-RGBA- 'Study.LabWork1.Features.Task1.RGBA.op_Inequality(Study.LabWork1.Features.Task1.RGBA,Study.LabWork1.Features.Task1.RGBA)')
  - [op_Multiply(a,scalar)](#M-Study-LabWork1-Features-Task1-RGBA-op_Multiply-Study-LabWork1-Features-Task1-RGBA,System-Single- 'Study.LabWork1.Features.Task1.RGBA.op_Multiply(Study.LabWork1.Features.Task1.RGBA,System.Single)')
  - [op_Multiply(a,b)](#M-Study-LabWork1-Features-Task1-RGBA-op_Multiply-Study-LabWork1-Features-Task1-RGBA,Study-LabWork1-Features-Task1-RGBA- 'Study.LabWork1.Features.Task1.RGBA.op_Multiply(Study.LabWork1.Features.Task1.RGBA,Study.LabWork1.Features.Task1.RGBA)')
  - [op_Subtraction(a,b)](#M-Study-LabWork1-Features-Task1-RGBA-op_Subtraction-Study-LabWork1-Features-Task1-RGBA,Study-LabWork1-Features-Task1-RGBA- 'Study.LabWork1.Features.Task1.RGBA.op_Subtraction(Study.LabWork1.Features.Task1.RGBA,Study.LabWork1.Features.Task1.RGBA)')
- [RunService](#T-Study-LabWork1-Shared-Services-RunService 'Study.LabWork1.Shared.Services.RunService')
  - [RunTask1()](#M-Study-LabWork1-Shared-Services-RunService-RunTask1 'Study.LabWork1.Shared.Services.RunService.RunTask1')
  - [RunTask2()](#M-Study-LabWork1-Shared-Services-RunService-RunTask2 'Study.LabWork1.Shared.Services.RunService.RunTask2')
  - [RunTask3()](#M-Study-LabWork1-Shared-Services-RunService-RunTask3 'Study.LabWork1.Shared.Services.RunService.RunTask3')

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
