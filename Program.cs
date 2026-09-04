Book Iliad = new Book("1234567891011", "Iliad", 35);
Book Odyssey = new Book("1234567891012", "Odyssey", 55);
Reader reader = new Reader("Irakli Ambroladze", "60001111111", Odyssey);
Console.WriteLine($"Reader is: {reader.Name}");
string selectedBook = reader.ChosenBook?.Title ?? "Book is not selected";
Console.WriteLine($"Chosen book: {selectedBook}");
class Book
{
    private string isbn = string.Empty;
    private string title = string.Empty;
    private decimal price = 0;
    public string ISBN
    {
        get { return isbn; }
        set
        {
            isbn = value?.Length == 13
                ? value
                : string.Empty;
        }
    }
    public string Title
    {
        get { return title; }
        set
        {
            title = value ?? string.Empty;
        }
    }
    public decimal Price
    {
        get { return price; }
        set
        {
            price = value < 0 ? 0 : value;
        }
    }
    public Book(string isbn, string title, decimal price)
    {
        ISBN = isbn;
        Title = title;
        Price = price;
    }
}
class Reader
{
    public string Name { get; set; }
    public string PID { get; set; }
    public Book? ChosenBook { get; set; }

    public Reader(string name, string id, Book? book)
    {
        Name = name;
        PID = id;
        ChosenBook = book;
    }
}