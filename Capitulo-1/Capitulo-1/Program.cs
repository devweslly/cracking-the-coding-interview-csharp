public partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Soluções para arrays e strings");

        #region 1.1 Is Unique
        //string isUnique   = IsUnique("Weslly") ? "A string tem caracteres exclusivos" : "A string não tem caracteres exclusivos";
        //Console.WriteLine(isUnique);
        #endregion

        #region 1.2 Check Permutation
        string isPermutation    = IsPermutation("adaddgggeeee", "ddadegeggecc") ? "As strings são uma permutação" : "As strings não são uma permutação";
        Console.WriteLine(isPermutation);
        isPermutation           = IsPermutationUsingDict("adaddgggeeee", "ddadegegegcc") ? "As strings são uma permutação" : "As strings não são uma permutação";
        Console.WriteLine(isPermutation);
        #endregion

    }
}