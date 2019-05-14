using System;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());


            string[,] allArticles = new string[3, num];

           

            for (int col = 0; col < num; col++)
            {
                string[] input = Console.ReadLine().Split(" ");

                for (int row = 0; row < 3; row++)
                {
                    allArticles[row, col] = input[row];
                }

            }

           
            double[] toSort = new double[num];

            for (int i = 0; i < num; i++)
            {
                toSort[i] = double.Parse(allArticles[2, i]);
            }
            Array.Sort(toSort);
            Array.Reverse(toSort);

            for (int i = 0; i < toSort.Length; i++)
            {
                for (int j = 0; j < toSort.Length; j++)
                {
                    if (toSort[i] == double.Parse(allArticles[2, j]))
                    {
                        Students student = new Students();
                        student.FirstName = allArticles[0, j];
                        student.SecondName = allArticles[1, j];
                        student.Grade = double.Parse(allArticles[2, j]);
                        Console.WriteLine(student.ToString());
                    }
                }
            }
        }
    }
    class Students
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public double Grade { get; set; }


        public override string ToString()
        {
            return $"{FirstName} {SecondName}: {Grade:f2}";
        }
    }
}
