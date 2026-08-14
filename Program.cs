using System.Diagnostics;

static async Task<string> DownloadFileAsync(string fileName, int delayMs)
{
    await Task.Delay(delayMs);

    Random rnd = new Random();
    if (rnd.Next(1, 101) <= 30)
    {
        throw new Exception("Network error");
    }
    return $"{fileName} is downloaded";
}

Stopwatch stopwatch = Stopwatch.StartNew();
try
{
    string[] results = await Task.WhenAll(
           DownloadFileAsync("First file", 1000),
           DownloadFileAsync("Second file", 2000),
           DownloadFileAsync("Third file", 1500)
       );
    foreach (string result in results)
    {
        Console.WriteLine(result);
    }
}
catch (Exception e)
{
    Console.WriteLine($"Exception happened: {e.Message}");
}
finally
{
    stopwatch.Stop();
    Console.WriteLine($"Whole process took time of {stopwatch.ElapsedMilliseconds} ms");

}