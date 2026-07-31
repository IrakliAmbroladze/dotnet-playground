namespace Georgia
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> studentGrades = new Dictionary<string, int>();
            studentGrades.Add("Giorgi", 97);
            studentGrades.Add("Ana", 84);
            studentGrades.Add("Tornike", 70);
            studentGrades.Add("Saba", 90);
            studentGrades.Add("Teona", 99);

            foreach (var student in studentGrades)
            {
                Console.WriteLine($"{student.Key}: score {student.Value}");
            }
            studentGrades.Remove("Tornike");
            Console.WriteLine("--------------");
            foreach (var student in studentGrades)
            {
                if (student.Value > 90) Console.WriteLine($"{student.Key}'s score is above 90");
            }
        }
    }
}