using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        int[] actual = Duplicates.RemoveDuplicates(numbers);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int[] numbers = { 5, 10, 11, 1 };

        // Act
        int[] actual = Duplicates.RemoveDuplicates(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(numbers));
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        // Arrange
        int[] numbers = { 5, 10, 11, 5, 11, 60, 111 };
        int[] expected = { 5, 10, 11, 60, 111 };

        // Act
        int[] actual = Duplicates.RemoveDuplicates(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        // Arrange
        int[] numbers = { 1, 1, 1, 1, 1, 1 };
        int[] expected = { 1 };

        // Act
        int[] actual = Duplicates.RemoveDuplicates(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
        Assert.That(actual.Length == 1);
    }
}
