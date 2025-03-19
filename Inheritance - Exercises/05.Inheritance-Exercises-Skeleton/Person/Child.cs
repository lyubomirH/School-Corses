using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Person
{
    internal class Child : Person
    {
        public Person Mother { get; set; }
        public Person Father { get; set; }
        public Child(string name, int age, Person mother, Person father) : base(name, age)
        {
            Mother = mother;
            Father = father;
        }
        public override void PrintString()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Mother: {Mother.Name}, Father: {Father.Name}");
        }
    }
}
