using System;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            int num = int.Parse(Console.ReadLine());

            Article article = new Article();

            article.Title = input[0];
            article.Content = input[1];
            article.Author = input[2];

            for (int i = 0; i < num; i++)
            {
                string[] comand = Console.ReadLine().Split(": ");

                if (comand[0] == "Edit")
                {
                    article.Edit(comand[1]);
                }

                else if (comand[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(comand[1]);
                }

                else if (comand[0] == "Rename")
                {
                    article.Rename(comand[1]);
                }
            }

            Console.WriteLine(article.ToString());

            
        }
    }

    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit (string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor (string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename (string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString ()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
