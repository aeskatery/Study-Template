using NUnit.Framework;
using Study.LabWork2.Feature.Task1.SubTask1;

namespace Study.LabWork2.UnitTests.Feature.Task1.SubTask1;

[TestFixture]
public class MutexServiceTests
{
    [Test]
    [TestCase(2, true)]
    [TestCase(3, true)]
    [TestCase(5, true)]
    [TestCase(17, true)]
    [TestCase(97, true)]
    [TestCase(113, true)]
    [TestCase(1, false)]
    [TestCase(4, false)]
    [TestCase(100, false)]
    [TestCase(0, false)]
    public void IsPrime_ReturnsCorrectResult(int number, bool expected)
    {
        bool actual = MonitorService.IsPrime(number);
        Assert.That(actual, Is.EqualTo(expected));
    }
}
