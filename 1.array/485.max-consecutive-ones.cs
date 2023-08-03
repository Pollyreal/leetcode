public partial class ArraySolution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int max = 0;
        int current = 0;
        foreach (var a in nums)
        {
            current = a == 1 ? current + 1 : 0;
            max = Math.Max(current, max);
        }
        return max;
    }
}