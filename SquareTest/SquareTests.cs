using SquareShape;

namespace SquareTest
{
    public class SquareTests
    {
        #region Public Methods

        [Theory]
        [InlineData(2, 4)]
        [InlineData(4, 16)]
        [InlineData(8, 64)]
        public void Square_area_expected(uint side, float expected)
        {
            // Arrange
            var arg = new SquareArg { Length = side };
            var square = new Square(arg);

            // Act
            var actual = square.Area;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Square_name_expected()
        {
            // Arrange
            var arg = new SquareArg { Length = 1 };
            var square = new Square(arg);

            // Act
            var actual = square.Name;

            // Assert
            Assert.Equal("Square", actual);
        }

        #endregion Public Methods
    }
}