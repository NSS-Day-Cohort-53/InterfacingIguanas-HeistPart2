using System;

namespace Heist2
{
    public class Muscle:IRobber
    {
    public string Name {get;set;}
    public int SkillLevel{get;set;}
    public int PercentageCut{get;set;}

        void PerformSkill (Bank bank)
        {
              bank.SecurityGuardScore -= SkillLevel;
            Console.WriteLine($"{Name } is  beating up all the guards with a  ${SkillLevel}");
            if(bank.SecurityGuardScore<=0)
            {
                    Console.WriteLine($"{Name} has knocked out all the guards.");
            }
        }
        //commit
    }

}