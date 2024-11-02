﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opinion_Poll
{
    internal class Person
    {
        private string name;
        private int age;

        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int age) :this()
        {
            this.Age = age;
        }
        public Person(string name, int age) :this(age)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} - {this.Age}";
        }
    }
}
