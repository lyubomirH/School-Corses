using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Animals.classes
{
    public class Cat : Animal
    {
        public Cat(string name, int age, Gender gender)
            : base(name, age, gender) { }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow meow");
        }
    }
}
