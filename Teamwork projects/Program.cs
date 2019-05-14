using System;
using System.Collections.Generic;
using System.Linq;

namespace Teamwork_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());


            List<Teams> allTeams = new List<Teams>();


            for (int i = 0; i < num; i++)

            {
                List<string> teamLeaders = Console.ReadLine().Split("-").ToList();

                Teams team = new Teams
                {
                    User = teamLeaders[0],
                    TeamName = teamLeaders[1]
                };

                int checker = allTeams.Count;

                bool isUnique = true;


                for (int j = 0; j < checker; j++)
                {

                    //Дали трябва да се прекъсне на първото или да изпише и двете?
                    if (UserName(allTeams[j]) == team.User)
                    {
                        Console.WriteLine($"{team.User} cannot create another team!");
                        isUnique = false;
                    }
                    if (TeamCall(allTeams[j]) == team.TeamName)
                    {
                        Console.WriteLine($"Team {team.TeamName} was already created!");
                        isUnique = false;
                    }

                }

                if (isUnique)
                {
                    allTeams.Add(team);
                }
            }

            while (true)
            {
                List<string> teamMembers = Console.ReadLine().Split("->").ToList();

                if (teamMembers[0] == "end of assignment")
                {
                    break;
                }
                Teams newMember = new Teams();
                newMember.Members = teamMembers[0];
                newMember.TeamName = teamMembers[1];

                bool teamExist = false;

                int indexOfTeam = 0;
                for (int f = 0; f < allTeams.Count; f++)
                {
                    if (TeamCall(allTeams[f]) == newMember.TeamName)
                    {
                        teamExist = true;
                        indexOfTeam = f;
                        break;
                    }
                }
                if (teamExist)
                {
                    bool teamMemberExist = false;

                    for (int k = 0; k < allTeams.Count; k++)
                    {

                        if (TeamMembers(allTeams[k]) == newMember.Members
                            || UserName(allTeams[k]) == newMember.Members)
                        {
                            teamMemberExist = true;
                            break;
                        }

                    }
                    if (teamMemberExist)
                    {
                        Console.WriteLine($"Member {newMember.Members} cannot join team {newMember.TeamName}!");
                    }
                    else
                    {
                       allTeams[indexOfTeam].Members = newMember.Members;
                    }

                }
                else
                {
                    Console.WriteLine($"Team {newMember.TeamName} does not exist!");
                }
                
            }


            foreach (Teams t in allTeams)
            {
                Console.WriteLine(t);
            }
        }
        public static int Memberscounter(List<Teams> input)
        {
            for (int i = 0; i < input.Count; i++)
            {

            }
            return 5;
        }
        public static string UserName(Teams element)
        {
            return element.User;
        }

        public static string TeamCall(Teams element)
        {
            return element.TeamName;
        }

        public static string TeamMembers(Teams element)
        {
            return element.Members;
        }

    }
    class Teams
    {
        private List<string> _members;

        public string User { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get => _members; set => _members = value; }

        public override string ToString()
        {
            return $"{TeamName}:\n - {User}\n -- { Members}";
        }
    }
}
