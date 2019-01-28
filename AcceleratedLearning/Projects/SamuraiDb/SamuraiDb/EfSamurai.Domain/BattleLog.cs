using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai.Domain
{
    public class BattleLog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Battle Battle { get; set; }
        public int BattleId { get; set; }
        public List<BattleEvents> BattleEvents { get; set; }
    }
}
