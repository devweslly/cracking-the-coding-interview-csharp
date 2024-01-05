using System;

public partial class Program
{
    /*
     * Verificar se duas string é uma edição uma da outra
     */

    #region Solução #1
    public static bool OneEditAway(string strFirst, string strSecond)
    {
        if (strFirst.Length == strSecond.Length)
            return OneEditReplace(strFirst, strSecond);
        else if (strFirst.Length + 1 == strSecond.Length)
            return OneEditInsert(strFirst, strSecond);
        else if (strFirst.Length - 1 == strSecond.Length)
            return OneEditInsert(strSecond, strFirst);

        return false;
    }

    public static bool OneEditReplace(string strFirst, string strSecond)
    {
        bool foundDifference = false;

        for (int i = 0; i < strFirst.Length; i++)
        {
            if (strFirst[i] != strSecond[i])
            {
                if (foundDifference)
                {
                    return false;
                }
                
                foundDifference = true;
            }
        }

        return true;
    }

    public static bool OneEditInsert(string strFirst, string strSecond)
    {
        // Check if you can insert a character into strFirst to make strSecond

        int index1 = 0;
        int index2 = 0;

        while (index2 < strSecond.Length && index1 < strFirst.Length)
        {
            if (strFirst[index1] != strSecond[index2])
            {
                if (index1 != index2)
                {
                    return false;
                }
                
                index2++;
            }
            else
            {
                index1++;
                index2++;
            }
        }

        return true;        
    }
    #endregion

    #region Solução #2
    #endregion
}