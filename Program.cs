using System;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist!");
            Console.WriteLine("What is your name, Comrade Member?");
            TeamMember juryB = new TeamMember();
            juryB.Name = Console.ReadLine();
            Console.WriteLine("What is your skill level?");
            juryB.SkillLevel = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your courage level?");
            juryB.CourageFactor = double.Parse(Console.ReadLine());
            Console.WriteLine($"Comrade {juryB.Name} has a skill level of {juryB.SkillLevel} and a courage factor of {juryB.CourageFactor}");
        }
    }
}
