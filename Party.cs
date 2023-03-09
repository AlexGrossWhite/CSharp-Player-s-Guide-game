using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Game
{
    public class Party
    {
        public bool AIactive { get; set; } = false;
        public List<Character> members { get; set; } = new List<Character>();
        public Party(bool aIactive)
        {
            AIactive = aIactive;
        }
        public void AddMember(Character character)
        {
            this.members.Add(character);
            return;
        }
    }
}
