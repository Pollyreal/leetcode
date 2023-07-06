public partial class DailyProblemSolution
{
    public int KItemsWithMaximumSum(int numOnes, int numZeros, int numNegOnes, int k)
    {
        var left = k - numOnes;
        if (left <= 0)
        {
            return k;
        }
        else
        {
            left = left - numZeros;
            if (left <= 0)
            {
                return numOnes;
            }
            else
            {
                return numOnes - left;
            }
        }
    }
}
