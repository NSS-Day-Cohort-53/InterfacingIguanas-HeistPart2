using System;

namespace Heist2
{
    public class LockSpecialist:IRobber
    {
    public string Name {get;set;}
    public int SkillLevel{get;set;}
    public int PercentageCut{get;set;}

     void PerformSkill (Bank bank)
        {
              bank.VaultScore -= SkillLevel;
            Console.WriteLine($"{Name } is cracking the code with a   ${SkillLevel}");
            if(bank.VaultScore<=0)
            {
                    Console.WriteLine($"{Name} has opened the vualt lets see whats inside!");
            }
        }
        //commit
    }

}