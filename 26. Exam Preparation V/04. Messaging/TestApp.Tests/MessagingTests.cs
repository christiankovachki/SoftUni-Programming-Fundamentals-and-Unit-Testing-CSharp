using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.Tests;

public class MessagingTests
{
    [Test]
    public void Test_GetMessage_WithValidInput_ReturnsExpectedMessage()
    {
        // Arrange
        List<int> numbers = new List<int> { 1, 2, 3 };
        string s = "Christian";

        // Act
        string actual = Messaging.GetMessage(numbers, s);

        // Assert
        Assert.That(actual, Is.EqualTo("hit"));
    }

    [Test]
    public void Test_GetMessage_EmptyList_ReturnsEmptyString()
    {
        // Arrange
        List<int> numbers = new List<int> { };
        string s = "text";

        // Act
        string actual = Messaging.GetMessage(numbers, s);

        // Assert
        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_GetMessage_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        List<int> numbers = new List<int> { 1, 2, 3 };
        string s = string.Empty;

        // Act
        string actual = Messaging.GetMessage(numbers, s);

        // Assert
        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_GetMessage_NullList_ReturnsEmptyString()
    {
        // Arrange
        List<int> numbers = null;
        string s = "text";

        // Act
        string actual = Messaging.GetMessage(numbers, s);

        // Assert
        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_GetMessage_NullString_ReturnsEmptyString()
    {
        // Arrange
        List<int> numbers = new List<int> { 1, 2, 3 };
        string s = null;

        // Act
        string actual = Messaging.GetMessage(numbers, s);

        // Assert
        Assert.That(actual, Is.EqualTo(string.Empty));
    }
}
