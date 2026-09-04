using System.Globalization;
int n = 4;
string[] names = new string[n];
double[] prices = new double[n];
int[] quannitites = new int[n];
Console.WriteLine("Cafe cashier");
Console.WriteLine("_____________");
for (int i = 0; i < n; i++)
{
    Console.Write($"Product {i + 1} - name: ");
    names[i] = Console.ReadLine() ?? "";
    Console.Write($"Product {i + 1} - price: ");
    prices[i] = double.Parse(
        Console.ReadLine() ?? "0",
        CultureInfo.InvariantCulture
    );
    Console.Write($"Product {i + 1} - quantity: ");
    quannitites[i] = int.Parse(Console.ReadLine() ?? "0");
}
double subtotal = 0;
Console.WriteLine("==============================");
Console.WriteLine("           RECEIPT            ");
Console.WriteLine("==============================");
Console.WriteLine($"{"Name",-15} {"Price",8} {"Qty",5} {"Total",10}");
Console.WriteLine("------------------------------");
for (int i = 0; i < n; i++)
{
    double total = prices[i] * quannitites[i];
    subtotal += total;

    Console.WriteLine(
        $"{names[i],-15} {prices[i],8:F2} {quannitites[i],5} {total,10:F2}"
    );
}
double vat = subtotal * 0.18;
double finalTotal = subtotal + vat;

Console.WriteLine("------------------------------");
Console.WriteLine($"{"Subtotal:",-15}{subtotal,10:F2}GEL");
Console.WriteLine($"{"VAT (18%):",-15}{vat,10:F2}GEL");
Console.WriteLine($"{"Final total:",-15}{finalTotal,10:F2}GEL");
Console.WriteLine("==============================");