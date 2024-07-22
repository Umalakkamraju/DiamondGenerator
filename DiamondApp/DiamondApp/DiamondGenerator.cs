using System.Text;

namespace DiamondApp
{
    public static class DiamondGenerator
    {
        // Method to generate the diamond
        public static string Generate(char letter)
        {
            // Return empty string if the input letter is not between 'A' and 'Z'
            if (letter < 'A' || letter > 'Z')
                return string.Empty;

            int n = letter - 'A'; // Calculate the diamond's midpoint index
            int diamondWidth = 2 * n + 1; // Calculate the width of the diamond
            var result = new StringBuilder();

            // Build the top half of the diamond (including the middle line)
            for (int i = 0; i <= n; i++)
            {
                result.AppendLine(BuildLine(i, n));
            }

            // Build the bottom half of the diamond
            for (int i = n - 1; i >= 0; i--)
            {
                result.AppendLine(BuildLine(i, n));
            }

            return result.ToString();
        }

        // Helper method to build a single line of the diamond
        private static string BuildLine(int currentLine, int maxLine)
        {
            var sb = new StringBuilder();
            int outerSpaces = maxLine - currentLine; // Calculate leading/trailing spaces
            char letter = (char)('A' + currentLine); // Determine the character for the current line

            sb.Append(' ', outerSpaces); // Append leading spaces
            sb.Append(letter); // Append the character

            // If not the first line, append inner spaces and the character again
            if (currentLine > 0)
            {
                int innerSpaces = 2 * currentLine - 1;
                sb.Append(' ', innerSpaces);
                sb.Append(letter);
            }

            sb.Append(' ', outerSpaces); // Append trailing spaces
            return sb.ToString(); // Return the constructed line as a string
        }
    }
}
