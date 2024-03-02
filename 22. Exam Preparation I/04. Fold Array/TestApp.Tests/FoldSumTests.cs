using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class FoldSumTests
{
    [TestCase(new int[0], "")]
    [TestCase(new int[] { 1 }, "")]
    [TestCase(new int[] { 1, 2 }, "")]
    [TestCase(new int[] { 1, 2, 3 }, "")]
    [TestCase(new int[] { 1, 2, 3, 4 }, "3 7")]
    public void Test_FoldArray_ReturnsCorrectString(int[] arr, string expected)
    {
        // Arrange

        // Act
        string actual = FoldSum.FoldArray(arr);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}