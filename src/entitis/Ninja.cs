namespace RPG.src.entitis
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level) : base("Ninja")
        {
            this.Name = name;
            this.Level = level;
            this.Hp = 350 + 60 * this.Level;
            this.Mp = 250 + 40 * this.Level;
            this.Weapon = "Kukri";
            this.Skills = new string[] { "Kunai Throwing", "Shadow Steps", "Clone" };
        }
    }
}