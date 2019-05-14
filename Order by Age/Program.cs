using System;
using System.Collections.Generic;
using System.Linq;

namespace Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> people = new List<People>();

            while (true)
            {
                List<string> individuals = Console.ReadLine().Split(" ").ToList();

                if (individuals[0] == "End")
                {
                    break;
                }

                People person = new People();
                person.Name = individuals[0];
                person.ID = individuals[1];
                person.Age = int.Parse(individuals[2]);

                people.Add(person);
                
            }
            

            List<People> SortedList = people.OrderBy(o => o.Age).ToList();

            foreach (People individual in SortedList)
            {
                Console.WriteLine(individual);
            }
        }
       
    }
    class People
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
