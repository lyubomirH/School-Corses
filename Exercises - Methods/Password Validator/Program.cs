using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            char[] passwordWords = password.ToArray();
            bool errorCount = false;
            System.Text.Encoding.ASCII.GetString(passwordWords);
            for (int i = 0; i > passwordWords.Length; i++)
            {
                
            }
            HaveCharactersNum(passwordWords, errorCount);
            HaveNumbers(passwordWords, errorCount);
            LettersAndDigits(passwordWords, errorCount);
            if (errorCount == false) 
            {
                Console.WriteLine("Password is valid");
            }
        }
        static void HaveCharactersNum(char[] word, bool error)
        {
             
            if (word.Length >=6 && word.Length <= 10) 
            { 
            
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                error = true;
            }
        }
        static void HaveNumbers (char[] word, bool error)
        {
            
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= 48 && word[i] <= 57)
                {
                    count = count + 1;
                }
            }
            if (count !> 1 ) 
            {
                Console.WriteLine("Password must have at least 2 digits");
                error = true;
            }
        }

        static void LettersAndDigits(char[] word, bool error)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= 48 && word[i] <= 57 || word[i] >= 65 && word[i] <= 90 || word[i] >= 97 && word[i] <= 122)
                {

                }
                else
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    error = true;
                    break;
                }
            }
        }
    }
}