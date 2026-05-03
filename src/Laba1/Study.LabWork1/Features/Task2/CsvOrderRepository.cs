using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Study.LabWork1.Features.Task2
{
    /// <summary>
    /// Адаптер для хранения заказов в CSV-файле.
    /// Реализует порт <see cref="IOrderRepository"/>.
    /// </summary>
    public class CsvOrderRepository : IOrderRepository
    {
        private readonly string _filePath;
        private readonly List<Order> _orders = new();
        private int _nextId = 1;

        /// <summary>
        /// Создаёт экземпляр репозитория с указанным путём к CSV-файлу
        /// </summary>
        /// <param name="filePath">Путь к CSV-файлу</param>
        public CsvOrderRepository(string filePath = "orders.csv")
        {
            _filePath = filePath;
            LoadFromFile();
        }

        private void LoadFromFile()
        {
            if (!File.Exists(_filePath))
                return;

            var lines = File.ReadAllLines(_filePath, Encoding.UTF8);

            foreach (var line in lines.Skip(1)) // пропускаем заголовок
            {
                var parts = line.Split(',');
                if (parts.Length < 4) continue;

                if (int.TryParse(parts[0], out int id) &&
                    decimal.TryParse(parts[2], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal amount) &&
                    DateTime.TryParse(parts[3], out DateTime date))
                {
                    var order = new Order
                    {
                        Id = id,
                        CustomerName = parts[1].Trim('"'),
                        TotalAmount = amount,
                        OrderDate = date
                    };

                    _orders.Add(order);
                    if (id >= _nextId) _nextId = id + 1;
                }
            }
        }

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
            var sb = new StringBuilder();
            sb.AppendLine("Id,CustomerName,TotalAmount,OrderDate");

            foreach (var order in _orders)
            {
                sb.AppendLine($"{order.Id},\"{order.CustomerName}\",{order.TotalAmount.ToString(CultureInfo.InvariantCulture)},{order.OrderDate:yyyy-MM-dd HH:mm:ss}");
            }

            File.WriteAllText(_filePath, sb.ToString(), Encoding.UTF8);
        }
    }
}
