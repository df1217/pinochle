using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinochle_Game
{
    public class Card
    {
        private int suit; // 1 - 4, Clubs - Spades
        private int value; // 1 - 5, Jack thru Ace 
        private string[] suits = { "", "clubs", "diamonds", "hearts", "spades" };
        private string[] values = { "", "jack", "queen", "king", "ten", "ace" };
 
        public Card()
        {
            value = 1;
            suit = 1;
        }
 
        public Card(int v, int s)
        {
            value = v;
            suit = s;
        }
 
        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                if (value >= 1 && value <= 5)
                    this.value = value;
                else
                    throw new Exception("The value needs to be an int between 1 and 5");
 
            }
        }
 
        public int Suit
        {
            get
            {
                return suit;
            }
            set
            {
                suit = value;
            }
        }
        public string Filename
        {
            get
            {
                return "card" + values[value].Substring(0, 1) + suits[suit].Substring(0,1) + ".jpg";
            }
        }
             
 
       
 
        public bool IsAce()
        {
            if (value == 5)
                return true;
            else
                return false;
        }

        public bool IsTen()
        {
            if (value == 4)
                return true;
            else
                return false;
        }

        public bool IsKing()
        {
            if (value == 3)
                return true;
            else
                return false;
        }

        public bool IsQueen()
        {
            if (value == 2)
                return true;
            else
                return false;
        }

        public bool IsJack()
        {
            if (value == 1)
                return true;
            else
                return false;
        }
 
 
        public bool IsClub()
        {
            if (suit == 1)
                return true;
            else
                return false;
        }
 
        public bool IsDiamond()
        {
            if (suit == 2)
                return true;
            else
                return false;
        }
 
        public bool IsHeart()
        {
            if (suit == 3)
                return true;
            else
                return false;
        }
 
        public bool IsSpade()
        {
            if (suit == 4)
                return true;
            else
                return false;
        }
        public bool HasMatchingValue(Card otherCard)
        {
            if (this.value == otherCard.value)
                return true;
            else
                return false;
        }

        public bool IsPointer()
        {
            if (value == 3 || value == 4 || value == 5)
                return true;
            else
                return false;
        }

        public bool IsTrump()
        {
            return false;
        }
 
        
        public override string ToString()
        {
            return values[value] + " of " + suits[suit];
        }
 
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Card c = (Card)obj;
            if (this.Value == c.Value && this.Suit == c.Suit)
                return true;
            else
                return false;
        }
 
        public static bool Equals(object obj1, object obj2)
        {
            if (obj1 == null || obj2 == null)
                return false;
            Card c1 = (Card)obj1;
            Card c2 = (Card)obj2;
            if (c1.Value == c2.Value && c1.Suit == c2.Suit)
                return true;
            else
                return false;
        }
         
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static bool operator == (Card c1, Card c2)
        {
            return c1.Equals(c2);
        }
 
        public static bool operator != (Card c1, Card c2)
        {
            return !c1.Equals(c2);
        }
        
    }
     
 
}
    

