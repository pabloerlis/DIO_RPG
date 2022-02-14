namespace RPG.src.entitis
{
    public class Warrior : Hero
    {
        public Warrior(string name, int level) : base("Warrior")
        {
            this.Name = name;
            this.Level = level;
            this.Hp = 550 + 90 * this.Level;
            this.Mp = 50 + 10 * this.Level;
            this.Weapon = "Axe";
            this.Skills = new string[] { "Spinning attack", "Violent Force", "Ax Throwing" };
        }
    }
}