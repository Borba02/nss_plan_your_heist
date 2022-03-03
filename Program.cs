using System;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Team squad = new Team();
            Console.WriteLine("Plan your heist!");
            Console.WriteLine("What is your name, Comrade Member?");
            string response = Console.ReadLine();
            while (!String.IsNullOrWhiteSpace(response)) {
            TeamMember fool = new TeamMember(response);
            squad.AddTeamMember(fool);
            Console.WriteLine("What is your friend's name, Comrade member?");
            response = Console.ReadLine();
            }
            Console.WriteLine($"You have a team of {squad.GetTeamSize()}.");
            Console.WriteLine("The team is as follows: ");
            squad.DisplayMembersInfo();
        }
    }
}
