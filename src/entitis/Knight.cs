namespace RPG.src.entitis
{
    public class Knight : Hero
    {        
        public Knight(string name, int level) : base("Knight")
        {
            this.Name = name;
            this.Level = level;
            this.Hp = 500 + 80 * this.Level;
            this.Mp = 100 + 20 * this.Level;
            this.Weapon = "Sword";
            this.Skills = new string[] {"Flaming Sword", "War Cry", "Battle Chant"};
        }
    }
}