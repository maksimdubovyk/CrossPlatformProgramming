namespace Lab2.Tests
{
    public class GameBoardTest
    {
        [Theory]
        [InlineData(3, 2, 2)]
        [InlineData(6, 7, 1)]
        [InlineData(3, 14, 1)]
        [InlineData(9, 14, 2)]
        [InlineData(8, 12, 1)]
        public void GetResult_VariousInputs_ReturnsExpectedResult(int m, int n, int expected)
        {
            // Act
            int result = BoardGame.GetResult(m, n);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}