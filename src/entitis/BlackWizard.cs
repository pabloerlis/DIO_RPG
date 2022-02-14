namespace RPG.src.entitis
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string name, int level) : base("Black Wizard")
        {
            this.Name = name;
            this.Level = level;
            this.Hp = 300 + 30 * this.Level;
            this.Mp = 300 + 70 * this.Level;
            this.Weapon = "Staff";
            this.Skills = new string[] { "Dark Fire Ball", "Gnaw", " Vow of Silence" };
        }
    }
}