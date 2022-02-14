using RPG.src.entitis;
using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            var arus = new Knight("Arus", 120);
            var wedee = new Ninja("Wedee", 85);
            var jenica = new WhiteWizard("Jenica", 50);
            var topapa = new BlackWizard("Topapa", 92);
            var pabloerlis = new Warrior("Pablo Erlis", 120);
            pabloerlis.Attack();
            pabloerlis.UseSkill(1);
            arus.UseSkill(1);
            arus.ShowMembers();
            pabloerlis.ShowMembers();
        }
    }
}