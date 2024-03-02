using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> input = new List<string> { "racecar", "madam", "nun" };

        // Act
        bool actual = Palindrome.IsPalindrome(input);

        // Assert
        Assert.IsTrue(actual);
    }

    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> input = new List<string> { };

        // Act
        bool actual = Palindrome.IsPalindrome(input);

        // Assert
        Assert.IsTrue(actual);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> input = new List<string> { "racecar" };

        // Act
        bool actual = Palindrome.IsPalindrome(input);

        // Assert
        Assert.IsTrue(actual);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> input = new List<string> { "car", "guy", "SoftUni" };

        // Act
        bool actual = Palindrome.IsPalindrome(input);

        // Assert
        Assert.IsFalse(actual);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> input = new List<string> { "racECar", "madaM", "NuN" };

        // Act
        bool actual = Palindrome.IsPalindrome(input);

        // Assert
        Assert.IsTrue(actual);
    }
}
