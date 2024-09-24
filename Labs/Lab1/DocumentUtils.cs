namespace Lab1
{
    public static class DocumentUtils
    {
        public static int ParseAndValidateNumber(string input)
        {
            if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int number) || number <= 0)
            {
                throw new ArgumentException("Невірний формат першого рядка. Очікується ціле додатне число.");
            }

            return number;
        }

        public static int[] ParseAndValidateLine(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Рядок порожній або містить тільки пробіли.");
            }

            return input.Split(' ')
                        .Select(part =>
                        {
                            if (!int.TryParse(part, out int number))
                            {
                                throw new ArgumentException("Рядок містить нечислові символи.");
                            }
                            return number;
                        })
                        .ToArray();
        }
    }
}
