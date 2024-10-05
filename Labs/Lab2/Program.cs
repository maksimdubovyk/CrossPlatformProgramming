namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..", @"..", @"..", "input.txt");

                string[] lines = File.ReadLines(filePath).Take(2).ToArray();

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

                File.WriteAllText("output.txt", result.ToString());

                Console.WriteLine("Data successfully processed and written to output.txt.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
