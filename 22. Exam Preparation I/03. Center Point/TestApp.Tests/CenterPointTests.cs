using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class CenterPointTests
{
    [Test]
    public void Test_GetClosest_WhenFirstPointIsCloser_ShouldReturnFirstPoint()
    {
        // Arrange
        double x1 = 3;
        double y1 = 2;
        double x2 = 11;
        double y2 = 4;
        string expected = "(3, 2)";

        // Act
        string actual = CenterPoint.GetClosest(x1, y1, x2, y2);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsCloser_ShouldReturnSecondPoint()
    {
        // Arrange
        double x1 = 6;
        double y1 = 5;
        double x2 = 1;
        double y2 = 8;
        string expected = "(1, 8)";

        // Act
        string actual = CenterPoint.GetClosest(x1, y1, x2, y2);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetClosest_WhenBothPointsHaveEqualDistance_ShouldReturnFirstPoint()
    {
        // Arrange
        double x1 = 2;
        double y1 = 5;
        double x2 = 2;
        double y2 = 5;
        string expected = "(2, 5)";

        // Act
        string actual = CenterPoint.GetClosest(x1, y1, x2, y2);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetClosest_WhenFirstPointIsNegative_ShouldReturnFirstPoint()
    {
        // Arrange
        double x1 = -1;
        double y1 = -2;
        double x2 = 1;
        double y2 = 2;
        string expected = "(-1, -2)";

        // Act
        string actual = CenterPoint.GetClosest(x1, y1, x2, y2);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsNegative_ShouldReturnSecondPoint()
    {
        // Arrange
        double x1 = 3;
        double y1 = 2;
        double x2 = -3;
        double y2 = -2;
        string expected = "(-3, -2)";

        // Act
        string actual = CenterPoint.GetClosest(x1, y1, x2, y2);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}