using System;

namespace Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());


            string[,] allArticles = new string[3, num];

            int sortingRow = 0;

            for (int col = 0; col < num; col++)
            {
                string[] input = Console.ReadLine().Split(", ");

                for (int row = 0; row < 3; row++)
                {
                    allArticles[row, col] = input[row];
                }

            }

            string sortingWord = Console.ReadLine();

            if (sortingWord == "content")
            {
                sortingRow = 1;
            }

            else if (sortingWord == "author")
            {
                sortingRow = 2;
            }

            string[] toSort = new string[num];

            for (int i = 0; i < num; i++)
            {
                toSort[i] = allArticles[sortingRow, i];
            }
            Array.Sort(toSort);

            for (int i = 0; i < toSort.Length; i++)
            {
                for (int j = 0; j < toSort.Length; j++)
                {
                    if (toSort[i] == allArticles[sortingRow, j])
                    {
                        Article article = new Article();
                        article.Title = allArticles[0, j];
                        article.Content = allArticles[1, j];
                        article.Author = allArticles[2, j];
                        Console.WriteLine(article.ToString());
                    }
                }
            }
            
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }


        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
