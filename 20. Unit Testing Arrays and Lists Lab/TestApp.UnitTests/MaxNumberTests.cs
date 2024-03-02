using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange
        List<int> list = new List<int>() { 5 };

        // Act
        int actual = MaxNumber.FindMax(list);

        // Assert
        Assert.AreEqual(5, actual);
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new List<int>() { 5 , 1, 10, 11, 15};

        // Act
        int actual = MaxNumber.FindMax(list);

        // Assert
        Assert.AreEqual(15, actual);
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new List<int>() { -5, -1, -10, -11, -15 };

        // Act
        int actual = MaxNumber.FindMax(list);

        // Assert
        Assert.AreEqual(-1, actual);
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new List<int>() { -5, 1, -10, 101, -10000 };

        // Act
        int actual = MaxNumber.FindMax(list);

        // Assert
        Assert.AreEqual(101, actual);
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new List<int>() { -5, 1, -10, 101, 101, -10000 };

        // Act
        int actual = MaxNumber.FindMax(list);

        // Assert
        Assert.AreEqual(101, actual);
    }
}
