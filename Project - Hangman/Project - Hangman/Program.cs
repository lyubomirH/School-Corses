using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http.Headers;
using static System.Net.Mime.MediaTypeNames;

namespace Project___Hangman
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            const string WinScreenText = @"
┌───────────────────────────┐
│                           │
│ WW      WW ** NN   N      │
│  WW    WW  ii NNN  N      │
│  WW WW WW  ii N NN N      │
│   WWWWWWW  ii N  NNN      │
│    WW W    ii N   NN      │
│                           │
│ Good job!                 │
│ You guessed the word!     │
└───────────────────────────┘
";
            const string LossScreenText = @"
┌────────────────────────────────────┐
│ LLL           OOOO     SSSS    SSSS│
│ LLL           OO OO   SS SS   SS SS│
│ LLL           OO OO       SS     SS│
│ LLL           OO OO    SSSS   SSSS │
│ LLL           OO OO   SS     SS    │
│ LLLLLLLLLL    OO OO   SS  SS SS  SS│
│ LLLLLLLLL     OOOO     SSSS   SSSS │
│                                    |
│ You were so close.                 │
│ Next time you will guess the word! │
└────────────────────────────────────┘
";
            string[] wrongGuessesFrames =
            {
    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"          ║   " + '\n' +
    @"          ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"          ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",


    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      |\  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"       \  ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"     / \  ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══"
            };
            string[] deathAnimation =
            {
    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"     / \  ║   " + '\n' +
    @"     ███  ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"     / \  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      o>  ║   " + '\n' +
    @"     /|   ║   " + '\n' +
    @"      >\  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"     / \  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"     <o   ║   " + '\n' +
    @"      |\  ║   " + '\n' +
    @"     /<   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"     / \  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      o>  ║   " + '\n' +
    @"     /|   ║   " + '\n' +
    @"      >\  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      o>  ║   " + '\n' +
    @"     /|   ║   " + '\n' +
    @"      >\  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"     / \  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"     <o   ║   " + '\n' +
    @"      |\  ║   " + '\n' +
    @"     /<   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"     <o   ║   " + '\n' +
    @"      |\  ║   " + '\n' +
    @"     /<   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"     <o   ║   " + '\n' +
    @"      |\  ║   " + '\n' +
    @"     /<   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"     /|\  ║   " + '\n' +
    @"     / \  ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      o   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      o   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      o   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      o   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      o   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      o   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      |   ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      /   ║   " + '\n' +
    @"      \   ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    |__   ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      .   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    \__   ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @"   ____   ║   " + '\n' +
    @"    ══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @"      .   ║   " + '\n' +
    @"    __    ║   " + '\n' +
    @"   /══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      .   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"    _ '   ║   " + '\n' +
    @"  _/══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @"      _   ║   " + '\n' +
    @" __/══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @"      .   ║   " + '\n' +
    @"          ║   " + '\n' +
    @" __/══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      .   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @" __/══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @"      _   ║   " + '\n' +
    @" __/══════╩═══",

        @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @"      .   ║   " + '\n' +
    @"          ║   " + '\n' +
    @" __/══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"      .   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @" __/══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @"      _   ║   " + '\n' +
    @" __/══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      .   ║   " + '\n' +
    @"          ║   " + '\n' +
    @" __/══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      '   ║   " + '\n' +
    @" __/══════╩═══",

    @"      ╔═══╗   " + '\n' +
    @"      |   ║   " + '\n' +
    @"      O   ║   " + '\n' +
    @"          ║   " + '\n' +
    @"          ║   " + '\n' +
    @"      _   ║   " + '\n' +
    @" __/══════╩═══"

            };
            int incorrectGuessCount = 0;
            int incorrectGuessConut = 0;

            static string[] ReadWordsFromFile()
            {
                string currentDirectory = Directory.GetCurrentDirectory();

                string projectDirectory = Directory.GetParent(currentDirectory).Parent.Parent.FullName;

                const string WordsFileName = "words.txt";

                string path = $@"{projectDirectory}\{WordsFileName}";

                string[] words = File.ReadAllLines(path);
                return words;
            }
            string[] words = ReadWordsFromFile();
            Console.CursorVisible = false;

            void DrawDeathAnimation(string[] deathAnimation)
            {
                for (int i = 0; i < deathAnimation.Length; i++)
                {
                    Console.WriteLine(deathAnimation[i]);
                    Thread.Sleep(200);
                    Console.SetCursorPosition(0, 0);
                }
            }

            bool inputIsValid;
            
            void DrawCurrentGameState(bool inputIsValid, int incorrectGuess,
                string guessedWord, List<char> playerUsedLetters)
            {
                Console.Clear();
                Console.WriteLine(wrongGuessesFrames[incorrectGuessCount]);
                Console.WriteLine($"Guess: {guessedWord}");
                Console.WriteLine($"You have to guess {guessedWord.Length} symbols.");
                Console.WriteLine($"You following letters are used: {String.Join(" ", playerUsedLetters)}");
                if(inputIsValid)
                {
                    Console.WriteLine("You should type only a single character!");
                }
                Console.Write("Your symbol: ");
            }

            void PlayGame(string word, string wordToGuess, int incorrectGuessCount, List<char> playerUsedLetters)
            {
                while (true)
                {
                    string playerInput = Console.ReadLine().ToLower();

                    if (playerInput.Length != 1)
                    {
                        DrawCurrentGameState(true, incorrectGuessCount, wordToGuess, playerUsedLetters);
                        continue;
                    }
                    char playerLetter = char.Parse(playerInput);
                    playerUsedLetters.Add(playerLetter);

                    bool playerLetterIsContained = CheckIfSymbolIsContained(word, playerLetter);
                    if (playerLetterIsContained)
                    {
                        wordToGuess = AddLetterToGuessWord(word, playerLetter, wordToGuess);
                    }
                    else
                    {
                        incorrectGuessCount++;
                    }

                    DrawCurrentGameState(false, incorrectGuessCount, wordToGuess, playerUsedLetters);
                    bool playerWins = CheckIfPlayerWins(wordToGuess);
                    if (playerWins)
                    {
                        Console.Clear();
                        Console.WriteLine(WinScreenText);
                        Console.WriteLine($"The word you guessed is [{word}].");

                        break;
                    }
                    bool playerLoses = CheckIfPlayerLoses(incorrectGuessCount);
                    if (playerLoses)
                    {
                        Console.SetCursorPosition(0, 0);
                        DrawDeathAnimation(deathAnimation);
                        Console.Clear();
                        Console.WriteLine(LossScreenText);
                        Console.WriteLine($"The exact word is [{word}].");

                        break;
                    }

                }
            }

            bool CheckIfSymbolIsContained(string word, char playerLetter)
            {
                if (!word.Contains(playerLetter))
                {
                    return false;
                }
                return true;
            }

            string AddLetterToGuessWord(string word, char playerLetter, string wordToGuess)
            {
                char[] wordToGuessCharArr = wordToGuess.ToCharArray();
                for (int i = 0; i<wordToGuess.Length; i++)
                {
                    if (playerLetter == word[i])
                    {
                        wordToGuessCharArr[i] = playerLetter;
                    }
                }
                return new string(wordToGuessCharArr);
            }

            bool CheckIfPlayerWins(string wordToGuess)
            {
                if (wordToGuess.Contains(' '))
                {
                    return false;
                }
                return true;
            }

            bool CheckIfPlayerLoses(int incorrectGuessCount)
            {
                const int MaxAllowedIncorrectCharacters = 6;
                
                if (incorrectGuessCount == MaxAllowedIncorrectCharacters)
                {
                    return true;
                }
                return false;
            }
            
            while (true)
            {
                string word = GetRandomWord(words);
                string wordToGuess = new(' ', word.Length);

                
                List<char> playerUsedLetters = new List<char>();
            
                DrawCurrentGameState(false, incorrectGuessConut, wordToGuess, playerUsedLetters);

                PlayGame(word, wordToGuess, incorrectGuessCount, playerUsedLetters);

                Console.Write("If you wnat to play again, press [Enter]. Else, type 'quit':");
                string reset = Console.ReadLine();

                if (reset == "quit")
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for playing! Hangman was closed. ");
                    return;
                }
                Console.Clear();
            }

            string GetRandomWord(string[] words)
            {
                Random random = new Random();
                string word = words[random.Next(words.Length)];
                return word.ToLower();
            }
            
        }
    }
}