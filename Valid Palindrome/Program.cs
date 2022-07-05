public class Solution
{
    public bool IsPalindrome(string s)
    {
        //s = s.ToLower();
        int l = 0;
        int r = s.Length - 1;

        while (l <= r)
        {
            if (Char.IsLetterOrDigit(s[l]) && Char.IsLetterOrDigit(s[r]))
            {
                if (Char.ToLower(s[l]) != Char.ToLower(s[r]))
                {
                    return false;
                }
                else
                {
                    l += 1;
                    r -= 1;
                    if (l >= r)
                    {
                        return true;
                    }
                }
            }
            if (!Char.IsLetterOrDigit(s[l])) l += 1;
            if (!Char.IsLetterOrDigit(s[r])) r -= 1;

        }
        return true;
    }

    public bool IsPalindrome2(string s)
    {
        int start = 0;
        int end = s.Length - 1;

        while (start < end)
        {
            if (!Char.IsLetterOrDigit(s[start]))
            {
                start++;
                continue;
            }

            if (!Char.IsLetterOrDigit(s[end]))
            {
                end--;
                continue;
            }

            if (Char.ToLower(s[start]) != Char.ToLower(s[end]))
            {
                return false;
            }

            start++;
            end--;
        }

        return true;
    }

    public bool IsPalindrome3(string s)
    {
        // Select each character that is a letter or digit; Convert to lower case
        var query = s.Where(c => Char.IsLetterOrDigit(c)).Select(c => Char.ToLower(c));
        var arr = query.ToArray(); // Copy array returned from query
        Array.Reverse(arr); // Reverse arr to test palindrome
                            // Using string compare against query result and reversed result
        return new string(query.ToArray()) == new string(arr);
    }

    public bool IsPalindrome4(string s)
    {
        var list = new List<char>();
        s = s.ToLower();
        foreach (var c in s)
        {
            if (char.IsLetterOrDigit(c))
                list.Add(c);
        }

        var len = list.Count;
        if (len == 0)
            return true;

        for (int i = 0; i <= len / 2; i++)
        {
            if (list[i] != list[len - 1 - i])
                return false;
        }
        return true;
    }

    static void Main()
    {
        //string s = "A man, a plan, a canal: Panama";
        string s = "0P";
        Solution sol = new Solution();
        Console.WriteLine(sol.IsPalindrome(s.ToString()));
    }

}