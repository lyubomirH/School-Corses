namespace Word_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\Files\words.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";
            string textFilePath = @"..\..\..\Files\text.txt";

            CalculateWordCounts(inputFilePath, textFilePath, outputFilePath);
        }
        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            using (StreamReader wordsReader = new StreamReader(wordsFilePath))
            {
                string word;
                while ((word = wordsReader.ReadLine()) != null)
                {
                    wordCounts[word.ToLower()] = 0; 
                }
            }

            using (StreamReader textReader = new StreamReader(textFilePath))
            {
                string line;
                while ((line = textReader.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        string normalizedWord = word.ToLower(); 
                        if (wordCounts.ContainsKey(normalizedWord))
                        {
                            wordCounts[normalizedWord]++;
                        }
                    }
                }
            }

            var sortedWordCounts = wordCounts.OrderByDescending(pair => pair.Value);

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (var pair in sortedWordCounts)
                {
                    writer.WriteLine($"{pair.Key}: {pair.Value}");
                }
            }

            Console.WriteLine("Word counts calculated and written to output file.");
        }
    }
}
