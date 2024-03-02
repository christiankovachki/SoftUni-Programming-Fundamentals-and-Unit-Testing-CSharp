using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class CharacterRangeTests
{
    [Test]
    public void Test_GetRange_WithAAndBInOrder_ReturnsEmptyString()
    {
        // Arrange
        char firstChar = 'A';
        char secondChar = 'B';

        // Act
        string actual = CharacterRange.GetRange(firstChar, secondChar);

        // Assert
        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_GetRange_WithBAndAInOrder_ReturnsEmptyString()
    {
        // Arrange
        char firstChar = 'B';
        char secondChar = 'A';

        // Act
        string actual = CharacterRange.GetRange(firstChar, secondChar);

        // Assert
        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_GetRange_WithAAndCInOrder_ReturnsB()
    {
        // Arrange
        char firstChar = 'A';
        char secondChar = 'C';

        // Act
        string actual = CharacterRange.GetRange(firstChar, secondChar);

        // Assert
        Assert.That(actual, Is.EqualTo("B"));
    }

    [Test]
    public void Test_GetRange_WithDAndGInOrder_Returns_E_F()
    {
        // Arrange
        char firstChar = 'D';
        char secondChar = 'G';

        // Act
        string actual = CharacterRange.GetRange(firstChar, secondChar);

        // Assert
        Assert.That(actual, Is.EqualTo("E F"));
    }

    [Test]
    public void Test_GetRange_WithXAndZInOrder_Returns_Y()
    {
        // Arrange
        char firstChar = 'X';
        char secondChar = 'Z';

        // Act
        string actual = CharacterRange.GetRange(firstChar, secondChar);

        // Assert
        Assert.That(actual, Is.EqualTo("Y"));
    }
}
