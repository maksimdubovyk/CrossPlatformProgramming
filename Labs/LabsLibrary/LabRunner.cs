namespace LabsLibrary
{
    public class LabRunner
    {
        public void RunLab1(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadLines(inputFilePath).Take(2).ToArray();

            if (lines.Length < 2)
            {
                throw new ArgumentException("The file must contain two lines: the number of days and the prices.");
            }

            int days = DocumentUtils.DocumentUtils.ParseAndValidateNumber(lines[0]);
            if (days < 1 || days > 100)
            {
                throw new ArgumentException("The number of days is incorrect.");
            }

            int[] prices = DocumentUtils.DocumentUtils.ParseAndValidateLine(lines[1]);

            if (prices.Length != days)
            {
                throw new ArgumentException("The number of prices does not match the number of days.");
            }

            int result = ProfitUtils.GetMaxProfit(prices);

            File.WriteAllText(outputFilePath, result.ToString());

            Console.WriteLine("Data has been successfully processed and written to the output file.");
        }

        public void RunLab2(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadLines(inputFilePath).Take(2).ToArray();

            if (lines.Length != 1)
            {
                throw new ArgumentException("The file must contain one line: the coordinates of the queen.");
            }

            int[] coordinates = DocumentUtils.DocumentUtils.ParseAndValidateLine(lines[0]);

            const int coordinatesSize = 2;
            if (coordinates.Length != coordinatesSize)
            {
                throw new ArgumentException("Coordinates must consist of two numbers.");
            }

            int result = BoardGame.GetResult(coordinates[0], coordinates[1]);

            File.WriteAllText(outputFilePath, result.ToString());

            Console.WriteLine("Data successfully processed and written to output.txt.");
        }

        public void RunLab3(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadLines(inputFilePath).ToArray();

            int N = DocumentUtils.DocumentUtils.ParseAndValidateNumber(lines[0]);
            if (N < 6 || N > 19)
            {
                throw new ArgumentException("N should be in diapason from 6 to 19.");
            }

            char[][] board = new char[N][];

            for (int i = 0; i < N; i++)
            {
                board[i] = GoGame.ParseAndValidateBoardLine(lines[i + 1], N);
            }

            int result = GoGame.CountGroupsInAtari(board, N);

            File.WriteAllText(outputFilePath, result.ToString());

            Console.WriteLine("Data successfully processed and written to output.txt.");
        }
    }
}
