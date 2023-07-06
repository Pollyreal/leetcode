public partial class DailyProblemSolution
{
    public bool IsCircularSentence(string sentence)
    {
        var words = sentence.Split(" ");
        var lw = words[0][words[0].Length - 1];
        char fw;
        for (int i = 1; i < words.Length; i++)
        {
            fw = words[i][0];
            if (fw != lw)
            {
                return false;
            }
            lw = words[i][words[i].Length - 1];
        }
        char veryFirstChar = words[0][0];
        return veryFirstChar == lw;
    }
}