namespace PersonLib
{
    internal class Program
    {
        class Club
        {

            int age;
            bool isAllowed;

            public int Age
            {
                get { return age; }
                set { age = value; }
            }
            public bool Allowed
            {
                get
                {

                    if (age >= 18 && age < 45)
                    {
                        return true;
                    }

                    return false;
                }
                set { isAllowed = value; }
            }
        }
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter age");
                Club club = new Club();
                int age = int.Parse(Console.ReadLine());
                club.Age = age;
                Console.WriteLine($"is {club.Age} allowed? {club.Allowed}");
                Console.WriteLine();
            }

        }
    }
}