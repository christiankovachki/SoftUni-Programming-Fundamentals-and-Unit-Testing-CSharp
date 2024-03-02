using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {
        // Arrange

        // Act & Assert (2 different Asserts, same result)
        Assert.Throws<ArgumentNullException>(() => LongestIncreasingSubsequence.GetLis(null));
        //Assert.That(() => LongestIncreasingSubsequence.GetLis(null), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        // Arrange
        int[] input = Array.Empty<int>();

        // Act
        string actual = LongestIncreasingSubsequence.GetLis(input);

        // Assert
        Assert.AreEqual(string.Empty, actual);
    }

    [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        // Arrange
        int[] input = { 5 };

        // Act
        string actual = LongestIncreasingSubsequence.GetLis(input);

        // Assert
        Assert.AreEqual("5", actual);
    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {
        // Arrange
        int[] input = { 5, 1, 2, 3, 1, 1, 2 };

        // Act
        string actual = LongestIncreasingSubsequence.GetLis(input);

        // Assert
        Assert.AreEqual("1 2 3", actual);
    }

    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {
        // Arrange
        int[] input = { 5, 6, 7, 8 };

        // Act
        string actual = LongestIncreasingSubsequence.GetLis(input);

        // Assert
        Assert.AreEqual("5 6 7 8", actual);
    }
}
