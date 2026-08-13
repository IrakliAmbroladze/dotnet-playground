public static class StringExtension
{
    public static bool IsPalindrome(this string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            char left = text[i];
            char right = text[text.Length - 1 - i];

            if (left != right)
                return false;
        }

        return true;
    }
}
class Program
{
    static void Main(string[] args)
    {
        string string1 = "Irakli";
        string string2 = "abba";
        string string3 = "abaa";
        Console.WriteLine(string1.IsPalindrome() ? $"{string1} is Palindrome" : $"{string1} is not Palindrome");
        Console.WriteLine(string2.IsPalindrome() ? $"{string2} is Palindrome" : $"{string2} is not Palindrome");
        Console.WriteLine(string3.IsPalindrome() ? $"{string3} is Palindrome" : $"{string3} is not Palindrome");
    }
}

