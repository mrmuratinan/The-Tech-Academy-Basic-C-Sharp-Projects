using System;

namespace m0303TwentyOne
{
   class Program
   {
      static void Main(string[] args)
      {
         Deck deck = new Deck();
         for (int j = 0; j < 13; j++)
         {
            Console.Write("\n");
            for (int i=0; i<4; i++)
            {
               Console.Write(i +" "+j +" "+ deck.Cards[j*4+i].Face + " of " + deck.Cards[j*4+i].Suit + " ");
            }
         }

      }
   }
}
