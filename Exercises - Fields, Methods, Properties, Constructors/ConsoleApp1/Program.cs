using System.Text;

namespace Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                Article article = new Article(input[0], input[1], input[2]);
                sb.Append(article.ToString());
            }
            string output = sb.ToString();
            Console.WriteLine(output);
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string autor)
        {
            Title = title;
            Content = content;
            Author = autor;
        }
        //public string Edit(string newContent)
        //{
        //    return Content = newContent;
        //}
        //public string ChangeAuthor(string newAuthor)
        //{
        //    return Author = newAuthor;
        //}
        //public string Rename(string newTitle)
        //{
        //    return Title = newTitle;
        //}
        public override string ToString()
        {
            return $"{Title} - {Content} : {Author}\n";
        }
    }
}
