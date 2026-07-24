namespace Georgia
{
    class Box<T>
    {
        private T? Value { get; set; }
        public Box(T value)
        {
            this.Value = value;
        }
        public void ShowValue()
        {
            Console.WriteLine($"The value is {Value}");
        }
        public bool IsEmpty() { return Value == null; }
    }


    internal class Program
    {
        static void Main()
        {
            Box<int> boxInt = new Box<int>(15);
            Box<string> boxString = new Box<string>("Hello");
            Box<double> boxDouble = new Box<double>(1.5);

            boxInt.ShowValue();
            Console.WriteLine($"Is it null? {boxInt.IsEmpty()}");
            Console.WriteLine();

            boxString.ShowValue();
            Console.WriteLine($"Is it null? {boxString.IsEmpty()}");
            Console.WriteLine();

            boxDouble.ShowValue();
            Console.WriteLine($"Is it null? {boxDouble.IsEmpty()}");
            Console.WriteLine();

        }
    }

}