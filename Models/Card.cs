using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFSandbox.Models
{
    class Card
    {
        public string Suit { get; set; }
        public string Face { get; set; }
        public int Value { get; set; }
        public Card(string suit, string face, int value)
        {
            Suit = suit;
            Face = face;
            Value = value;
        }
    }
}
