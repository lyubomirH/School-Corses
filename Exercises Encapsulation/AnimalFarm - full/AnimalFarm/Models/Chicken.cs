﻿namespace AnimalFarm.Models
{
    public class Chicken
    {
        public const int MinAge = 0;
        public const int MaxAge = 15;

        private string name;
        private int age;

        public Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new System.ArgumentException("Name cannot be empty.");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value < MinAge || value > MaxAge)
                {
                    throw new System.ArgumentException("Age should be between 0 and 15.");
                }
                this.age = value;
            }
        }

        public double ProductPerDay
        {
            get { return this.CalculateProductPerDay(); }
        }

        private double CalculateProductPerDay()
        {
            if (this.Age <= 3) return 1.5;
            if (this.Age <= 7) return 2;
            if (this.Age <= 11) return 1;
            return 0.75;
        }
    }
}
