using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    public interface IAction
    {
        public void Run(Character character, Character target);
    }

    public class AttackAction : IAction
    {
        Character target { get; set; }
        public void Run(Character character, Character target)
        {
            Console.WriteLine($"{character.Name} used {character.attack.AttackName} on {target.Name}.");
            Random random = new Random();
            int dmg = random.Next(character.attack.MinDMG, character.attack.MaxDMG + 1);
            target.CurrentHealth -= dmg;
            if (target.CurrentHealth < 0) target.CurrentHealth = 0;
            Console.WriteLine($"{target.Name} takes {dmg} damage.\n{target.Name} HP({target.CurrentHealth}/{target.MaxHealth})");
        }
    }

    public class WaitAction : IAction
    {
        public void Run(Character character, Character target)
        {
            Console.WriteLine($"{character.Name} did nothing.");
        }
    }
}
