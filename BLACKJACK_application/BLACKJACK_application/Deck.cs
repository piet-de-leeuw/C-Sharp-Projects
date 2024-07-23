﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACK_application
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Card card = new Card();
                    card.Suit = (Suit)i;
                    card.Face = (Face)j;
                    Cards.Add(card);

                }
            }

        }

        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {

            for (int i = 0; i < times; i++)
            {
                List<Card> tempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    tempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = tempList;

            }

        }
    }
}
