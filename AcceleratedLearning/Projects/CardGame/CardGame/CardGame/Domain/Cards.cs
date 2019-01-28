using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.Domain
{
    public class Cards
    {

        public int Values { get; set; }
        public enum Suits
        {
            Hearts,
            Diamonds,
            Clubs,
            Spades
        }

    }
}
