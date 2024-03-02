﻿using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";

        // Act
        bool actual = Email.IsValidEmail(validEmail);

        // Assert
        Assert.IsTrue(actual);
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        // Arrange
        string invalidEmail = "test";

        // Act
        bool actual = Email.IsValidEmail(invalidEmail);

        // Assert
        Assert.IsFalse(actual);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        // Arrange
        string nullInputAsEmail = string.Empty;

        // Act
        bool actual = Email.IsValidEmail(nullInputAsEmail);

        // Assert
        Assert.IsFalse(actual);
    }
}
