using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinochle_Game
{
    public class Deck
    {
        private List<Card> deck;

        public Deck()
        {
            deck = new List<Card>();
            
            for (int suit = 1; suit <= 4; suit++)
                {
                    for (int value = 1; value <= 5; value++)
                    {
                        for (int i = 0; i < 4; i++)
			            {
			                deck.Add(new Card(value, suit));
			            }

                      
                    }
            
                }

        }

        public int NumCard
        {
            get
            {
                return deck.Count;
            }
        }

        public bool IsEmpty()
        {
            if (NumCard == 0)
                return true;
            else
                return false;
        }

    
      public  void ShuffleCards()
        {
            Random generator = new Random();
            for (int i = 0; i <= 79; i++)
            {
                int randomIndex = generator.Next(0, 80);
                Card temp = deck[randomIndex];
                deck[randomIndex] = deck[i];
                deck[i] = temp;

            }
           

            
        }
    
        public void Add(Card card)
        {
            deck.Add(card);

        }
        public void Remove(Card card)
        {
            deck.Remove(card);


        }
        public static Deck operator +(Deck d1, Card c)
        {
            d1.Add(c);
            return d1;
        }

        public static Deck operator -(Deck d1, Card c)
        {
            d1.Remove(c);
            return d1;
        }
        public override string ToString()
        {
            string output = "";
            foreach (Card c in deck)
            {
                output += c.ToString() + "\n";
            }
            return output;
        }
        public Card this[int i]
        {
            get
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException("i");
                }
                else if (i >= NumCard)
                {
                    throw new ArgumentOutOfRangeException("i");
                }
                return deck[i];
            }
            set
            {
                deck[i] = value;
               
            }
        }
    
        public Card Deal()
        {
             Card card = deck[0];
         
             deck.RemoveAt(0);
             return card;
        }
           

       


    }  
}

    

