using Study.LabWork1.Shared.Services;

namespace Study.LabWork1;

/// <summary>
/// Начальная точка входа
/// </summary>
public static class Program
{
    /// <summary>
    /// Номер выполняемой задачи
    /// </summary>
    private const int RUN_TASK_NUMBER = 2;

    /// <summary>
    /// Старт программы
    /// </summary>
    public static void Main()
    {
        var service = new RunService();

        // todo: можно переписать на ввод с консоли

        switch (RUN_TASK_NUMBER)
        {
            case 1:
                service.RunTask1();
                break;
            case 2:
                service.RunTask2();
                break;
            case 3:
                service.RunTask3();
                break;
            default:
                throw new NotSupportedException();
        }
    }
}
