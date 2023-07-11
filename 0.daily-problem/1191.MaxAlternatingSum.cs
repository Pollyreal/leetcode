public partial class DailyProblemSolution
{
    // 1911. 最大子序列交替和

    // 思路一 好像不可行
    public int MaxAlternatingSum1(int[] arr)
    {
        NumNode firstBig = new NumNode();
        NumNode firstSmall = new NumNode();
        NumNode secondBig = new NumNode();
        int sum = 0;
        // 大小大小大
        for (int i = 0; i < arr.Length; i++)
        {
            // firstBig，firstSmall，secondBig都不存在值，获取firstBig
            // firstBig 有值，其他两个不存在，获取firstSmall
            // firstBig，firstSmall存在，获取secondBig。若找到secondBig，...
        }
        return -1;
    }

    public class NumNode
    {
        public int val;
        public bool hasValue;
    }


    // 思路二 找所有大小大小大转折点的序列号，存到列表中
    public long MaxAlternatingSum(int[] arr)
    {
        bool isAscending = true;
        List<int> checkpoints = new List<int>();
        long res = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            var originAscending = isAscending;
            isAscending = arr[i] > arr[i - 1];
            if (isAscending != originAscending)
            {
                checkpoints.Add(i - 1);
            }
            if ((i == arr.Length - 1) && isAscending)
            {
                checkpoints.Add(i);
            }
        }
        int len = checkpoints.Count();
        if (len == 0)
        {
            return arr[arr.Length - 1];
        }
        int cutLength = checkpoints.Count() % 2 == 0 ? len - 1 : len;

        for (int j = 0; j < cutLength; j++)
        {
            if (j % 2 == 0)
            {
                res += arr[checkpoints[j]];
            }
            else
            {

                res -= arr[checkpoints[j]];
            }

        }
        return res;
    }
}
