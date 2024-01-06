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
        //string isPermutation    = IsPermutation("adaddgggeeee", "ddadegeggecc") ? "As strings são uma permutação" : "As strings não são uma permutação";
        //Console.WriteLine(isPermutation);
        //isPermutation           = IsPermutationUsingDict("adaddgggeeee", "ddadegegegcc") ? "As strings são uma permutação" : "As strings não são uma permutação";
        //Console.WriteLine(isPermutation);
        #endregion

        #region 1.3 URLify
        //string replaceSimplified    = ReplaceSpacesSimplified("Mr John Smith");
        //Console.WriteLine(replaceSimplified);
        //string replaceSpaces        = ReplaceSpaces("Mr John Smith");
        //Console.WriteLine(replaceSpaces);
        #endregion

        #region 1.4 Palindrome Permutation
        //string phrase = "Tact Coa";
        //Console.WriteLine($"{phrase} is permutation of palindrome: {IsPermutationOfPalindromeSolution3(phrase)}");
        #endregion

        #region 1.5 One Away
        //Console.WriteLine($"As strins são uma edição de distância: {OneEditAwaySolutiion2("pale", "dale")}");
        #endregion

        #region 1.6 String Compression
        string str = "aabcccccaaa";
        Console.WriteLine($"A compactação da string '{str}': '{CompressBad(str)}'");
        Console.WriteLine($"A compactação da string '{str}': '{Compress(str)}'");
        Console.WriteLine($"A compactação da string '{str}': '{CompressSolution3(str)}'");
        #endregion
    }
}