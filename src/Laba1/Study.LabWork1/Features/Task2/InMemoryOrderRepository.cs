using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Study.LabWork1.Features.Task2
{
    /// <summary>
    /// Адаптер для хранения заказов в оперативной памяти (In-Memory).
    /// Реализует порт <see cref="IOrderRepository"/>.
    /// </summary>
    public class InMemoryOrderRepository : IOrderRepository
    {
        private readonly List<Order> _orders = new();
        private int _nextId = 1;

        /// <inheritdoc />
        public void Add(Order order)
        {
            order.Id = _nextId++;
            _orders.Add(order);
        }

        /// <inheritdoc />
        public Order? GetById(int id)
        {
            return _orders.FirstOrDefault(o => o.Id == id);
        }

        /// <inheritdoc />
        public IEnumerable<Order> GetAll()
        {
            return _orders.ToList();
        }

        /// <inheritdoc />
        public void Save()
        {
            // Для In-Memory репозитория сохранение на диск не требуется
        }
    }
}
