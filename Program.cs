int[] arr = { 5, 8, 2, 10, 4 };

int sum = Sum(arr, 0);

Console.WriteLine($"Sum: {sum}");


static int Sum(int[] array, int index)
{
    if (index == array.Length)
        return 0;

    return array[index] + Sum(array, index + 1);
}