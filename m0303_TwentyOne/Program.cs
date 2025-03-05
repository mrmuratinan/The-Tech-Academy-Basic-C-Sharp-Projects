using System;

namespace m0303TwentyOne
{
   class Program
   {
      static void Main(string[] args)
      {
         Deck deck = new Deck();
         int timesShuffled = 0;

         deck = Shuffle(deck,out timesShuffled, 3);
         Console.WriteLine("Times shuffled: {0}", timesShuffled);

         for (int j = 0; j < 13; j++)
         {
            for (int i = 0; i < 4; i++)
            {
               Console.WriteLine(deck.Cards[j * 4 + i].Face + " of " + deck.Cards[j * 4 + i].Suit );
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
      public static Deck Shuffle(Deck deck, out int timesShuffled, int times=1) // Overloaded method with optional parameter
      {
         timesShuffled = 0;
         List<Card> TempList = new List<Card>();
         Random random = new Random();
         for (int i = 0; i < times; i++)
         {
            timesShuffled++;
            deck =Shuffle(deck);
         }
         return deck;
      }
   }
}
