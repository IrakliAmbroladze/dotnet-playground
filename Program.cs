int[] arr = { 4, 5, 7, 2 };
PrintArray(arr);
AddAtIndex(ref arr, 12, 3);
PrintArray(arr);
static void AddAtIndex<T>(ref T[] array, T value, int index)
{
    if (index < 0 || index > array.Length)
    {
        Console.WriteLine("Invalid index!");
        return;
    }
    T[] newArray = new T[array.Length + 1];
    for (int i = 0; i < index; i++)
        newArray[i] = array[i];
    newArray[index] = value;
    for (int i = index; i < array.Length; i++)
        newArray[i + 1] = array[i];
    array = newArray;
}
static void PrintArray<T>(T[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }

    Console.WriteLine("________________");
}