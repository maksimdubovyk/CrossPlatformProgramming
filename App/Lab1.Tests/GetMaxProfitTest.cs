namespace Lab1.Tests
{
    public class GetMaxProfitTest
    {
        [Fact]
        public void GetMaxProfit_TestCase1()
        {
            // Arrange
            int[] test = new int[] { 73, 31, 96, 24, 46 };

            // Act
            int result = ProfitUtils.GetMaxProfit(test);

            // Assert
            Assert.Equal(380, result);
        }

        [Fact]
        public void GetMaxProfit_TestCase2()
        {
            // Arrange
            int[] test1 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            // Act
            int result = ProfitUtils.GetMaxProfit(test1);

            // Assert
            Assert.Equal(55, result);
        }

        [Fact]
        public void GetMaxProfit_TestCase3()
        {
            // Arrange
            int[] test2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Act
            int result = ProfitUtils.GetMaxProfit(test2);

            // Assert
            Assert.Equal(100, result);
        }
        [Fact]
        public void GetMaxProfit_TestCase4()
        {
            // Arrange
            int[] test = new int[] { 15, 3, 27, 8, 20, 5, 15 };

            // Act
            int result = ProfitUtils.GetMaxProfit(test);

            // Assert
            Assert.Equal(151, result);
        }

        [Fact]
        public void GetMaxProfit_AllElementsSame()
        {
            // Arrange
            int[] test3 = new int[] { 5, 5, 5, 5, 5 };

            // Act
            int result = ProfitUtils.GetMaxProfit(test3);

            // Assert
            Assert.Equal(25, result);
        }
    }
}