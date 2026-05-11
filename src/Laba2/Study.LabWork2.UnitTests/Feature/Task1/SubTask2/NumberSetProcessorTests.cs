namespace Study.LabWork2.UnitTests.Feature.Task1.SubTask2;

using NUnit.Framework;
using System.IO;
using System.Linq;
using Study.LabWork2.Feature.Task1.SubTask2;

[TestFixture]
public class NumberSetProcessorTests
{
    private string _testFilePath;

    [SetUp]
    public void Setup()
    {
        _testFilePath = "test_numbers.txt";

        NumberSetProcessor.GenerateDataFile(_testFilePath);
    }

    [TearDown]
    public void Cleanup()
    {
        if (File.Exists(_testFilePath))
        {
            File.Delete(_testFilePath);
        }
    }

    [Test]
    public void GenerateDataFile_Creates15Sets()
    {
        string[] lines = File.ReadAllLines(_testFilePath);

        Assert.That(lines.Length, Is.EqualTo(15));
    }

    [Test]
    public void EachSet_Contains100Numbers()
    {
        string[] lines = File.ReadAllLines(_testFilePath);

        foreach (string line in lines)
        {
            int count = line
                .Split(' ', System.StringSplitOptions.RemoveEmptyEntries)
                .Length;

            Assert.That(count, Is.EqualTo(100));
        }
    }

    [Test]
    public void ProcessSets_CalculatesTotalSumCorrectly()
    {
        NumberSetProcessor processor =
            new NumberSetProcessor(_testFilePath, 3);

        processor.ProcessSets();

        int expectedSum = File.ReadAllLines(_testFilePath)
            .SelectMany(line =>
                line.Split(' ', System.StringSplitOptions.RemoveEmptyEntries))
            .Select(int.Parse)
            .Sum();

        Assert.That(processor.TotalSum, Is.EqualTo(expectedSum));
    }

    [Test]
    public void ProcessSets_Produces15Results()
    {
        NumberSetProcessor processor =
            new NumberSetProcessor(_testFilePath, 3);

        processor.ProcessSets();

        Assert.That(processor.Results.Count, Is.EqualTo(15));
    }
}
