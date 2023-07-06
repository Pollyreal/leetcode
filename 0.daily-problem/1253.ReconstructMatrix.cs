public partial class DailyProblemSolution
{
    public IList<IList<int>> ReconstructMatrix(int upper, int lower, int[] colsum)
    {
        var empty = new List<IList<int>>();
        var res = new List<IList<int>>();
        var upperArr = new int[colsum.Length];
        var lowerArr = new int[colsum.Length];
        for (int i = 0; i < colsum.Length; i++)
        {
            if (colsum[i] > 2)
            {
                return empty;
            }
            if (colsum[i] == 0)
            {
                upperArr[i] = 0;
                lowerArr[i] = 0;
            }
            if (colsum[i] == 2)
            {
                upper--;
                upperArr[i] = 1;
                lower--;
                lowerArr[i] = 1;
                colsum[i] = 0;
            }
        }
        for (int i = 0; i < colsum.Length; i++)
        {
            if (colsum[i] == 0) { continue; }
            // 赋给 upper array
            if (upper > 0 && colsum[i] > 0)
            {
                upper--;
                upperArr[i] = 1;
                colsum[i]--;
            }
            else
            {
                upperArr[i] = 0;
            }
            // 赋给 lower array
            if (lower > 0 && colsum[i] > 0)
            {
                lower--;
                lowerArr[i] = 1;
                colsum[i]--;
            }
            else
            {
                lowerArr[i] = 0;
            }
            if (colsum[i] > 0)
            {
                return empty;
            }
        }
        if (upper != 0 || lower != 0)
        {
            return empty;
        }
        else
        {
            res.Add(upperArr);
            res.Add(lowerArr);
            return res;
        }
    }
}
