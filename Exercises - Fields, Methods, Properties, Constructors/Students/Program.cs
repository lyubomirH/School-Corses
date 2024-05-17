namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> list = new List<Student>();
            for(int i = 0; i > n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Student student = new Student(input[1], input[2], double.Parse(input[3]));
                list.Add(student);
            }
            Console.WriteLine(list.OrderBy(l => l.grade).ToString()) ;
        }
        class Student
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public double grade {get; set; }

            public Student(string firstName, string lastName, double greade)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.grade = greade;
            }
            public override string ToString()
            {
                return $"{firstName} {lastName}: {grade:f2}"; 
            }
        }
    }
}
