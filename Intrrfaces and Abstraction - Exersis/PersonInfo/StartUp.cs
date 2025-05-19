using PersonInfo;

namespace PersonInfo_
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthdate = Console.ReadLine();
            IIdentifiable personId = new Citizen(name, age, birthdate, id);
            IBirthable personBirthdate = new Citizen(name, age, birthdate, id);
            Console.WriteLine(personId.Id);
            Console.WriteLine(personBirthdate.Birthdate);
        }
    }
}
