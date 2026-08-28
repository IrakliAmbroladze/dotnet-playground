Console.Write("Please enter the length of array: ");
int input = int.Parse(Console.ReadLine());
int[] arr = new int[input];
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Please enter integer for index {i}: ");
    int arrInput = int.Parse(Console.ReadLine());
    arr[i] = arrInput;
}
Console.WriteLine("Your created array is: ");
Console.WriteLine(string.Join(", ", arr));

MergeSort(arr, 0, arr.Length - 1);
Console.WriteLine("Sorted array is: ");
Console.WriteLine(string.Join(", ", arr));


static void MergeSort(int[] arr, int left, int right)
{
    if (left < right)
    {
        int mid = (left + right) / 2;
        MergeSort(arr, left, mid);
        MergeSort(arr, mid + 1, right);
        Merge(arr, left, mid, right);
    }
}

static void Merge(int[] arr, int left, int mid, int right)
{
    int n1 = mid - left + 1;
    int n2 = right - mid;

    int[] L = new int[n1];
    int[] R = new int[n2];

    Array.Copy(arr, left, L, 0, n1);
    Array.Copy(arr, mid + 1, R, 0, n2);

    int i = 0, j = 0, k = left;

    while (i < n1 && j < n2)
    {
        if (L[i] <= R[j]) arr[k++] = L[i++];
        else arr[k++] = R[j++];
    }
    while (i < n1) arr[k++] = L[i++];
    while (j < n2) arr[k++] = R[j++];
}