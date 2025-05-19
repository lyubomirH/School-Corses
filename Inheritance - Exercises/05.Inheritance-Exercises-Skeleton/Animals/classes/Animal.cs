using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.classes
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private Gender gender;

        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public Gender Gender { get => gender; set => gender = value; }

        public abstract void ProduceSound();

        //public override string ToString()
        //{
        //    return $"{GetType().Name}\n{Name} {Age} {Gender}\n{ProduceSound()}";
        //}
    }
}
