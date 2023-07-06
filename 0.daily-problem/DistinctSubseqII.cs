public partial class Solution
{
    // distinct subseqII
    int DistinctSubseqII(string s)
    {
        Dictionary<string, string> dict = new System.Collections.Generic.Dictionary<string, string>();
        foreach (var c in s)
        {
            Console.WriteLine(c);
            dict.TryAdd(c.ToString(), c.ToString());
        }
        return dict.Count();
    }
}
    // DistinctSubseqII("abc");