using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Roster
{
    public class Employee
    {
        private string name;
        private double salary;
        private string position;
        private string department;
        private string email;
        private int? age;

        public Employee(string name, double salary, string position, string departmenet) 
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = departmenet;
        }
        public Employee(string name, double salary, string position, string departmenet, string email) :
            this(name, salary, position, departmenet)
        {
            this.Email = email;
        }
        public Employee(string name, double salary, string position, string departmenet, string email, int age) :
            this(name, salary, position, departmenet, email)
        {
            this.Age = age;
        }
        public int? Age
        {
            get => this.age;
            set
            {
                this.age = value;
            }
        }


        public string Email
        {
            get => this.email;
            private set
            {
                this.email = value;
            }
        }
        public string Name
        {
            get => this.name;
            set
            {
                this.name = value;
            }
        }
        public double Salary
        {
            get => this.salary;
            set
            {
                this.salary = value;
            }
        }
        public string Position
        {
            get => this.position;
            set
            {
                this.position = value;
            }
        }
        public string Department
        {
            get => this.department;
            set
            {
                this.department = value;
            }
        }

    }
}
