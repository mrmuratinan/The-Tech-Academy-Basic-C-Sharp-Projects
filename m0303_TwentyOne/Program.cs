using System;

namespace m0303TwentyOne
{
   class Program
   {
      static void Main(string[] args)
      {
         Deck deck = new Deck();
         deck = Shuffle(deck);

         for (int j = 0; j < 13; j++)
         {
            Console.Write("\n");
            for (int i = 0; i < 4; i++)
            {
               Console.Write(i + " " + j + " " + deck.Cards[j * 4 + i].Face + " of " + deck.Cards[j * 4 + i].Suit + " ");
            }
         }

      }
      public static Deck Shuffle(Deck deck)
      {
         List<Card> TempList = new List<Card>();
         Random random = new Random();
         while (deck.Cards.Count > 0)
         {
            int randomIndex = random.Next(0, deck.Cards.Count);
            TempList.Add(deck.Cards[randomIndex]);
            deck.Cards.RemoveAt(randomIndex);
         }
         deck.Cards = TempList;
         return deck;
      }

   }
}
