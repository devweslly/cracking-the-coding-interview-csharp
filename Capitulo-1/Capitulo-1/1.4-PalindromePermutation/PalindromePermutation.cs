using System;

public partial class Program
{
    /*
     * Verificar se uma string é uma permutação de um palíndromo
     */

    #region Solução #1
    public static bool IsPermutationOfPalindrome(string phrase)
    {
        phrase          = phrase.ToLower();

        // Contando a frequencia de uma palavra
        int[] table     = BuildCharFrequencyTable(phrase);

        // Verifique se não há mais de um caractere com contagem ímpar.
        bool checkOdd   = checkMaxOneOdd(table);

        return checkOdd;
    }
        
    private static int[] BuildCharFrequencyTable(string phrase)
    {
        // cria um array com com tamanho igual à diferença entre os valores Unicode dos caracteres 'z' e 'a' + 1
        // Para que o array tenha espaço para armazenar a frequência de todos os caracteres minúsculos do alfabeto inglês.
        int[] table     = new int[(int)'z' - (int)'a' + 1];

        foreach (char caracter in phrase)
        {
            // retorna o índice do caractere na tabela table
            int caractereCount = GetCharNumber(caracter);

            // Atualização da frequência
            if (caractereCount != -1)
                table[caractereCount]++;
        }

        return table;
    }

    private static bool checkMaxOneOdd(int[] table)
    {
        bool foundOdd = false;

        foreach (int count in table)
        {
            if (count % 2 == 1)
            {
                if (foundOdd)
                    return false;
                
                foundOdd = true;
            }
        }

        return true;
    }
    #endregion

    #region Solução #2
    public static bool IsPermutationOfPalindromeSolution2(string phrase)
    {
        phrase          = phrase.ToLower();
        int countOdd    = 0;

        int[] table     = new int[(int)'z' - (int)'a' + 1];

        foreach (char caracter in phrase)
        {
            int value   = GetCharNumber(caracter);

            if (value != -1)
            {
                table[value]++;

                if (table[value] % 2 == 1)
                    countOdd++;
                else
                    countOdd--;
            }
        }

        return countOdd <= 1;
    }
    #endregion

    #region Solução #3
    public static bool IsPermutationOfPalindromeSolution3(string phrase)
    {
        // TODO: Este método está informando o resultado errado

        int bitVector = createBitVector(phrase);
        return bitVector == 0 || CheckExactlyOneBitSet(bitVector);
    }

    // Crie um vetor de bits para a string. Para cada letra com valor i, alterne o * i-ésimo bit.
    private static int createBitVector(string phrase)
    {
        int bitVector = 0;

        foreach (char caractere in phrase)
        {
            int value = GetCharNumber(caractere);
            bitVector = toggle(bitVector, value);
        }
        
        return bitVector;
    }

    // Alterne o i-ésimo bit no inteiro.
    private static int toggle(int bitVector, int index)
    {
        if (index < 0)
            return bitVector;

        int mask = 1 << index;
        if ((bitVector & mask) == 0)
            bitVector |= mask;
        else
            bitVector &= ~mask;

        return bitVector;
    }

    // Verifique se exatamente um bit está definido subtraindo um do número inteiro e aplicando AND com o número inteiro original.
    static bool CheckExactlyOneBitSet(int bitVector)
    {
        return (bitVector & (bitVector - 1)) == 0;
    }
    #endregion

    private static int GetCharNumber(char caracter)
    {
        // Armazena o valor numérico do caractere
        int aValue = (int)'a';
        int zValue = (int)'z';
        int value = (int)caracter;

        // Verifica se o valor numérico do caractere está dentro do intervalo dos caracteres minúsculos do alfabeto inglês
        if (aValue <= value && value <= zValue)
            return value - aValue;

        // Caracteres não alfabéticos são mapeados para -1
        return -1;
    }
}