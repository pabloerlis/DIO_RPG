using System;

namespace RPG.src.entitis
{
    public abstract class Hero
    {
        public string HeroClass { get;}
        public string Name { get; set; }
        public int Level { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }
        public string Weapon { get; set; }
        public string[] Skills { get; set; }
        public Hero(string heroClass)
        {
            HeroClass = heroClass;
        }

        public void Attack()
        {
            Console.WriteLine($"{this.Name} attacked with {this.Weapon}!");
        }

        public void UseSkill(int skillNumber)
        {
            if (skillNumber < 1 || skillNumber > Skills.Length)
            {
                Console.WriteLine("Invalid Skill");
            }
            else
            {
                Console.WriteLine($"{this.Name} used skill {this.Skills[skillNumber - 1]}!");
            } 
        }

        public void ShowMembers()
        {
            Console.WriteLine($@"
Class Hero: {this.HeroClass}
Name: {this.Name}
Level: {this.Level}
Hp: {this.Hp}
Mp: {this.Mp}
Weapon: {this.Weapon}
Skills: {this.Skills[0]}, {this.Skills[1]}, {this.Skills[2]}");
        }

    }
}