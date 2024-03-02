using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

public class WordEraserTests
{
    [Test]
    public void Test_Erase_EmptyWordsList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string>? words = new List<string> { };
        string? wordToErase = "word";

        // Act
        WordEraser wordEraser = new WordEraser();
        string actual = wordEraser.Erase(words, wordToErase);

        // Assert
        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Erase_NullWordsList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string>? words = null;
        string? wordToErase = "word";

        // Act
        WordEraser wordEraser = new WordEraser();
        string actual = wordEraser.Erase(words, wordToErase);

        // Assert
        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Erase_NullOrEmptyWordToErase_ShouldReturnStringOfGivenWordsList()
    {
        // Arrange
        List<string>? words = new List<string> { "first word", "RaNdoM word", "Exam", "SoftUni" };
        string? wordToErase = null;
        string expected = "first word RaNdoM word Exam SoftUni";

        // Act
        WordEraser wordEraser = new WordEraser();
        string actual = wordEraser.Erase(words, wordToErase);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Erase_ValidInput_ShouldReturnEmptyString_WhenAllWordsMatchedTheWordToErase()
    {
        // Arrange
        List<string>? words = new List<string> { "Erase", "Erase", "Erase", "Erase", "Erase" };
        string? wordToErase = "Erase";

        // Act
        WordEraser wordEraser = new WordEraser();
        string actual = wordEraser.Erase(words, wordToErase);

        // Assert
        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Erase_ValidInput_ShouldReturnStringWithoutErasedWords_WhenFewOfWordsMatchedWordToArese()
    {
        // Arrange
        List<string>? words = new List<string> { "first word", "Erase", "RaNdoM word", "Exam", "SoftUni", "Erase" };
        string? wordToErase = "Erase";
        string expected = "first word RaNdoM word Exam SoftUni";

        // Act
        WordEraser wordEraser = new WordEraser();
        string actual = wordEraser.Erase(words, wordToErase);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}

