using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class CardPicker
    {
        static Random random = new Random();

        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();
        }

        private static string RandomSuit()
        {
            // Obter um número alearório de 1 a 4
            int value = random.Next(1, 5);
            // Se for 1, retornará a string Spades
            if (value == 1) return "Spades";
            // Se for 2, retornará a string Hearts
            if (value == 2) return "Hearts";
            // Se for 3, retornará a string Clubs
            if (value == 3) return "Clubs";
            // Se ainda não retornamos, retornará a string Diamonds
            return "Diamonds";
        }
    }
}
