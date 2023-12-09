public partial class Program
{
    /*
     * Verificar se uma string possui todos os caracteres exclusivos
     */

    #region Solução usando recursos da linguagem
    public static bool IsUnique(string str)
    {
        str = str.ToUpper();

        // Se a string for maior que 128, ela necessariamente terá caracteres repetidos
        if (str.Length > 128)
            return false;

        // Um HashSet armazena um conjunto de valores sem ordem
        // e garante que não haja duplicatas.
        HashSet<char> charSet = new HashSet<char>();

        for (int i = 0; i < str.Length; i++)
        {
            if (charSet.Contains(str[i]))
                return false;

            charSet.Add(str[i]);
        }

        return true;
    }
    #endregion
}