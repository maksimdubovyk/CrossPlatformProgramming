namespace Lab1
{
    public static class DocumentUtils
    {
        public static int[] ParseAndValidateLine(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException();
            }

            return input.Split(' ')
                        .Select(part =>
                        {
                            if (!int.TryParse(part, out int number))
                            {
                                throw new ArgumentOutOfRangeException();
                            }
                            return number;
                        })
                        .ToArray();
        }
    }
}
