using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> listWithSingleElement = new List<int>() { 5 };

        // Act
        List<int> result = GaussTrick.SumPairs(listWithSingleElement);

        // Assert
        CollectionAssert.AreEqual(listWithSingleElement, result);
    }

    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> listWithEvenCountElements = new List<int>() { 2, 3, 1, 2 };
        List<int> expected = new List<int>() { 4, 4 };

        // Act
        List<int> result = GaussTrick.SumPairs(listWithEvenCountElements);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> listWithOddCountElements = new List<int>() { 2, 3, 5, 1, 2 };
        List<int> expected = new List<int>() { 4, 4, 5 };

        // Act
        List<int> result = GaussTrick.SumPairs(listWithOddCountElements);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> listWithEvenCountElements = new List<int>() { 2, 3, 1, 2, 1, 6, 2, 3 };
        List<int> expected = new List<int>() { 5, 5, 7, 3 };

        // Act
        List<int> result = GaussTrick.SumPairs(listWithEvenCountElements);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> listWithOddCountElements = new List<int>() { 2, 3, 5, 1, 2, 11, 2, 3, 5, 1, 2 };
        List<int> expected = new List<int>() { 4, 4, 10, 4, 4, 11 };

        // Act
        List<int> result = GaussTrick.SumPairs(listWithOddCountElements);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
