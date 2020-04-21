using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumingAnAPI_Lab_15._1.Models
{
    public class Deck
    {
        public string Deck_id { get; set; }

        public Card[] Cards { get; set; }
    }

    public class Card
    {
        public string Image { get; set; }
        public string Value { get; set; }
        public string Suit { get; set; }
        public string Code { get; set; }
    }
}
