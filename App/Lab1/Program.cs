namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "input.txt");
                string input = File.ReadLines(filePath).FirstOrDefault();

                int[] numbers = DocumentUtils.ParseAndValidateLine(input);

                int result = ProfitUtils.GetMaxProfit(numbers);

                File.WriteAllText("output.txt", result.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
            //int[] test = new int[] { 73, 31, 96, 24, 46 };
            //Console.WriteLine(ProfitUtils.GetMaxProfit(test));
            //int[] test1 = new int[] { 10, 9, 8, 7 ,6, 5, 4 ,3 ,2, 1 };
            //Console.WriteLine(ProfitUtils.GetMaxProfit(test1));
            //int[] test2 = new int[] {  1, 2, 3,4,5,6,7,8,9,10 };
            //Console.WriteLine(ProfitUtils.GetMaxProfit(test2));
        }
    }
}
