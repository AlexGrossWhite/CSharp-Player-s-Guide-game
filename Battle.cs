using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    public class Battle

    {
        public Party heroes { get; set; }
        public Party villains { get; set; }

        public Battle(Party heroes, Party villains)
        {
            this.heroes = heroes;
            this.villains = villains;
        }
        public void Round(int num)
        {
            int turn = 0;
            while (heroes.members.Count > 0 && villains.members.Count > 0)
            {
                turn++;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"Round {num}. Turn {turn} ");
                Turn(heroes, villains);
                Turn(villains, heroes);
            }
            Console.WriteLine();
        }
        public void Turn(Party party1, Party party2)
        {
            foreach (var hero in party1.members)
            {
                IAction? action = new WaitAction();
                Console.WriteLine();
                Console.WriteLine($"It's {hero.Name}'s turn.");
                if (party1.AIactive == true)
                {
                    action = new AttackAction();
                }
                else
                {
                    Console.WriteLine("What to do?\n 1.Attack\n 2.Wait");
                    string input = Console.ReadLine();
                    switch (input)
                    {
                        case "1": action = new AttackAction(); break;
                        case "": action = new WaitAction(); break;
                    }
                }
                action.Run(hero, party2.members[0]);
                if (party2.members[0].CurrentHealth == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{party2.members[0].Name} is dead.");
                    Console.ForegroundColor = ConsoleColor.White;
                    party2.members.RemoveAt(0);
                }
                Thread.Sleep(500);
                if (party2.members.Count == 0) break;
            }
        }
    }
}
