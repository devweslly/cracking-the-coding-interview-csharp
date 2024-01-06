using System.Text;

public partial class Program
{

    /*
     * Realizar a compactação básica de strings usando contagens de caracteres repetidos
     */

    #region Solução #1
    public static string CompressBad(string str)
    {
        str = str.ToUpper();

        string compressedString = "";
        int countConsecutive    = 0;

        for (int i = 0; i < str.Length; i++)
        {
            countConsecutive++;

            // If next character is different than current, append this char to result
            if (i + 1 >= str.Length || str[i] != str[i + 1])
            {
                compressedString   += "" + str[i] + countConsecutive;
                countConsecutive    = 0;
            }
        }

        string resultString = compressedString.Length < str.Length ? compressedString : str;
        return resultString;
    }
    #endregion

    #region Solução #2
    public static string Compress(string str)
    {
        str = str.ToUpper();

        StringBuilder compressed = new StringBuilder();
        int countConsecutive = 0;

        for (int i = 0; i < str.Length; i++)
        {
            countConsecutive++;

            // If next character is different than current, append this char to result
            if (i + 1 >= str.Length || str[i] != str[i + 1])
            {
                compressed.Append(str[i]);
                compressed.Append(countConsecutive);
                countConsecutive = 0;
            }
        }

        string resultString = compressed.Length < str.Length ? compressed.ToString() : str;
        return resultString;
    }
    #endregion

    #region Solução #3
    public static string CompressSolution3(string str)
    {
        str = str.ToUpper();

        // Check final length and return input string if it would be longer.
        int finallength = countCompression(str);
        if (finallength >= str.Length)
            return str;

        // initial capacity
        StringBuilder compressed    = new StringBuilder(finallength);
        int countConsecutive        = 0;

        for (int i = 0; i < str.Length; i++)
        {
            countConsecutive++;

            // If next character is different than current, append this char to result
            if (i + 1 >= str.Length || str[i] != str[i + 1])
            {
                compressed.Append(str[i]);
                compressed.Append(countConsecutive);
                countConsecutive = 0;
            }
        }

        return compressed.ToString();
    }

    private static int countCompression(string str)
    {
        int compressedLength = 0;
        int countConsecutive = 0;

        for (int i = 0; i < str.Length; i++)
        {
            countConsecutive++;

            // If next character is different than current, append this char to result
            if (i + 1 >= str.Length || str[i] != str[i + 1])
            {
                compressedLength += 1 + countConsecutive.ToString().Length;
                countConsecutive = 0;
            }
        }

        return compressedLength;
    }
    #endregion
}