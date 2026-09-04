Console.Write("Enter a text: ");
string text = Console.ReadLine() ?? "";

int result = CountVowels(text);

Console.WriteLine($"Result: {result}");

static int CountVowels(string s)
{
    int count = 0;

    for (int i = 0; i < s.Length; i++)
    {
        if (
            s[i] == 'a' ||
            s[i] == 'e' ||
            s[i] == 'i' ||
            s[i] == 'o' ||
            s[i] == 'u'
        )
            count++;
    }

    return count * 2;
}