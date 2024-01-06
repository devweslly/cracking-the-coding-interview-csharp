using System;
using System.Collections.Generic;

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
    public static bool OneEditAwaySolutiion2(string strFirst, string strSecond)
    {
        // Length checks
        if (Math.Abs(strFirst.Length - strSecond.Length) > 1)
            return false;

        // Get shorter and longer string
        string str1 = strFirst.Length < strSecond.Length ? strFirst : strSecond;
        string str2 = strFirst.Length < strSecond.Length ? strSecond : strFirst;

        int index1  = 0;
        int index2  = 0;
        bool foundDifference = false;
        while (index2 < str2.Length && index1 < str1.Length)
        {
            if (str1[index1] != str2[index2])
            {
                // Ensure that this is the first difference found
                if (foundDifference)
                    return false;

                foundDifference = true;

                // On replace, move shorter pointer
                if (str1.Length == str2.Length)
                {
                    index1++;
                }
            }
            else
            {
                // If matching, move shorter pointer
                index1++;
            }

            // Always move pointer for longer string
            index2++;
        }

        return true;
    }
    #endregion
}