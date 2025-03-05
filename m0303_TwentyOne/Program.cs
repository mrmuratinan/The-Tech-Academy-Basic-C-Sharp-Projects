using System;

namespace m0303TwentyOne
{
   class Program
   {
      static void Main(string[] args)
      {
         Deck deck = new();


         Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);
      }
   }
}
