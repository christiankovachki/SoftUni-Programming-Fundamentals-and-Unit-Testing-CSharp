using NUnit.Framework;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void Test_CalculateFactorial_InputZero_ReturnsOne()
    {
        // Arrange

        // Act
        int actual = Factorial.CalculateFactorial(0);

        // Assert
        Assert.That(actual == 1);
    }

    [Test]
    public void Test_CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        // Arrange

        // Act
        int actual = Factorial.CalculateFactorial(5);

        // Assert
        Assert.That(actual == 120);
    }
}
