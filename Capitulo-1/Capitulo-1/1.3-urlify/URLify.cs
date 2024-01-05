using System.Runtime.Intrinsics.X86;

partial class Program
{
    /*
     * Substituir todos os espaços em uma string por '%20'
     */

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

        char[] newCharsArray = new char[index];
        for (int i = 0; i < chars.Length; i++)
        {
            newCharsArray[i] = chars[i];
        }

        /*
         * Loop percorre a string de trás para frente.
         * Se um espaço em branco é encontrado, substitui
         * o espaço e move index para trás de três posições.
         * Se não for um espaço, apenas move o caractere para a nova posição index.
         */
        for (int w = trueLength - 1; w >= 0; w--)
        {
            if (newCharsArray[w] == ' ')
            {
                newCharsArray[index - 1]    = '0';
                newCharsArray[index - 2]    = '2';
                newCharsArray[index - 3]    = '%';
                index                      -= 3;
            }
            else
            {
                newCharsArray[index - 1]    = newCharsArray[w];
                index--;
            }
        }

        string resultReplace = String.Empty;
        for (int i = 0; i < newCharsArray.Length; i++)
        {
            resultReplace += newCharsArray[i];
        }

        return resultReplace;
    }
    #endregion
}