using NUnit.Framework;

namespace TestApp.Tests;

public class PasswordValidatorTests
{
    [Test]
    public void Test_CheckPassword_ValidPassword_ReturnsValidMessage()
    {
        // Arrange
        string password = "Pass123";
        string expected = "Password is valid";

        // Act
        string actual = PasswordValidator.CheckPassword(password);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckPassword_PasswordTooShort_ReturnsErrorMessage()
    {
        // Arrange
        string password = "short";
        string expected = "Password must be between 6 and 10 characters";

        // Act
        string actual = PasswordValidator.CheckPassword(password);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckPassword_ContainsSpecialCharacters_ReturnsErrorMessage()
    {
        // Arrange
        string password = "Inv@Pass";
        string expected = "Password must consist only of letters and digits";

        // Act
        string actual = PasswordValidator.CheckPassword(password);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckPassword_InsufficientDigits_ReturnsErrorMessage()
    {
        // Arrange
        string password = "NoDigits";
        string expected = "Password must have at least 2 digits";

        // Act
        string actual = PasswordValidator.CheckPassword(password);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckPassword_ValidPasswordWithMaximumLength_ReturnsValidMessage()
    {
        // Arrange
        string password = "ValPass123";
        string expected = "Password is valid";

        // Act
        string actual = PasswordValidator.CheckPassword(password);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
