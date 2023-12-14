partial class Program
{
    #region Solução usando recursos da linguagem
    public static string ReplaceSpacesSimplified(string str)
    {
        string strReplace = str.Replace(" ", "%20");

        return strReplace;
    }
    #endregion

    #region Solução sem usar estruturas de dados adicionais
    public static string ReplaceSpaces(string str)
    {
        int trueLength  = str.Length;

        // Transformando uma string em um array do tipo char
        char[] chars    = new char[trueLength];
        for (int i = 0; i < trueLength; i++)
        {
            chars[i]    = str[i];
        }

        int spaceCount  = 0;
        int indexChars  = 0;
        for (; indexChars < trueLength; indexChars++)
        {
            if (chars[indexChars] == ' ')
            { 
                spaceCount++; 
            }
        }

        // Calcula o novo comprimento da string após a substituição dos espaços. 
        int index = trueLength + spaceCount * 2;

        // '\0': Representa o caractere nulo, usado para indicar o final de uma string.
        if (trueLength < chars.Length)
        {
            chars[trueLength] = '\0'; // Fim do array
        }

        char[] chars2 = new char[index];
        for (int i = 0; i < chars.Length; i++)
        {
            chars2[i] = chars[i];
        }

        /*
         * Loop percorre a string de trás para frente.
         * Se um espaço em branco é encontrado, substitui
         * o espaço e move index para trás de três posições.
         * Se não for um espaço, apenas move o caractere para a nova posição index.
         */
        for (int w = trueLength - 1; w >= 0; w--)
        {
            if (chars2[w] == ' ')
            {
                chars2[index - 1]    = '0';
                chars2[index - 2]    = '2';
                chars2[index - 3]    = '%';
                index              -= 3;
            }
            else
            {
                chars2[index - 1]    = chars2[w];
                index--;
            }
        }

        string resultReplace = String.Empty;
        for (int i = 0; i < chars2.Length; i++)
        {
            resultReplace += chars2[i];
        }

        return resultReplace;
    }
    #endregion
}