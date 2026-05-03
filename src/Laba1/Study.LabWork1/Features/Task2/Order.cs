using System;
using System.Collections.Generic;
using System.Text;

namespace Study.LabWork1.Features.Task2
{
    /// <summary>
    /// Модель заказа
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Уникальный идентификатор заказа
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя клиента
        /// </summary>
        public string CustomerName { get; set; } = string.Empty;

        /// <summary>
        /// Общая сумма заказа
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Дата создания заказа
        /// </summary>
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Order #{Id} | {CustomerName} | {TotalAmount:C} | {OrderDate:yyyy-MM-dd}";
        }
    }
}
