
using GoGameLibrary;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\input.txt");

                string[] lines = File.ReadLines(filePath).ToArray();

                int N = DocumentUtils.DocumentUtils.ParseAndValidateNumber(lines[0]);
                if (N < 6 || N > 19)
                {
                    throw new ArgumentException("N should be in diapason from 6 to 19.");
                }

                char[][] board = new char[N][];

                for (int i = 0; i < N; i++)
                {
                    board[i] = ParseAndValidateBoardLine(lines[i + 1], N);
                }

                int result = GoGame.CountGroupsInAtari(board, N);

                File.WriteAllText("output.txt", result.ToString());

                Console.WriteLine("Data successfully processed and written to output.txt.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static char[] ParseAndValidateBoardLine(string input, int expectedLength)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("The board line is empty or contains only spaces.");
            }

            if (input.Length != expectedLength)
            {
                throw new ArgumentException($"The board line must have exactly {expectedLength} characters.");
            }

            foreach (char c in input)
            {
                if (c != 'B' && c != 'W' && c != '.')
                {
                    throw new ArgumentException("The board line contains invalid characters. Only 'B', 'W', or '.' are allowed.");
                }
            }

            return input.ToCharArray();
        }
    }
}
