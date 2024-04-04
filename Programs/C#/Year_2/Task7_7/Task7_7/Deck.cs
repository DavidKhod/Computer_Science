using System;
using System.Collections.Generic;

namespace Task7_7
{
    internal class Deck
    {
        Queue<Card> cards;

        public Deck()
        {
            cards = new Queue<Card>();
        }

        private static Random rnd = new Random();
        public Deck(int n)
        {
            cards = new Queue<Card>();
            string[] types = { "Dimonds", "Clubs", "Hearts", "Spades" };
            for (int i = 0; i < n; i++)
            {
                cards.Insert(new Card(rnd.Next(13), types[rnd.Next(types.Length)]));
            }
        }

        public void AddCard(Card card) 
        {
            cards.Insert(card);
        }

        public bool IsEmpty()
        {
            return cards.IsEmpty();
        }

        public Card GetCard()
        {
            return cards.Remove();
        }

        public override string ToString()
        {
            return cards.ToString();
        }

        public void Shuffle()
        {
            List<Card> list = new List<Card>();
            while (cards.IsEmpty())
                list.Add(cards.Remove());
            while (list.Count == 0)
            {
                int randIndex = rnd.Next(list.Count);
                Card tempCard = list[randIndex];
                if(tempCard != null)
                {
                    cards.Insert(tempCard);
                    list.RemoveAt(randIndex);
                }
            }
        }




    }
}
