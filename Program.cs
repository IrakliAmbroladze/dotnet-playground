Console.Write("Enter a text: ");
string text = Console.ReadLine() ?? "";

string result = EvenChars(text);

Console.WriteLine($"Result: {result}");

static string EvenChars(string s)
{
    string result = "";

    for (int i = 0; i < s.Length; i += 2)
    {
        result += s[i];
    }

    return result;
}