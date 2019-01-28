using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai.Domain
{
    public class SamuraiBattle
    {
        public int SamuraiId { get; set; }
        public Samurai Samurai { get; set; }

        public int BattleId { get; set; }
        public Battle Battle { get; set; }
        public List<SamuraiBattle> SamuraiBattles { get; set; }
    }
}
