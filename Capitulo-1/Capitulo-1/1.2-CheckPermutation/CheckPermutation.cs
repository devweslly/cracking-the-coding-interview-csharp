partial class Program
{
    /*
     * Verificar se duas strings é uma permutação uma da outra.
     */

    #region Usando array
    public static bool IsPermutation(string str1, string str2)
    {
        if (str1.Length != str2.Length)
            return false;

        int[] letrasCount = new int[128];
        foreach (char letra in str1)
        {
            letrasCount[letra]++;
        }

        foreach (char letra in str2)
        {
            letrasCount[letra]--;

            if (letrasCount[letra] < 0)
                return false;
        }

        return true;
    }
    #endregion

    #region Usando tabela hash (dicionário) no lugar de um array
    public static bool IsPermutationUsingDict(string str1, string str2)
    {
        if (str1.Length != str2.Length)
            return false;

        Dictionary<char, int> letrasCountDict = new Dictionary<char, int>();
        foreach (char letra in str1)
        {
            if (!letrasCountDict.ContainsKey(letra))
                letrasCountDict.Add(letra, 1);
            else
                letrasCountDict[letra]++;
        }

        foreach (char letra in str2)
        {
            if (!letrasCountDict.ContainsKey(letra))
                return false;

            if (letrasCountDict[letra] <= 0)
                return false;

            letrasCountDict[letra]--;
        }

        return true;
    }
    #endregion
}