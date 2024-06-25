using System;
using Xunit;
using PalindromeChecker;
using FluentAssertions;

namespace PalindromeChecker.Tests
{
    public class CheckPalindromeFunctionTests
    {
        [Fact]
        public void CheckPallindromeFunction_IsPalindrome_WhenIsPalindrome_ReturnTrue()
        {
            // Arrange
            string testString = "deleveled";
            CheckPalindromeFunction CheckPalindrome = new CheckPalindromeFunction();

            // Act
            bool result = CheckPalindrome.IsPalindrome(testString);

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void CheckPallindromeFunction_IsPalindrome_WhenNotPalindrome_ReturnFalse()
        {
            // Arrange
            string testString = "notpalindrome";
            CheckPalindromeFunction CheckPalindrome = new CheckPalindromeFunction();

            // Act
            bool result = CheckPalindrome.IsPalindrome(testString);

            // Assert
            result.Should().BeFalse();

        }

        [Fact]
        public void CheckPallindromeFunction_IsPalindrome_WhenPalindromeIgnoringCase_ReturnTrue()
        {
            // Arrange
            string testString = "DeleveLed";
            CheckPalindromeFunction CheckPalindrome = new CheckPalindromeFunction();

            // Act
            bool result = CheckPalindrome.IsPalindrome(testString);

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void CheckPallindromeFunction_IsPalindrome_WhenSingleCharacter_ReturnTrue()
        {
            // Arrange
            string testString = "x";
            CheckPalindromeFunction CheckPalindrome = new CheckPalindromeFunction();

            // Act
            bool result = CheckPalindrome.IsPalindrome(testString);

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void CheckPallindromeFunction_IsPalindrome_WhenPalindromeIgnoringWhiteSpaces_ReturnTrue()
        {
            // Arrange
            string testString = "   d e  lev eled ";
            CheckPalindromeFunction CheckPalindrome = new CheckPalindromeFunction();

            // Act
            bool result = CheckPalindrome.IsPalindrome(testString);

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void CheckPallindromeFunction_IsPalindrome_WhenPalindromeIgnoringSpecialCharacters_ReturnTrue()
        {
            // Arrange
            string testString = "//d(e$lev^eled>";
            CheckPalindromeFunction CheckPalindrome = new CheckPalindromeFunction();

            // Act
            bool result = CheckPalindrome.IsPalindrome(testString);

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void CheckPallindromeFunction_IsPalindrome_WhenPalindromeIgnoringPunctuation_ReturnTrue()
        {
            // Arrange
            string testString = "d!e,lev'e?led.!";
            CheckPalindromeFunction CheckPalindrome = new CheckPalindromeFunction();

            // Act
            bool result = CheckPalindrome.IsPalindrome(testString);

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void CheckPallindromeFunction_IsPalindrome_WhenNumberStringPalindrome_ReturnTrue()
        {
            // Arrange
            string testString = "12221";
            CheckPalindromeFunction CheckPalindrome = new CheckPalindromeFunction();

            // Act
            bool result = CheckPalindrome.IsPalindrome(testString);

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void CheckPallindromeFunction_IsPalindrome_WhenNumberStringNotPalindrome_ReturnFalse()
        {
            // Arrange
            string testString = "12345";
            CheckPalindromeFunction CheckPalindrome = new CheckPalindromeFunction();

            // Act
            bool result = CheckPalindrome.IsPalindrome(testString);

            // Assert
            result.Should().BeFalse();
        }
    }
}
