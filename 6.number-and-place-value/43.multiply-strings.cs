public partial class NumberAndPlaceValueSolution
{
    /// <summary>
    /// 给定两个以字符串形式表示的非负整数 num1 和 num2，返回 num1 和 num2 的乘积，它们的乘积也表示为字符串形式。
    /// 注意：不能使用任何内置的 BigInteger 库或直接将输入转换为整数。
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public string Multiply(string num1, string num2)
    {
        var len1 = num1.Length;
        var len2 = num2.Length;
        var resLen = (len1 + 1) * (len2 + 1);
        int[] ans = new int[resLen];
        int addNum = 0;
        int bitRes = 0;
        for (int i = len1 - 1, ii = 0; i > -1; i--, ii++)
        {
            for (int j = len2 - 1, jj = 0; j > -1; j--, jj++)
            {
                bitRes = (num1[i] - '0') * (num2[j] - '0');
                Console.WriteLine($"{num1[i]}, {num2[j]}, {bitRes}");

                addNum = (ans[resLen - ii - jj - 1] + bitRes) / 10;
                ans[resLen - ii - jj - 1] = (ans[resLen - ii - jj - 1] + bitRes) % 10;
                ans[resLen - ii - jj - 2] += addNum;
            }
        }

        var res = string.Join("", ans).TrimStart('0');
        return string.IsNullOrEmpty(res)? "0": res;
    }
}