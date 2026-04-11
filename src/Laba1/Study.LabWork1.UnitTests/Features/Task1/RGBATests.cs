using System;
using System.Collections.Generic;
using System.Text;
using Study.LabWork1.Features.Task1;
using NUnit.Framework;

namespace Study.LabWork1.UnitTests.Features.Task1
{
    /// <summary>
    /// Тесты
    /// </summary>
    [TestFixture]
    public class RGBATests
    {
        /// <summary>
        /// Проверяет, что значение Alpha корректно зажимается в диапазон [0,1].
        /// </summary>
        [Test]
        public void Clamp_Works()
        {
            var p = new RGBA(255, 255, 255, 2f);
            Assert.Equals(1f, p.Alpha);  // проверка, что Alpha зажато до 1
        }

        /// <summary>
        /// Проверяет, что сложение двух цветов корректно зажимает компоненты RGB и Alpha.
        /// </summary>
        [Test]
        public void Addition_ClampsCorrectly()
        {
            var a = new RGBA(250, 250, 250, 0.9f);
            var b = new RGBA(10, 10, 10, 0.5f);

            var result = a + b;

            Assert.Equals(255, result.Red);
            Assert.Equals(255, result.Green);
            Assert.Equals(255, result.Blue);
            Assert.Equals(1f, result.Alpha);
        }

        /// <summary>
        /// Проверяет корректность умножения цвета на скаляр.
        /// </summary>
        [Test]
        public void Multiplication_ByScalar_Works()
        {
            var p = new RGBA(100, 100, 100, 0.5f);
            var result = p * 2;

            Assert.Equals(200, result.Red);
        }

        /// <summary>
        /// Проверяет корректность оператора равенства ==
        /// </summary>
        [Test]
        public void Equality_Works()
        {
            var a = new RGBA(10, 20, 30, 0.5f);
            var b = new RGBA(10, 20, 30, 0.5f);

            Assert.Equals(true, a == b);
        }

        /// <summary>
        /// Проверяет корректность метода ToHex()
        /// </summary>
        [Test]
        public void ToHex_Works()
        {
            var p = new RGBA(255, 0, 0, 1);

            Assert.Equals("#FF0000", p.ToHex());
        }
    }
}
