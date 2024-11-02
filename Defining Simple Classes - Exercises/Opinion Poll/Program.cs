namespace Opinion_Poll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> listOfPersons = new List<Person>();
                
            for(int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split(" ").ToList();
                listOfPersons.Add(new Person(int.Parse(input[1]), input[0]) );
            }

            //listOfPersons.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList().ForEach(Console.WriteLine);
            foreach (var person in listOfPersons.Where(p=> p.Age > 30).OrderBy(p => p.Name)) 
            {
                
            }
        }
    }
}
