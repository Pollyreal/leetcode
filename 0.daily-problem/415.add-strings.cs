public partial class DailyProblemSolution
{
    public string AddStrings(string num1, string num2)
    {
        var len1 = num1.Length;
        var len2 = num2.Length;
        var resLen = Math.Max(len1, len2) + 1;
        int[] ans = new int[resLen];
        int addNum = 0;

        for (int i = 0, ii = resLen - 1; i < resLen; i++, ii--)
        {
            ans[ii] += len1 - i - 1 > -1 ? num1[len1 - i - 1] - '0' : 0;
            ans[ii] += len2 - i - 1 > -1 ? num2[len2 - i - 1] - '0' : 0;
            ans[ii] += addNum;
            addNum = ans[ii] / 10;
            ans[ii] = ans[ii] % 10;
        }
        var res = string.Join("", ans).TrimStart('0');
        return string.IsNullOrEmpty(res) ? "0" : res;
    }
}
