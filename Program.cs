namespace HomeWork_9_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ourNumberOne = 10;
            int ourNumberTwo = 20;

            int indexOne, indexTwo;

            indexOne = FindIndex(ourNumberOne);
            indexTwo = FindIndex(ourNumberTwo);

            Console.WriteLine($"Index for the {ourNumberOne} is: {indexOne}");
            Console.WriteLine($"Index for the {ourNumberTwo} is: {indexTwo}");
        }

        static int FindIndex(int query)
        {
            int[] testArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < testArr.Length; i++)
            {
                if (testArr[i] == query)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
