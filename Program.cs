using System;
using System.Collections.Generic;

namespace Heist2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRobber> rolodex = new List<IRobber>()
            {
                new Muscle()
                {
                    Name = "Ali",
                    SkillLevel = 99,
                    PercentageCut = 40
                },
                new Hacker()
                {
                    Name = "Nathan",
                    SkillLevel = 99,
                    PercentageCut = 45
                },
                new LockSpecialist()
                {
                    Name = "Jasmine",
                    SkillLevel = 99,
                    PercentageCut = 60
                },
                new Muscle()
                {
                    Name = "Blue42",
                    SkillLevel = 20,
                    PercentageCut = 15
                },
                new Hacker()
                {
                    Name = "Josh",
                    SkillLevel = 12,
                    PercentageCut = 5
                },
            };
            
            
            Console.WriteLine($"There are {rolodex.Count} operatives available");

            Console.WriteLine("Enter new operative name: ");
            string newOperativeName = Console.ReadLine();
            
        

            Console.WriteLine($@"Please enter a number that corresponds to the member's specialty: 
            1) Hacker (disables alarms) 2) Muscle (disarms guards) 3) LockSpecialist (cracks vaults)");
            Console.Write("Choose a specialty 1-3: ");
            int newOperativeSpecialty = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter new operative skillLevel(1-100): ");
            int newOperativeSkillLevel = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter new operative percentage cut: ");
            int newOperativeCut = int.Parse(Console.ReadLine());

            switch (newOperativeSpecialty)
            {
                case 1:
                rolodex.Add
                (
                    new Hacker
                    {
                        Name = newOperativeName,
                        SkillLevel = newOperativeSkillLevel,
                        PercentageCut = newOperativeCut
                    }
                );
                break;
                case 2:
                rolodex.Add
                (
                    new Muscle
                    {
                        Name = newOperativeName,
                        SkillLevel = newOperativeSkillLevel,
                        PercentageCut = newOperativeCut
                    }
                );
                break;
                case 3:
                rolodex.Add(
                    new LockSpecialist
                    {
                        Name = newOperativeName,
                        SkillLevel = newOperativeSkillLevel,
                        PercentageCut = newOperativeCut
                    }
                );
                break;
            }
            foreach (IRobber robber in rolodex )
            {
                Console.WriteLine(robber.Name);
            }
        }
    }

    //commit 
}
