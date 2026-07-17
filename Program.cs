namespace Georgia
{

    class Book
    {
        public string Title = string.Empty;
        public string Author = string.Empty;

        public override string ToString()
        {
            return $"{Title} - {Author}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is Book)
            {
                Book other = (Book)obj;
                return Title == other.Title &&
                       Author == other.Author;
            }

            return false;
        }
        public override int GetHashCode()
        {
            return Title.GetHashCode();
        }

    }
    internal class Program
    {
        static void Main()
        {
            Book bookOne = new Book() { Title = "Iliad", Author = "Homer" };
            Book bookTwo = new Book() { Title = "Iliad", Author = "Homer" };
            Book bookThree = new Book() { Title = "Ulysses", Author = "James Joyce" };

            Console.WriteLine(bookOne);
            Console.WriteLine(bookTwo);
            Console.WriteLine(bookThree);

            Console.WriteLine($"Compare bookOne to bookTwo {bookOne.Equals(bookTwo)}");
            Console.WriteLine($"Compare bookOne to bookThree {bookOne.Equals(bookThree)}");
            Console.WriteLine($"Compare bookTwo to bookThree {bookTwo.Equals(bookThree)}");
            Console.WriteLine();

            Console.WriteLine($"bookOne hashCode {bookOne.GetHashCode()}");
            Console.WriteLine($"bookTwo hashCode {bookTwo.GetHashCode()}");
            Console.WriteLine($"bookThree hashCode {bookThree.GetHashCode()}");

        }
    }
}
