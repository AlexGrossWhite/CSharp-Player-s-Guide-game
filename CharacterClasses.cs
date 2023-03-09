using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    public class Character
    {
        public string Name { get; init; }
        public int MaxHealth { get; init; }
        public int CurrentHealth { get; set; }
        public Attack attack { get; init; }
        public Character(string name, int maxhealth, string attackName, int mindmg, int maxdmg)
        {
            Name = name;
            MaxHealth = maxhealth;
            CurrentHealth = MaxHealth;
            attack = new Attack(attackName, mindmg, maxdmg);
        }
    }
    public class Skeleton : Character
    {
        public Skeleton(string name) : base("Skeleton " + name, 5, "Bone Crunch", 0, 1) { }
    }
    public class Boss : Character
    {
        public Boss() : base("The Uncoded One", 15, "Unraveling", 0, 2) { }
    }
    public class Player : Character
    {
        public Player(string name) : base(name, 25, "Punch", 1, 1) { }
    }
}
