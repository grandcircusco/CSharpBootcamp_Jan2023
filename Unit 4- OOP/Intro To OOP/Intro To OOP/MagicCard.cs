using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_To_OOP
{
    internal class MagicCard
    {
        public string Name { get; set; }
        public string ManaValue { get; set; }
        public string Type { get; set; }
        public string Rarity { get; set; }
        public string RulesText { get; set; }
        public string FlavorText { get; set; }
        public int cost { get; set; }
    }
}
