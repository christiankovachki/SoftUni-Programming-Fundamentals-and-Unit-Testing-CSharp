﻿using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{
    [TestCase(2.5, "Fail")]
    [TestCase(3.25, "Average")]
    [TestCase(3.75, "Good")]
    [TestCase(4.25, "Very Good")]
    [TestCase(4.75, "Excellent")]
    [TestCase(1.5, "Invalid!")]
    [TestCase(5.5, "Invalid!")]
    public void Test_GradeAsWords_ReturnsCorrectString(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestCase(2.00, "Fail")]
    [TestCase(2.99, "Fail")]
    [TestCase(3.00, "Average")]
    [TestCase(3.49, "Average")]
    [TestCase(3.50, "Good")]
    [TestCase(3.99, "Good")]
    [TestCase(4.00, "Very Good")]
    [TestCase(4.49, "Very Good")]
    [TestCase(4.50, "Excellent")]
    [TestCase(5.00, "Excellent")]
    [TestCase(5.01, "Invalid!")]
    [TestCase(1.99, "Invalid!")]
    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
