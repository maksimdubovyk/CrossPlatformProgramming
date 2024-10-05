namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..", @"..", @"..", "input.txt");

                string[] lines = File.ReadLines(filePath).Take(2).ToArray();

                if (lines.Length < 2)
                {
                    throw new ArgumentException("Файл повинен містити два рядки: кількість днів та ціни.");
                }

                int days = DocumentUtils.ParseAndValidateNumber(lines[0]);
                if (days < 1 || days > 100)
                {
                    throw new ArgumentException("Кількість днів вказана неправильно");
                }

                int[] prices = DocumentUtils.ParseAndValidateLine(lines[1]);

                if (prices.Length != days)
                {
                    throw new ArgumentException("Кількість цін не відповідає кількості днів.");
                }

                int result = ProfitUtils.GetMaxProfit(prices);

                File.WriteAllText("output.txt", result.ToString());

                Console.WriteLine("Дані успішно оброблено і записано у файл output.txt.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }
}
