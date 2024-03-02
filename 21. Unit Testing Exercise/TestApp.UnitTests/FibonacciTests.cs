using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        // Arrange
        int input = 0;

        // Act
        int actual = Fibonacci.CalculateFibonacci(input);

        // Assert
        Assert.That(actual, Is.EqualTo(input));
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        // Arrange
        int input = 5;

        // Act
        int actual = Fibonacci.CalculateFibonacci(input);

        // Assert
        Assert.That(actual, Is.EqualTo(5));
    }
}