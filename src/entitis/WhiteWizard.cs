namespace RPG.src.entitis
{
    public class WhiteWizard : Hero
    {
        public WhiteWizard(string name, int level) : base("White Wizard")
        {
            this.Name = name;
            this.Level = level;
            this.Hp = 250 + 25 * this.Level;
            this.Mp = 350 + 75 * this.Level;
            this.Weapon = "Staff";
            this.Skills = new string[] { "Fire Ball", "Ice Spear", "Heal" };
        }
    }
}