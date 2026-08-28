int[] arr = { 2, 5, 7, 8, 4 };
string[] names = { "Girogi", "Dato", "Anna", "Tornike", "Teona" };

Resize(ref arr, 10);
Resize(ref names, 3);

Console.WriteLine(string.Join(", ", arr));
Console.WriteLine(string.Join(", ", names));


static void Resize<T>(ref T[] array, int newSize)
{
    T[] newArray = new T[newSize];

    int elementsToCopy = Math.Min(array.Length, newSize);

    for (int i = 0; i < elementsToCopy; i++)
    {
        newArray[i] = array[i];
    }

    array = newArray;
}