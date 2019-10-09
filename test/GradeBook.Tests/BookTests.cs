using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesStats()
        {
            //Arrange
            var book = new Book("");
            book.AddGrade(97);
            book.AddGrade(78);
            book.AddGrade(92);

            //Act
            var stats = book.GetStatistics();
            //Assert
            Assert.Equal(89, stats.Average);
            Assert.Equal(97, stats.High);
            Assert.Equal(78, stats.Low);
        }
    }
}
