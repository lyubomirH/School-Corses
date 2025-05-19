using PersonInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfo_
{
    public class Citizen : IPerson, IBirthable, IIdentifiable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Birthdate { get; set;}
        public string Id { get; set; }
        public Citizen(string naem, int age, string birthdate, string id)
        {
            Name = naem;
            Age = age;
            Birthdate = birthdate;
            Id = id;
        }
    }
}
