﻿using System.Text.RegularExpressions;
using System.Text;

namespace Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int messageNum = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> planetsActions = new Dictionary<string, List<string>>
            {
                ["Attacked"] = new List<string>(),
                ["Destroyed"] = new List<string>(),
            };

            StringBuilder firstStageDecrypt = new StringBuilder();

            string patternMessage = @"@(?<planet>[A-Za-z]+)([^@\-!:>])*:(?<population>[0-9]+)([^@\-!:>])*!(?<attack_type>[AD])!([^@\-!:>])*->(?<soldier_count>[0-9]+)";

            for (int i = 0; i < messageNum; i++)
            {
                string messageEncrypted = Console.ReadLine();

                int key = CountCryptoKey(messageEncrypted);

                string firstStage = DecryptFirstStage(messageEncrypted, key).ToString();

                Match decrypted = Regex.Match(firstStage, patternMessage);

                if (decrypted.Success)
                {
                    string planetName = decrypted.Groups["planet"].Value;
                    string attackType = decrypted.Groups["attack_type"].Value;

                    if (attackType == "A")
                    {
                        planetsActions["Attacked"].Add(planetName);
                    }
                    else if (attackType == "D")
                    {
                        planetsActions["Destroyed"].Add(planetName);
                    }
                }
            }

            foreach (var planet in planetsActions)
            {
                Console.WriteLine($"{planet.Key} planets: {planet.Value.Count}");

                foreach (var planets in planet.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {planets}");
                }
            }
        }
        static StringBuilder DecryptFirstStage(string message, int key)
        {
            StringBuilder firstStageDecrypt = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                firstStageDecrypt.Append((char)(message[i] - key));
            }

            return firstStageDecrypt;
        }
        static int CountCryptoKey(string message)
        {
            string pattern = @"[STARstar]";

            MatchCollection lettersKey = Regex.Matches(message, pattern);

            return lettersKey.Count();
        }
    }
}