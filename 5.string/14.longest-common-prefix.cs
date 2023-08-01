public partial class StringSolution
{
    public string LongestCommonPrefix(string[] strs)
    {
        StringBuilder stringBuilder = new StringBuilder();
        var minLen = strs[0].Length;

        foreach (var str in strs)
        {
            minLen = Math.Min(str.Length, minLen);
        }

        for (int i = 0; i < minLen; i++)
        {
            char a = strs[0][i];
            foreach (var str in strs)
            {
                if (str[i] != a)
                {
                    return stringBuilder.ToString();
                }
            }
            stringBuilder.Append(a);
        }
        return stringBuilder.ToString();
    }
}