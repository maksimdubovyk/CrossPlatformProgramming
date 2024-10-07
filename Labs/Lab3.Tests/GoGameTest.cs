namespace Lab3.Tests
{
    public class GoGameTest
    {
        [Theory]
        [MemberData(nameof(BoardTestData))]
        public void CountGroupsInAtari_VariousBoards_ReturnsExpectedResult(char[][] board, int N, int expectedAtariGroups)
        {
            // Act
            int result = CountGroupsInAtari(board, N);

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
                new char[] { '.', '.', '.', '.', '.', '.' },
                new char[] { '.', 'B', '.', 'W', '.', '.' },
                new char[] { '.', 'B', 'B', 'W', '.', '.' },
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
                new char[] { '.', '.', '.', '.', '.', '.' },
                new char[] { '.', 'B', '.', 'W', '.', '.' },
                new char[] { 'B', 'B', '.', 'W', '.', '.' },
                new char[] { 'B', '.', 'B', 'W', '.', '.' },
                new char[] { '.', 'W', 'W', 'W', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '.' }
            },
            6,
            0
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
        }

        // Заглушка для методу CountGroupsInAtari
        public static int CountGroupsInAtari(char[][] board, int N)
        {
            // Реалізація методу підрахунку груп в атарі
            return 0; // Заглушка для прикладу
        }
    }
}