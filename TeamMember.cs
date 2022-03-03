using System;

namespace PlanYourHeist
{
    class TeamMember
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public double CourageFactor { get; set; }

        public TeamMember(string name)
        {
            Name = name;
            Console.WriteLine("What is your skill level?");
            try
            {
                SkillLevel = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                while (ex != null)
                {
                    try
                    {
                        Console.WriteLine("Skill level should be a number without decimals. Please input again: ");
                        SkillLevel = int.Parse(Console.ReadLine());
                        // change our error to null so we can escape the loop
                        ex = null;
                    }
                    catch (FormatException newEx)
                    {
                        ex = newEx;
                    }
                }
            }
            Console.WriteLine("What is your courage level?");
            double tempCourageFactor = -1;
            CourageFactor = -1;
            while (CourageFactor == -1)
            {
                try
                {
                    tempCourageFactor = double.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    while (ex != null)
                    {
                        try
                        {
                            Console.WriteLine("Courage Factor should be a number between 0.0 and 2.0. It may include decimals. Please input again: ");
                            tempCourageFactor = double.Parse(Console.ReadLine());
                            // change our error to null so we can escape the loop
                            ex = null;
                        }
                        catch (FormatException newEx)
                        {
                            ex = newEx;
                        }
                    }
                }
                if (tempCourageFactor > 2 || tempCourageFactor < 0) {
                Console.WriteLine("Courage Factor must be between 0.0 and 2.0. Please input again: ");
                } else {
                    CourageFactor = tempCourageFactor;
                }
            }
        }
    }
}