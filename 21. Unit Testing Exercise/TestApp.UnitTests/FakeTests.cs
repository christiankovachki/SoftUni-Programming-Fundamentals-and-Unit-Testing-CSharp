using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[] input = { 'c', '2', 'k', 's', 'p', '0' };
        char[] expected = { 'c', 'k', 's', 'p' };

        // Act
        char[] actual = Fake.RemoveStringNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[] input = { 'c', 'k', 's', 'p' };

        // Act
        char[] actual = Fake.RemoveStringNumbers(input);

        // Assert
        CollectionAssert.AreEqual(input, actual);
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[] input = Array.Empty<char>();

        // Act
        char[] actual = Fake.RemoveStringNumbers(input);

        // Assert
        CollectionAssert.AreEqual(input, actual);
    }
}
