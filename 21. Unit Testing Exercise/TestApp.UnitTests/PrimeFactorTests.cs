using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        // Arrange
        long number = 11;

        // Act
        long actual = PrimeFactor.FindLargestPrimeFactor(number);

        // Assert
        Assert.AreEqual(number, actual);
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        // Arrange
        long number = long.MaxValue;

        // Act
        long actual = PrimeFactor.FindLargestPrimeFactor(number);

        // Assert
        Assert.AreEqual(649657, actual);
    }
}
