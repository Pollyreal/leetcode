public partial class DivideAndConquerSolution
{
    // 执行用时：108 ms, 在所有 C# 提交中击败了23.94%的用户
    // 内存消耗：60.1 MB, 在所有 C# 提交中击败了5.07%的用户
    public int MajorityElement1(int[] nums)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (int n in nums)
        {
            if (!dict.Any(v => v.Key == n)) { dict.Add(n, 1); }
            else
            {
                dict[n] += 1;
            }
        }
        var max = dict.Max(a => a.Value);
        var res = dict.First(a => a.Value == max).Key;
        return res;
    }

    // 排序法
    // 执行用时：144 ms, 在所有 C# 提交中击败了6.20%的用户
    // 内存消耗：45.4 MB, 在所有 C# 提交中击败了5.07%的用户
    public int MajorityElement(int[] nums)
    {
        var list = nums.OrderBy(a => a).ToArray();
        return list[nums.Length / 2];
    }

    // 摩尔投票法

    // 分治
}