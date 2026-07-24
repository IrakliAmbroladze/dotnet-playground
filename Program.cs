namespace Georgia
{
    internal class Program
    {
        class Animal<T>
        {
            public T ID { get; set; }
            public void Identify()
            {
                Console.WriteLine($"Identity is {ID}");
            }
        }
        class Dog<T> : Animal<T>
        {
            public void Bark()
            {
                Console.WriteLine($"Dog with ID {ID} is barking.");
            }
        }
        class DogFixed : Animal<int>
        {
            public void Bark()
            {
                Console.WriteLine($"Dog with ID {ID} is barking.");
            }
        }
        static void Main(string[] args)
        {
            Dog<string> dog = new Dog<string>()
            {
                ID = "Poodle-001"
            };

            dog.Identify();
            dog.Bark();
            Console.WriteLine();

            DogFixed fixedDog = new DogFixed();
            fixedDog.ID = 101;

            fixedDog.Identify();
            fixedDog.Bark();
        }
    }


}