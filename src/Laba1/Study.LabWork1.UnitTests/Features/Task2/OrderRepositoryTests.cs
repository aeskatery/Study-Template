using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Study.LabWork1.Features.Task2;

namespace Study.LabWork1.UnitTests.Features.Task2
{
    /// <summary>
    /// Unit-тесты для проверки реализации паттерна Adapter с использованием порта <see cref="IOrderRepository"/>.
    /// Тестируются оба адаптера: InMemoryOrderRepository и CsvOrderRepository.
    /// </summary>
    [TestFixture]
    public class OrderRepositoryTests
    {
        /// <summary>
        /// Проверяет, что InMemoryOrderRepository корректно сохраняет заказы и возвращает их по идентификатору.
        /// </summary>
        [Test]
        public void InMemoryOrderRepository_Should_Store_And_Retrieve_Orders()
        {
            // Arrange
            var repo = new InMemoryOrderRepository();
            var order1 = new Order { CustomerName = "Тестовый Клиент 1", TotalAmount = 1000.50m };
            var order2 = new Order { CustomerName = "Тестовый Клиент 2", TotalAmount = 2500.00m };

            // Act
            repo.Add(order1);
            repo.Add(order2);

            var allOrders = repo.GetAll().ToList();
            var foundOrder = repo.GetById(1);

            // Assert
            Assert.That(allOrders.Count, Is.EqualTo(2));
            Assert.That(foundOrder, Is.Not.Null);
            Assert.That(foundOrder.CustomerName, Is.EqualTo("Тестовый Клиент 1"));
            Assert.That(foundOrder.TotalAmount, Is.EqualTo(1000.50m));
            Assert.That(foundOrder.Id, Is.EqualTo(1));
        }

        /// <summary>
        /// Проверяет, что InMemoryOrderRepository автоматически присваивает возрастающие идентификаторы заказам.
        /// </summary>
        [Test]
        public void InMemoryOrderRepository_Should_Assign_Incremental_Ids()
        {
            // Arrange
            var repo = new InMemoryOrderRepository();

            // Act
            repo.Add(new Order { CustomerName = "Клиент A" });
            repo.Add(new Order { CustomerName = "Клиент B" });
            repo.Add(new Order { CustomerName = "Клиент C" });

            var orders = repo.GetAll().ToList();

            // Assert
            Assert.That(orders[0].Id, Is.EqualTo(1));
            Assert.That(orders[1].Id, Is.EqualTo(2));
            Assert.That(orders[2].Id, Is.EqualTo(3));
        }

        /// <summary>
        /// Проверяет, что CsvOrderRepository сохраняет заказы в CSV-файл и корректно загружает их при создании нового экземпляра.
        /// </summary>
        [Test]
        public void CsvOrderRepository_Should_Save_And_Load_Orders_From_File()
        {
            // Arrange
            string testFilePath = $"test_orders_{Guid.NewGuid()}.csv";

            var repo = new CsvOrderRepository(testFilePath);

            var order1 = new Order { CustomerName = "Анна Смирнова", TotalAmount = 1500.75m };
            var order2 = new Order { CustomerName = "Пётр Иванов", TotalAmount = 3200.00m };

            // Act
            repo.Add(order1);
            repo.Add(order2);
            repo.Save();

            // Создаём новый репозиторий для проверки загрузки из файла
            var repo2 = new CsvOrderRepository(testFilePath);
            var loadedOrders = repo2.GetAll().ToList();

            // Assert
            Assert.That(loadedOrders.Count, Is.EqualTo(2));
            Assert.That(loadedOrders[0].CustomerName, Is.EqualTo("Анна Смирнова"));
            Assert.That(loadedOrders[0].TotalAmount, Is.EqualTo(1500.75m));
            Assert.That(loadedOrders[1].CustomerName, Is.EqualTo("Пётр Иванов"));
            Assert.That(loadedOrders[1].TotalAmount, Is.EqualTo(3200.00m));

            // Cleanup
            if (File.Exists(testFilePath))
                File.Delete(testFilePath);
        }

        /// <summary>
        /// Проверяет, что метод GetById возвращает null, если заказ с указанным Id не найден.
        /// </summary>
        [Test]
        public void CsvOrderRepository_Should_Return_Null_When_Order_Not_Found()
        {
            // Arrange
            var repo = new CsvOrderRepository();

            // Act
            var result = repo.GetById(999);

            // Assert
            Assert.That(result, Is.Null);
        }

        /// <summary>
        /// Проверяет, что оба адаптера реализуют интерфейс IOrderRepository.
        /// </summary>
        [Test]
        public void Both_Repositories_Should_Implement_IOrderRepository_Interface()
        {
            Assert.That(new InMemoryOrderRepository(), Is.InstanceOf<IOrderRepository>());
            Assert.That(new CsvOrderRepository(), Is.InstanceOf<IOrderRepository>());
        }

        /// <summary>
        /// Проверяет, что вызов Save() в InMemoryOrderRepository не вызывает исключений.
        /// </summary>
        [Test]
        public void InMemoryRepository_Save_Does_Not_Throw_Exception()
        {
            var repo = new InMemoryOrderRepository();

            Assert.DoesNotThrow(() => repo.Save());
        }

        /// <summary>
        /// Проверяет корректную обработку пустого CSV-файла (только заголовок).
        /// </summary>
        [Test]
        public void CsvOrderRepository_Should_Handle_Empty_File_Correctly()
        {
            // Arrange
            string emptyTestFile = $"empty_test_{Guid.NewGuid()}.csv";
            File.WriteAllText(emptyTestFile, "Id,CustomerName,TotalAmount,OrderDate\n");

            // Act
            var repo = new CsvOrderRepository(emptyTestFile);
            var orders = repo.GetAll().ToList();

            // Assert
            Assert.That(orders.Count, Is.EqualTo(0));

            // Cleanup
            if (File.Exists(emptyTestFile))
                File.Delete(emptyTestFile);
        }
    }
}
