public partial class StringSolution
{
    public bool DetectCapitalUse(string word)
    {
        var count = 0;
        foreach (var c in word)
        {
            if (char.IsUpper(c))
            {
                count++;
            }
        }
        return count == 0 || count == word.Length || (count == 1 && char.IsUpper(word[0]));
    }
}