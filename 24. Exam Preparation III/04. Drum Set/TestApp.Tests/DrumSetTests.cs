using NUnit.Framework;
using System;

using System.Collections.Generic;

namespace TestApp.Tests;

public class DrumSetTests
{
    [Test]
    public void Test_Drum_TerminateCommandNotGiven_ThrowsArgumentException()
    {
        // Arrange
        decimal money = 1000;
        List<int> initialQuality = new List<int> { 1, 2, 3 };
        List<string> commands = new List<string> { "5", "10", "500" };

        // Act & Assert
        Assert.Throws<ArgumentException>(() => DrumSet.Drum(money, initialQuality, commands), "Terminate command not given!");
    }

    [Test]
    public void Test_Drum_StringGivenAsCommand_ThrowsArgumentException()
    {
        // Arrange
        decimal money = 1000;
        List<int> initialQuality = new List<int> { 1, 2, 3 };
        List<string> commands = new List<string> { "command" };

        // Act & Assert
        Assert.Throws<ArgumentException>(() => DrumSet.Drum(money, initialQuality, commands), "Terminate command not given!");
    }

    [Test]
    public void Test_Drum_ReturnsCorrectQualityAndAmount()
    {
        // Arrange
        decimal money = 1000;
        List<int> initialQuality = new List<int> { 1, 2, 3 };
        List<string> commands = new List<string> { "3", "5", "10", "Hit it again, Gabsy!" };

        string expected = "1 2 3\nGabsy has 946.00lv.";

        // Act
        string actual = DrumSet.Drum(money,initialQuality, commands);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Drum_BalanceZero_WithOneDrumLeftOver_ReturnsCorrectQualityAndAmount()
    {
        // Arrange
        decimal money = 0;
        List<int> initialQuality = new List<int> { 1 };
        List<string> commands = new List<string> { "Hit it again, Gabsy!" };

        string expected = "1\nGabsy has 0.00lv.";

        // Act
        string actual = DrumSet.Drum(money, initialQuality, commands);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Drum_NotEnoughBalance_RemovesAllDrums_ReturnsCorrectQualityAndAmount()
    {
        // Arrange
        decimal money = 1;
        List<int> initialQuality = new List<int> { 1, 2, 3 };
        List<string> commands = new List<string> { "5", "12", "15", "Hit it again, Gabsy!" };

        string expected = "\nGabsy has 1.00lv.";

        // Act
        string actual = DrumSet.Drum(money, initialQuality, commands);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
