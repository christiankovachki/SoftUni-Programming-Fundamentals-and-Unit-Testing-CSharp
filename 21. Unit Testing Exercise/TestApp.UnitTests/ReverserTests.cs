using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverserTests
{
    [Test]
    public void Test_ReverseStrings_WithEmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        string[] inputArray = Array.Empty<string>();

        // Act
        string[] actual = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_ReverseStrings_WithSingleString_ReturnsReversedString()
    {
        // Arrange
        string[] inputArray = { "SoftUni" };
        string[] expected = { "inUtfoS" };

        // Act
        string[] actual = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseStrings_WithMultipleStrings_ReturnsReversedStrings()
    {
        // Arrange
        string[] inputArray = { "SoftUni", "Christian", "QA", "Automation" };
        string[] expected = { "inUtfoS", "naitsirhC", "AQ", "noitamotuA" };

        // Act
        string[] actual = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseStrings_WithSpecialCharacters_ReturnsReversedSpecialCharacters()
    {
        // Arrange
        string[] inputArray = { "!@#$%", "^&*" };
        string[] expected = { "%$#@!", "*&^" };

        // Act
        string[] actual = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
