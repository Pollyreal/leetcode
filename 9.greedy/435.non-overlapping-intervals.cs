public partial class GreedySolution
{
    // unable to resolve 
    public int EraseOverlapIntervals(int[][] intervals)
    {
        int min = intervals[0][0];
        int max = 0;
        foreach (var range in intervals)
        {
            min = Math.Min(range[0], min);
            max = Math.Max(range[1], max);
        }

    }
}