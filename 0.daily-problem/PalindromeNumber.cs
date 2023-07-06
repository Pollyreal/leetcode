public partial class DailyProblemSolution
{
    // palindrome-number
    bool IsPalindrome(int x)
    {
        var reverseX = new string(x.ToString().Reverse().ToArray());
        return x.ToString().Equals(reverseX);
    }
}
// Console.WriteLine(IsPalindrome(121));
// Console.WriteLine(IsPalindrome(-121));
// Console.WriteLine(IsPalindrome(10));
// Console.WriteLine(IsPalindrome(-101));
