namespace Lab3.Tests
{
    public class GoGameTest
    {
        [Theory]
        [MemberData(nameof(BoardTestData))]
        public void CountGroupsInAtari_VariousBoards_ReturnsExpectedResult(char[][] board, int N, int expectedAtariGroups)
        {
            // Act
            int result = GoGame.CountGroupsInAtari(board, N);

            // Assert
            Assert.Equal(expectedAtariGroups, result);
        }

        public static IEnumerable<object[]> BoardTestData()
        {
            yield return new object[]
            {
            new char[][]
            {
                new char[] { '.', '.', '.', '.', '.', '.' },
                new char[] { '.', 'B', '.', 'W', '.', '.' },
                new char[] { '.', 'B', '.', 'W', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.' },
                new char[] { '.', 'W', 'W', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.' }
            },
            6,
            0
            };

            yield return new object[]
            {
            new char[][]
            {
                new char[] { 'B', '.', '.', '.', '.', '.' },
                new char[] { 'W', 'B', '.', 'W', '.', '.' },
                new char[] { '.', 'B', 'B', 'W', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.' },
                new char[] { '.', 'W', 'W', '.', 'W', '.' },
                new char[] { 'B', 'W', '.', '.', 'W', 'B' }
            },
            6,
            3
            };

            yield return new object[]
            {
            new char[][]
            {
                new char[] { '.', '.', '.', '.', '.', '.' },
                new char[] { '.', 'B', '.', 'W', '.', '.' },
                new char[] { 'B', 'B', 'W', 'W', '.', '.' },
                new char[] { 'B', '.', 'B', 'W', '.', '.' },
                new char[] { '.', 'W', 'W', 'W', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.' }
            },
            6,
            1
            };

            yield return new object[]
            {
            new char[][]
            {
                new char[] { '.', 'B', '.', 'W', '.', '.' },
                new char[] { '.', 'B', '.', 'W', '.', '.' },
                new char[] { '.', 'B', '.', 'W', '.', '.' },
                new char[] { '.', 'B', '.', 'W', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.' }
            },
            6,
            0
            };

            yield return new object[]
            {
            new char[][]
            {
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', 'W', 'W', '.', '.', '.' },
                new char[] { '.', '.', '.', 'B', 'W', '.', 'B', '.' },
                new char[] { 'B', '.', '.', 'W', '.', 'W', '.', '.' },
                new char[] { 'B', '.', '.', '.', 'W', 'B', 'W', '.' },
                new char[] { '.', '.', '.', '.', 'W', 'B', 'W', '.' },
                new char[] { 'W', '.', '.', '.', '.', 'B', 'W', '.' }
            },
            8,
            2
            };
        }
    }
}