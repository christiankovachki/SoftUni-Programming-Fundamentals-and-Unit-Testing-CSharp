using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] evenNumbers = new int[] { 2, 4, 6, 8, 10 };

        // Act
        int result = EvenOddSubtraction.FindDifference(evenNumbers);

        // Assert
        Assert.That(result, Is.EqualTo(30));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        // Arrange
        int[] oddNumbers = new int[] { 1, 3, 5, 1 };

        // Act
        int result = EvenOddSubtraction.FindDifference(oddNumbers);

        // Assert
        Assert.That(result, Is.EqualTo(-10));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        // Act
        int result = EvenOddSubtraction.FindDifference(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
}
