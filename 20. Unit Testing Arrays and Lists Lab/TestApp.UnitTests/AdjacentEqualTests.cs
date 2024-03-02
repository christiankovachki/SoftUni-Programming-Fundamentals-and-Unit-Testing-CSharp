using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{

    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        string actual = AdjacentEqual.Sum(emptyList);

        // Assert
        Assert.That(actual, Is.EqualTo(string.Empty));
    }


    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> ints = new List<int>() { 1, 2, 3, 4, 5};

        // Act
        string actual = AdjacentEqual.Sum(ints);

        // Assert
        Assert.That(actual, Is.EqualTo("1 2 3 4 5"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> ints = new List<int>() { 2, 2, 1, 4, 5 };

        // Act
        string actual = AdjacentEqual.Sum(ints);

        // Assert
        Assert.That(actual, Is.EqualTo("4 1 4 5"));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // Arrange
        List<int> ints = new List<int>() { 2, 2 };

        // Act
        string actual = AdjacentEqual.Sum(ints);

        // Assert
        Assert.That(actual, Is.EqualTo("4"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        // Arrange
        List<int> ints = new List<int>() { 3, 3, 2, 3 };

        // Act
        string actual = AdjacentEqual.Sum(ints);

        // Assert
        Assert.That(actual, Is.EqualTo("6 2 3"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // Arrange
        List<int> ints = new List<int>() { 1, 2, 3, 3};

        // Act
        string actual = AdjacentEqual.Sum(ints);

        // Assert
        Assert.That(actual, Is.EqualTo("1 2 6"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // Arrange
        List<int> ints = new List<int>() { 1, 3, 3, 6 };

        // Act
        string actual = AdjacentEqual.Sum(ints);

        // Assert
        Assert.That(actual, Is.EqualTo("1 6 6"));
    }
}
