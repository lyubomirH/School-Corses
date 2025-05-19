using System;

namespace EGN_Program
{
    public interface IEGNValidator
    {
        bool Validate(string egn);
        public string[] Generate(DateTime birthDate, string city, bool isMale);
    }
}