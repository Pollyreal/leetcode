public partial class StringSolution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        foreach (var a in ransomNote)
        {
            var index = magazine.IndexOf(a);
            if (index == -1)
            {
                return false;
            }
            else
            {
                magazine = magazine.Remove(index, 1);
            }
        }
        return true;
    }

    public bool CanConstruct1(string ransomNote, string magazine)
    {
        int[] cnt = new int[26];
        if (ransomNote.Length > magazine.Length)
        {
            return false;
        }
        foreach (var a in magazine)
        {
            cnt[a - 'a']++;
        }
        foreach (var a in ransomNote)
        {
            cnt[a - 'a']--;
            if (cnt[a - 'a'] < 0)
            {
                return false;
            }
        }
        return true;
    }
}