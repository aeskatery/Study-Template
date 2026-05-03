using System;
using System.Collections.Generic;
using System.Text;

namespace Study.LabWork1.Features.Task2
{
    /// Порт (интерфейс) репозитория заказов.
    /// Определяет контракт для работы с хранилищем заказов.
    /// </summary>
    public interface IOrderRepository
    {
        /// <summary>
        /// Добавляет новый заказ
        /// </summary>
        void Add(Order order);

        /// <summary>
        /// Возвращает заказ по идентификатору
        /// </summary>
        Order? GetById(int id);

        /// <summary>
        /// Возвращает все заказы
        /// </summary>
        IEnumerable<Order> GetAll();

        /// <summary>
        /// Сохраняет изменения (актуально для файловых репозиториев)
        /// </summary>
        void Save();
    }
}
