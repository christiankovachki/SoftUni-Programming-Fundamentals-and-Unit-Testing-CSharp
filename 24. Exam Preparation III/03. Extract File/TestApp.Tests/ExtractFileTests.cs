using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class ExtractFileTests
{
    [Test]
    public void Test_GetFile_NullPath_ThrowsArgumentNullException()
    {
        // Arrange
        string path = null;

        // Act & Assert
        Assert.That(() => ExtractFile.GetFile(path), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetFile_EmptyPath_ThrowsArgumentNullException()
    {
        // Arrange
        string path = string.Empty;

        // Act & Assert
        Assert.That(() => ExtractFile.GetFile(path), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetFile_ValidPath_ReturnsFileNameAndExtension()
    {
        // Arrange
        string path = "C:\\Users\\Christian\\Pictures\\Bing Images\\image.jpg";
        string expected = "File name: image\nFile extension: jpg";

        // Act
        string actual = ExtractFile.GetFile(path);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFile_PathWithNoExtension_ReturnsFileNameOnly()
    {
        // Arrange
        string path = "C:\\Users\\Christian\\Pictures\\Bing Images\\image";
        string expected = "File name: image";

        // Act
        string actual = ExtractFile.GetFile(path);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFile_PathWithSpecialCharacters_ReturnsFileNameAndExtension()
    {
        // Arrange
        string path = "C:\\Users\\Christian_\\Pictures!\\@Bing Images\\image.jpg";
        string expected = "File name: image\nFile extension: jpg";

        // Act
        string actual = ExtractFile.GetFile(path);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
