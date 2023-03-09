using System.Linq.Expressions;
using System.Threading;
using System.Xml.Linq;
using Core_Game;


Console.Title = "C# Player's Guide game";
bool player1AI = false;
bool player2AI = false;
int roundN = 1;
Console.WriteLine($"Choose gamemode:\n 1.Player vs Player\n 2.Player vs AI\n 3.AI vs Player\n 4.AI vs AI");
string input = Console.ReadLine();
switch(input)
{
    case "1": break;
    case "2": player2AI = true; break;
    case "3": player1AI = true; break;
    case "4": player1AI = true; player2AI = true; break;
}

Console.Write("Enter the name of a Hero. ");
string name = Console.ReadLine();

Party party1 = new Party(player1AI);
party1.AddMember(new Player(name));

Party party2 = new Party(player2AI);
for (int i = 0; i < 1; i++)
{
    party2.AddMember(new Skeleton((i+1).ToString()));
}

    Battle battle = new Battle(party1, party2);
battle.Round(roundN);

roundN++;
for (int i = 0; i < 2; i++)
{
    party2.AddMember(new Skeleton((i + 1).ToString()));
}
battle.Round(roundN);

roundN++;
party2.AddMember(new Boss());
battle.Round(roundN);


End: { }
if (party2.members.Count == 0)  Console.WriteLine("Villains are defeated.");
else                            Console.WriteLine("Heroes are defeated.");
Console.ReadKey();

