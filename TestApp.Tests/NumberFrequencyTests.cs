using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class NumberFrequencyTests
{
    [Test]
    public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
    {
        // Arrange
        int zeroNumber = 0;

        // Act
        var result = NumberFrequency.CountDigits(zeroNumber);

        // Assert
        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_CountDigits_SingleDigitNumber_ReturnsDictionaryWithSingleEntry()
    {
        // Arrange
        int singleDigitNumber = 5;

        // Act
        var result = NumberFrequency.CountDigits(singleDigitNumber);

        // Assert
        Assert.AreEqual(1, result.Count);
        Assert.AreEqual(1, result[5]);
    }

    [Test]
    public void Test_CountDigits_MultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int multipleDigitNumber = 592147689;

        // Act
        var result = NumberFrequency.CountDigits(multipleDigitNumber);

        // Assert
        Assert.AreEqual(8, result.Count);
        Assert.AreEqual(1, result[5]);
        Assert.AreEqual(2, result[9]);
        Assert.AreEqual(1, result[2]);
        Assert.AreEqual(1, result[1]);
        Assert.AreEqual(1, result[4]);
        Assert.AreEqual(1, result[7]);
        Assert.AreEqual(1, result[6]);
        Assert.AreEqual(1, result[8]);
    }

    [Test]
    public void Test_CountDigits_NegativeNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int negativeNumber = -225578941;

        // Act
        var result = NumberFrequency.CountDigits(negativeNumber);

        // Assert
        Assert.AreEqual(7, result.Count);
        Assert.AreEqual(2, result[2]);
        Assert.AreEqual(2, result[5]);
        Assert.AreEqual(1, result[7]);
        Assert.AreEqual(1, result[8]);
        Assert.AreEqual(1, result[9]);
        Assert.AreEqual(1, result[4]);
        Assert.AreEqual(1, result[1]);
    }
}
