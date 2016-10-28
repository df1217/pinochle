using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinochle_Game
{
    public class Hand : IEnumerable<Card>
    {
        private List<Card> hand;
        private int meld;
        //private IEnumerable<Card> jC;
        //private IEnumerable<Card> jD;
        //private IEnumerable<Card> jH;
        //private IEnumerable<Card> jS;
        //private IEnumerable<Card> qC;
        //private IEnumerable<Card> qD;
        //private IEnumerable<Card> qH;
        //private IEnumerable<Card> qS;
        //private IEnumerable<Card> kC;
        //private IEnumerable<Card> kD;
        //private IEnumerable<Card> kH;
        //private IEnumerable<Card> kS;
        //private IEnumerable<Card> tC;
        //private IEnumerable<Card> tD;
        //private IEnumerable<Card> tH;
        //private IEnumerable<Card> tS;
        //private IEnumerable<Card> aC;
        //private IEnumerable<Card> aD;
        //private IEnumerable<Card> aH;
        //private IEnumerable<Card> aS;
        private int numOfJC;
        private int numOfJD;
        private int numOfJH;
        private int numOfJS;
        private int numOfQC;
        private int numOfQD;
        private int numOfQH;
        private int numOfQS;
        private int numOfKC;
        private int numOfKD;
        private int numOfKH;
        private int numOfKS;
        private int numOfTC;
        private int numOfTD;
        private int numOfTH;
        private int numOfTS;
        private int numOfAC;
        private int numOfAD;
        private int numOfAH;
        private int numOfAS;
        private int numOfClubs;
        private int numOfDiamonds;
        private int numOfHearts;
        private int numOfSpades;
        private int numOfAces;
        private int numOfTens;
        private int numOfKings;
        private int numOfQueens;
        private int numOfJacks;

        public Hand()
        {
            hand = new List<Card>();
            meld = 0;      
        }

        public Hand(Deck d, int NumCards)
        {
            hand = new List<Card>();
            meld = 0;
            for (int i = 0; i < NumCards; i++)
            {
                hand.Add(d.Deal());
            }
        }

        public int NumOfJC
        {
            get
            {
                return numOfJC = hand.Where(x => x.ToString() == "jack of clubs").Count();
            }

        }

        public int NumOfJD
        {
            get
            {
                return numOfJD = hand.Where(x => x.ToString() == "jack of diamonds").Count();
            }

        }

        public int NumOfJH
        {
            get
            {
                return numOfJH = hand.Where(x => x.ToString() == "jack of hearts").Count();
            }

        }

        public int NumOfJS
        {
            get
            {
                 return numOfJS = hand.Where(x => x.ToString() == "jack of spades").Count();
            }

        }

        public int NumOfQC
        {
            get
            {  
                return numOfQC = hand.Where(x => x.ToString() == "queen of clubs").Count();
            }

        }

        public int NumOfQD
        {
            get
            {           
                return numOfQD = hand.Where(x => x.ToString() == "queen of diamonds").Count();
            }

        }

        public int NumOfQH
        {
            get
            {             
                return numOfQH = hand.Where(x => x.ToString() == "queen of hearts").Count();
            }

        }

        public int NumOfQS
        {
            get
            {              
                return numOfQS = hand.Where(x => x.ToString() == "queen of spades").Count();
            }

        }

        public int NumOfKC
        {
            get
            {
             
                return numOfKC = hand.Where(x => x.ToString() == "king of clubs").Count();
            }

        }

        public int NumOfKD
        {
            get
            {
                
                return numOfKD = hand.Where(x => x.ToString() == "king of diamonds").Count();
            }

        }

        public int NumOfKH
        {
            get
            {
                
                return numOfKH = hand.Where(x => x.ToString() == "king of hearts").Count();
            }

        }

        public int NumOfKS
        {
            get
            {
               
                return numOfKS = hand.Where(x => x.ToString() == "king of spades").Count();
            }

        }

        public int NumOfTC
        {
            get
            {
               
                return numOfTC = hand.Where(x => x.ToString() == "ten of clubs").Count();
            }

        }

        public int NumOfTD
        {
            get
            {
                
                return numOfTD = hand.Where(x => x.ToString() == "ten of diamonds").Count();
            }

        }

        public int NumOfTH
        {
            get
            {
                
                return numOfTH = hand.Where(x => x.ToString() == "ten of hearts").Count();
            }

        }

        public int NumOfTS
        {
            get
            {
                
                return numOfTS = hand.Where(x => x.ToString() == "ten of spades").Count();
            }

        }

        public int NumOfAC
        {
            get
            {
      
                return numOfAC = hand.Where(x => x.ToString() == "ace of clubs").Count();
            }

        }

        public int NumOfAD
        {
            get
            {
               
                return numOfAD = hand.Where(x => x.ToString() == "ace of diamonds").Count();
            }

        }

        public int NumOfAH
        {
            get
            {
                
                return numOfAH = hand.Where(x => x.ToString() == "ace of hearts").Count();
            }

        }

        public int NumOfAS
        {
            get
            {
                
                return numOfAS = hand.Where(x => x.ToString() == "ace of spades").Count();
            }

        }

        public int NumOfClubs
        {
            get
            {
               
                return numOfClubs = hand.Where(x => x.Suit == 1).Count();
            }
        }
       
        public int NumOfDiamonds
        {
            get
            {
                
                return numOfDiamonds = hand.Where(x => x.Suit == 2).Count();
            }
        }

        public int NumOfHearts
        {
            get
            {
                
                return numOfHearts = hand.Where(x => x.Suit == 3).Count();
            }
        }

        public int NumOfSpades
        {
            get
            {
                
                return numOfSpades = hand.Where(x => x.Suit == 4).Count();
            }
        }

        public int NumOfAces
        {
            get
            {
                
                return numOfAces = hand.Where(x => x.Value == 5).Count();
            }
        }

        public int NumOfTens
        {
            get
            {

                return numOfTens = hand.Where(x => x.Value == 4).Count();
            }
        }

        public int NumOfKings
        {
            get
            {

                return numOfKings = hand.Where(x => x.Value == 3).Count();
            }
        }

        public int NumOfQueens
        {
            get
            {

                return numOfQueens = hand.Where(x => x.Value == 2).Count();
            }
        }

        public int NumOfJacks
        {
            get
            {

                return numOfJacks = hand.Where(x => x.Value == 1).Count();
            }
        }

        public int Meld
        { 
            get 
            {
                if (HasPinochle())
                    meld += 4;
                if (HasDoublePinochle())
                    meld += 30;
                if (HasTriplePinochle())
                    meld += 60;
                if (HasQuadruplePinochle())
                    meld += 90;
                if (HasJacks())
                    meld += 4;
                if (HasDoubleJacks())
                    meld += 40;
                if (HasTripleJacks())
                    meld += 60;
                if (HasQuadrupleJacks())
                    meld += 80;
                if (HasQueens())
                    meld += 6;
                if (HasDoubleQueens())
                    meld += 60;
                if (HasTripleQueens())
                    meld += 90;
                if (HasQuadrupleQueens())
                    meld += 120;
                if (HasKings())
                    meld += 8;
                if (HasDoubleKings())
                    meld += 80;
                if (HasTripleKings())
                    meld += 120;
                if (HasQuadrupleKings())
                    meld += 160;
                if (HasAces())
                    meld += 10;
                if (HasDoubleAces())
                    meld += 100;
                if (HasTripleAces())
                    meld += 150;
                if (HasQuadrupleAces())
                    meld += 200;
                if (HasMarriageClubs())
                    meld += 2;
                if (HasMarriageDiamonds())
                    meld += 2;
                if (HasMarriageHearts())
                    meld += 2;
                if (HasMarriageSpades())
                    meld += 2;
                if (HasDoubleMarriageClubs())
                    meld += 4;
                if (HasDoubleMarriageDiamonds())
                    meld += 4;
                if (HasDoubleMarriageHearts())
                    meld += 4;
                if (HasDoubleMarriageSpades())
                    meld += 4;
                if (HasTripleMarriageClubs())
                    meld += 6;
                if (HasTripleMarriageDiamonds())
                    meld += 6;
                if (HasTripleMarriageHearts())
                    meld += 6;
                if (HasQuadrupleMarriageSpades())
                    meld += 8;
                if (HasQuadrupleMarriageClubs())
                    meld += 8;
                if (HasQuadrupleMarriageDiamonds())
                    meld += 8;
                if (HasQuadrupleMarriageHearts())
                    meld += 8;
                if (HasQuadrupleMarriageSpades())
                    meld += 8;
                if (HasRun())
                    meld += 15;
                if (HasNineteenPounder())
                    meld += 19;
                if (HasTwentyThreePounder())
                    meld += 23;
                if (HasTwentySevenPounder())
                    meld += 27;
                if (HasDoubleRun())
                    meld += 150;
                if (HasTripleRun())
                    meld += 225;
                if (HasQuadrupleRun())
                    meld += 300;

                return meld;
            }
        }

      
        public bool HasPinochle()
        {
            if (NumOfJD >= 1 && NumOfQS >= 1)
            {
                if (!HasDoublePinochle() && !HasTriplePinochle()
                   && !HasQuadruplePinochle())
                {
                //    meld += 4;
                    return true;
                }
                else
                   return false;
            }
            else
                return false;
        }

        public bool HasDoublePinochle()
        {
            if (NumOfJD >= 2 && NumOfQS >= 2)
            {
                if (!HasTriplePinochle() && !HasQuadruplePinochle())
                {
                //    meld += 30;
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasTriplePinochle()
        {
            if (NumOfJD >= 3 && NumOfQS >= 3)
            {
                if (!HasQuadruplePinochle())
                {
                //    meld += 60;
                   return true;
                }
                else
                   return false;
            }
            else
                return false;
        }
        public bool HasQuadruplePinochle()
        {
            if (NumOfJD == 4 && NumOfQS == 4)
            {
                //meld += 90;
                return true;
            }
            else
                return false;
        }



        public bool HasJacks()
        {
            if (NumOfJC >= 1 && NumOfJD >= 1 && NumOfJH >= 1 && NumOfJS >= 1)
            {
                if (!HasDoubleJacks() && !HasTripleJacks()
                    && !HasQuadrupleJacks())
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;

        }

        public bool HasDoubleJacks()
        {
            if (NumOfJC >= 2 && NumOfJD >= 2 && NumOfJH >= 2 && NumOfJS >= 2)
            {
                if (!HasTripleJacks() && !HasQuadrupleJacks())
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasTripleJacks()
        {
            if (NumOfJC >= 3 && NumOfJD >= 3 && NumOfJH >= 3 && NumOfJS >= 3)
            {
                if (!HasQuadrupleJacks())
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasQuadrupleJacks()
        {
            if (NumOfJC == 4 && NumOfJD == 4 && NumOfJH == 4 && NumOfJS == 4)
            {
                return true;
            }
            else
                return false;
        }

        public bool HasQueens()
        {
            if (NumOfQC >= 1 && NumOfQD >= 1 && NumOfQH >= 1 && NumOfQS >= 1)
            {
                if (!HasDoubleQueens() && !HasTripleQueens()
                    && !HasQuadrupleQueens())
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;

        }

        public bool HasDoubleQueens()
        {
            if (NumOfQC >= 2 && NumOfQD >= 2 && NumOfQH >= 2 && NumOfQS >= 2)
            {
                if (!HasTripleQueens() && !HasQuadrupleQueens())
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasTripleQueens()
        {
            if (NumOfQC >= 3 && NumOfQD >= 3 && NumOfQH >= 3 && NumOfQS >= 3)
            {
                if (!HasQuadrupleQueens())
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasQuadrupleQueens()
        {
            if (NumOfQC == 4 && NumOfQD == 4 && NumOfQH == 4 && NumOfQS == 4)
            {
                return true;
            }
            else
                return false;
        }

        public bool HasKings()
        {
            if (NumOfKC >= 1 && NumOfKD >= 1 && NumOfKH >= 1 && NumOfKS >= 1)
            {
                if (!HasDoubleKings() && !HasTripleKings()
                    && !HasQuadrupleKings())
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;

        }

        public bool HasDoubleKings()
        {
            if (NumOfKC >= 2 && NumOfKD >= 2 && NumOfKH >= 2 && NumOfKS >= 2)
            {
                if (!HasTripleKings() && !HasQuadrupleKings())
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasTripleKings()
        {
            if (NumOfKC >= 3 && NumOfKD >= 3 && NumOfKH >= 3 && NumOfKS >= 3)
            {
                if (!HasQuadrupleKings())
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasQuadrupleKings()
        {
            if (NumOfKC == 4 && NumOfKD == 4 && NumOfKH == 4 && NumOfKS == 4)
            {
                return true;
            }
            else
                return false;
        }

        public bool HasAces()
        {
            if (NumOfKC >= 1 && NumOfKD >= 1 && NumOfKH >= 1 && NumOfKS >= 1)
            {
                if (!HasDoubleKings() && !HasTripleKings()
                    && !HasQuadrupleKings())
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;

        }

        public bool HasDoubleAces()
        {
            if (NumOfAC >= 2 && NumOfAD >= 2 && NumOfAH >= 2 && NumOfAS >= 2)
            {
                if (!HasTripleAces() && !HasQuadrupleAces())
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasTripleAces()
        {
            if (NumOfAC >= 3 && NumOfAD >= 3 && NumOfAH >= 3 && NumOfAS >= 3)
            {
                if (!HasQuadrupleAces())
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasQuadrupleAces()
        {
            if (NumOfAC == 4 && NumOfAD == 4 && NumOfAH == 4 && NumOfAS == 4)
            {
                return true;
            }
            else
                return false;
        }

        public bool HasMarriageClubs()
        {
            if (NumOfQC >= 1 && NumOfKC >= 1)
            {
                if (!HasDoubleMarriageClubs() && !HasTripleMarriageClubs()
                    && !HasQuadrupleMarriageClubs() && !HasRunClubs() 
                    && !HasNineteenPounderClubs()  && !HasTwentyThreePounderClubs() 
                    && !HasTwentySevenPounderClubs() && !HasDoubleRunClubs() 
                    && !HasTripleRunClubs() && !HasQuadrupleRunClubs())               
                    return true;                    
                 else
                    return false;
            }
            else
                return false;            
           
        }

        public bool HasDoubleMarriageClubs()
        {
            if (NumOfQC >= 2 && NumOfKC >= 2)
            {
                if (!HasTripleMarriageClubs() && !HasQuadrupleMarriageClubs() 
                    && !HasNineteenPounderClubs() && !HasTwentyThreePounderClubs()
                    && !HasTwentySevenPounderClubs() && !HasDoubleRunClubs()
                    && !HasTripleRunClubs() && !HasQuadrupleRunClubs())
                    return true;
                else
                    return false;
            }
            else
                return false;

        }

        public bool HasTripleMarriageClubs()
        {
            if (NumOfQC >= 3 && NumOfKC >= 3)
            {
                if (!HasQuadrupleMarriageClubs() && !HasTwentyThreePounderClubs()
                    && !HasTwentySevenPounderClubs() && !HasDoubleRunClubs()
                    && !HasTripleRunClubs() && !HasQuadrupleRunClubs())
                    return true;
                else
                    return false;
            }
            else
                return false;

        }

        public bool HasQuadrupleMarriageClubs()
        {
            if (NumOfQC == 4 && NumOfKC == 4)
            {
                if (!HasTwentySevenPounderClubs() && !HasDoubleRunClubs()
                    && !HasTripleRunClubs() && !HasQuadrupleRunClubs())
                    return true;
                else
                    return false;
            }
            else
                return false;

        }

        public bool HasRunClubs()
        {
            if (NumOfJC >= 1 && NumOfQC >= 1 && NumOfKC >= 1
                && NumOfTC >= 1 && NumOfAC >= 1)
            {
                if (!HasDoubleRunClubs() && !HasTripleRunClubs()
                    && !HasQuadrupleRunClubs())
                {
                    if (!HasNineteenPounderClubs() && !HasTwentyThreePounderClubs()
                        && !HasTwentySevenPounderClubs())
                    {
                        
                        return true;
                    }
                    else
                        return false;

                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasNineteenPounderClubs()
        {
            if (NumOfJC >= 1 && NumOfQC >= 2 && NumOfKC >= 2
                && NumOfTC >= 1 && NumOfAC >= 1)
            {
                if (!HasTwentyThreePounderClubs() && !HasTwentySevenPounderClubs())
                {
                    if (!HasDoubleRunClubs() && !HasTripleRunClubs()
                        && !HasQuadrupleRunClubs())
                    {
                        
                        return true;
                    }
                    else
                        return false;

                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasTwentyThreePounderClubs()
        {
            if (NumOfJC >= 1 && NumOfQC >= 3 && NumOfKC >= 3
               && NumOfTC >= 1 && NumOfAC >= 1)
            {
                if (!HasTwentySevenPounderClubs())
                {
                    if (!HasDoubleRunClubs() && !HasTripleRunClubs()
                        && !HasQuadrupleRunClubs())
                    {
                        
                        return true;
                    }
                    else
                        return false;

                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasTwentySevenPounderClubs()
        {
            if (NumOfJC >= 1 && NumOfQC == 4 && NumOfKC == 4
               && NumOfTC >= 1 && NumOfAC >= 1)
            {
                if (!HasDoubleRunClubs() && !HasTripleRunClubs()
                    && !HasQuadrupleRunClubs())
                {
                    
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasDoubleRunClubs()
        {
            if (NumOfJC >= 2 && NumOfQC >= 2 && NumOfKC >= 2
                && NumOfTC >= 2 && NumOfAC >= 2)
            {
                if (!HasTripleRunClubs()
                    && !HasQuadrupleRunClubs())
                {

                    
                    return true;
                }

                else
                    return false;
            }
            else
                return false;
        }

        public bool HasTripleRunClubs()
        {
            if (NumOfJC >= 3 && NumOfQC >= 3 && NumOfKC >= 3
                && NumOfTC >= 3 && NumOfAC >= 3)
            {
                if (!HasQuadrupleRunClubs())
                {
                   
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasQuadrupleRunClubs()
        {
            if (NumOfJC == 4 && NumOfQC == 4 && NumOfKC == 4
                && NumOfTC == 4 && NumOfAC == 4)
            {
                
                return true;
            }
            else
                return false;

        }

        public bool HasMarriageDiamonds()
        {
            if (NumOfQD >= 1 && NumOfKD >= 1)
            {
                if (!HasDoubleMarriageDiamonds() && !HasTripleMarriageDiamonds()
                    && !HasQuadrupleMarriageDiamonds() && !HasRunDiamonds()
                    && !HasNineteenPounderDiamonds() && !HasTwentyThreePounderDiamonds()
                    && !HasTwentySevenPounderDiamonds() && !HasDoubleRunDiamonds()
                    && !HasTripleRunDiamonds() && !HasQuadrupleRunDiamonds())               
                    return true;                    
                 else
                    return false;
            }
            else
                return false;            
           
        }

        public bool HasDoubleMarriageDiamonds()
        {
            if (NumOfQD >= 2 && NumOfKD >= 2)
            {
                if (!HasTripleMarriageDiamonds() && !HasQuadrupleMarriageDiamonds()
                    && !HasNineteenPounderDiamonds() && !HasTwentyThreePounderDiamonds()
                    && !HasTwentySevenPounderDiamonds() && !HasDoubleRunDiamonds()
                    && !HasTripleRunDiamonds() && !HasQuadrupleRunDiamonds())
                    return true;
                else
                    return false;
            }
            else
                return false;

        }

        public bool HasTripleMarriageDiamonds()
        {
            if (NumOfQD >= 3 && NumOfKD >= 3)
            {
                if (!HasQuadrupleMarriageDiamonds() && !HasTwentyThreePounderDiamonds()
                    && !HasTwentySevenPounderDiamonds() && !HasDoubleRunDiamonds()
                    && !HasTripleRunDiamonds() && !HasQuadrupleRunDiamonds())
                    return true;
                else
                    return false;
            }
            else
                return false;

        }

        public bool HasQuadrupleMarriageDiamonds()
        {
            if (NumOfQD == 4 && NumOfKD == 4)
            {
                if (!HasTwentySevenPounderDiamonds() && !HasDoubleRunDiamonds()
                    && !HasTripleRunDiamonds() && !HasQuadrupleRunDiamonds())
                    return true;
                else
                    return false;
            }
            else
                return false;

        }

        public bool HasRunDiamonds()
        {
            if (NumOfJD >= 1 && NumOfQD >= 1 && NumOfKD >= 1
                && NumOfTD >= 1 && NumOfAD >= 1)
            {
                if (!HasDoubleRunDiamonds() && !HasTripleRunDiamonds()
                    && !HasQuadrupleRunDiamonds())
                {
                    if (!HasNineteenPounderDiamonds() && !HasTwentyThreePounderDiamonds()
                        && !HasTwentySevenPounderDiamonds())
                    {
                        
                        return true;
                    }
                    else
                        return false;

                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasNineteenPounderDiamonds()
        {
            if (NumOfJD >= 1 && NumOfQD >= 2 && NumOfKD >= 2
                && NumOfTD >= 1 && NumOfAD >= 1)
            {
                if (!HasTwentyThreePounderDiamonds() && !HasTwentySevenPounderDiamonds())
                {
                    if (!HasDoubleRunDiamonds() && !HasTripleRunDiamonds()
                        && !HasQuadrupleRunDiamonds())
                    {
                        
                        return true;
                    }
                    else
                        return false;

                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasTwentyThreePounderDiamonds()
        {
            if (NumOfJD >= 1 && NumOfQD >= 3 && NumOfKD >= 3
               && NumOfTD >= 1 && NumOfAD >= 1)
            {
                if (!HasTwentySevenPounderDiamonds())
                {
                    if (!HasDoubleRunDiamonds() && !HasTripleRunDiamonds()
                        && !HasQuadrupleRunDiamonds())
                    {
                        
                        return true;
                    }
                    else
                        return false;

                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasTwentySevenPounderDiamonds()
        {
            if (NumOfJD >= 1 && NumOfQD == 4 && NumOfKD == 4
               && NumOfTD >= 1 && NumOfAD >= 1)
            {
                if (!HasDoubleRunDiamonds() && !HasTripleRunDiamonds()
                    && !HasQuadrupleRunDiamonds())
                {
                    
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasDoubleRunDiamonds()
        {
            if (NumOfJD >= 2 && NumOfQD >= 2 && NumOfKD >= 2
                && NumOfTD >= 2 && NumOfAD >= 2)
            {
                if (!HasTripleRunDiamonds()
                    && !HasQuadrupleRunDiamonds())
                {

                    
                    return true;
                }

                else
                    return false;
            }
            else
                return false;
        }

        public bool HasTripleRunDiamonds()
        {
            if (NumOfJD >= 3 && NumOfQD >= 3 && NumOfKD >= 3
                && NumOfTD >= 3 && NumOfAD >= 3)
            {
                if (!HasQuadrupleRunDiamonds())
                {
                   
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasQuadrupleRunDiamonds()
        {
            if (NumOfJD == 4 && NumOfQD == 4 && NumOfKD == 4
                && NumOfTD == 4 && NumOfAD == 4)
            {
                
                return true;
            }
            else
                return false;

        }

        public bool HasMarriageHearts()
        {
            if (NumOfQH >= 1 && NumOfKH >= 1)
            {
                if (!HasDoubleMarriageHearts() && !HasTripleMarriageHearts()
                    && !HasQuadrupleMarriageHearts() && !HasRunHearts()
                    && !HasNineteenPounderHearts() && !HasTwentyThreePounderHearts()
                    && !HasTwentySevenPounderHearts() && !HasDoubleRunHearts()
                    && !HasTripleRunHearts() && !HasQuadrupleRunHearts())
                    return true;
                else
                    return false;
            }
            else
                return false;

        }

        public bool HasDoubleMarriageHearts()
        {
            if (NumOfQH >= 2 && NumOfKH >= 2)
            {
                if (!HasTripleMarriageHearts() && !HasQuadrupleMarriageHearts()
                    && !HasNineteenPounderHearts() && !HasTwentyThreePounderHearts()
                    && !HasTwentySevenPounderHearts() && !HasDoubleRunHearts()
                    && !HasTripleRunHearts() && !HasQuadrupleRunHearts())
                    return true;
                else
                    return false;
            }
            else
                return false;

        }

        public bool HasTripleMarriageHearts()
        {
            if (NumOfQH >= 3 && NumOfKH >= 3)
            {
                if (!HasQuadrupleMarriageHearts() && !HasTwentyThreePounderHearts()
                    && !HasTwentySevenPounderHearts() && !HasDoubleRunHearts()
                    && !HasTripleRunHearts() && !HasQuadrupleRunHearts())
                    return true;
                else
                    return false;
            }
            else
                return false;

        }

        public bool HasQuadrupleMarriageHearts()
        {
            if (NumOfQH == 4 && NumOfKH == 4)
            {
                if (!HasTwentySevenPounderHearts() && !HasDoubleRunHearts()
                    && !HasTripleRunHearts() && !HasQuadrupleRunHearts())
                    return true;
                else
                    return false;
            }
            else
                return false;

        }

        public bool HasRunHearts()
        {
            if (NumOfJH >= 1 && NumOfQH >= 1 && NumOfKH >= 1
                && NumOfTH >= 1 && NumOfAH >= 1)
            {
                if (!HasDoubleRunHearts() && !HasTripleRunHearts()
                    && !HasQuadrupleRunHearts())
                {
                    if (!HasNineteenPounderHearts() && !HasTwentyThreePounderHearts()
                        && !HasTwentySevenPounderHearts())
                    {

                        return true;
                    }
                    else
                        return false;

                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasNineteenPounderHearts()
        {
            if (NumOfJH >= 1 && NumOfQH >= 2 && NumOfKH >= 2
                && NumOfTH >= 1 && NumOfAH >= 1)
            {
                if (!HasTwentyThreePounderHearts() && !HasTwentySevenPounderHearts())
                {
                    if (!HasDoubleRunHearts() && !HasTripleRunHearts()
                        && !HasQuadrupleRunHearts())
                    {

                        return true;
                    }
                    else
                        return false;

                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasTwentyThreePounderHearts()
        {
            if (NumOfJH >= 1 && NumOfQH >= 3 && NumOfKH >= 3
               && NumOfTH >= 1 && NumOfAH >= 1)
            {
                if (!HasTwentySevenPounderHearts())
                {
                    if (!HasDoubleRunHearts() && !HasTripleRunHearts()
                        && !HasQuadrupleRunHearts())
                    {

                        return true;
                    }
                    else
                        return false;

                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasTwentySevenPounderHearts()
        {
            if (NumOfJH >= 1 && NumOfQH == 4 && NumOfKH == 4
               && NumOfTH >= 1 && NumOfAH >= 1)
            {
                if (!HasDoubleRunHearts() && !HasTripleRunHearts()
                    && !HasQuadrupleRunHearts())
                {

                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasDoubleRunHearts()
        {
            if (NumOfJH >= 2 && NumOfQH >= 2 && NumOfKH >= 2
                && NumOfTH >= 2 && NumOfAH >= 2)
            {
                if (!HasTripleRunHearts()
                    && !HasQuadrupleRunHearts())
                {


                    return true;
                }

                else
                    return false;
            }
            else
                return false;
        }

        public bool HasTripleRunHearts()
        {
            if (NumOfJH >= 3 && NumOfQH >= 3 && NumOfKH >= 3
                && NumOfTH >= 3 && NumOfAH >= 3)
            {
                if (!HasQuadrupleRunHearts())
                {

                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasQuadrupleRunHearts()
        {
            if (NumOfJH == 4 && NumOfQH == 4 && NumOfKH == 4
                && NumOfTH == 4 && NumOfAH == 4)
            {

                return true;
            }
            else
                return false;

        }

        public bool HasMarriageSpades()
        {
            if (NumOfQS >= 1 && NumOfKS >= 1)
            {
                if (!HasDoubleMarriageSpades() && !HasTripleMarriageSpades()
                    && !HasQuadrupleMarriageSpades() && !HasRunSpades()
                    && !HasNineteenPounderSpades() && !HasTwentyThreePounderSpades()
                    && !HasTwentySevenPounderSpades() && !HasDoubleRunSpades()
                    && !HasTripleRunSpades() && !HasQuadrupleRunSpades())
                    return true;
                else
                    return false;
            }
            else
                return false;

        }

        public bool HasDoubleMarriageSpades()
        {
            if (NumOfQS >= 2 && NumOfKS >= 2)
            {
                if (!HasTripleMarriageSpades() && !HasQuadrupleMarriageSpades()
                    && !HasNineteenPounderSpades() && !HasTwentyThreePounderSpades()
                    && !HasTwentySevenPounderSpades() && !HasDoubleRunSpades()
                    && !HasTripleRunSpades() && !HasQuadrupleRunSpades())
                    return true;
                else
                    return false;
            }
            else
                return false;

        }

        public bool HasTripleMarriageSpades()
        {
            if (NumOfQS >= 3 && NumOfKS >= 3)
            {
                if (!HasQuadrupleMarriageSpades() && !HasTwentyThreePounderSpades()
                    && !HasTwentySevenPounderSpades() && !HasDoubleRunSpades()
                    && !HasTripleRunSpades() && !HasQuadrupleRunSpades())
                    return true;
                else
                    return false;
            }
            else
                return false;

        }

        public bool HasQuadrupleMarriageSpades()
        {
            if (NumOfQS == 4 && NumOfKS == 4)
            {
                if (!HasTwentySevenPounderSpades() && !HasDoubleRunSpades()
                    && !HasTripleRunSpades() && !HasQuadrupleRunSpades())
                    return true;
                else
                    return false;
            }
            else
                return false;

        }

        public bool HasRunSpades()
        {
            if (NumOfJS >= 1 && NumOfQS >= 1 && NumOfKS >= 1
                && NumOfTS >= 1 && NumOfAS >= 1)
            {
                if (!HasDoubleRunSpades() && !HasTripleRunSpades()
                    && !HasQuadrupleRunSpades())
                {
                    if (!HasNineteenPounderSpades() && !HasTwentyThreePounderSpades()
                        && !HasTwentySevenPounderSpades())
                    {

                        return true;
                    }
                    else
                        return false;

                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasNineteenPounderSpades()
        {
            if (NumOfJS >= 1 && NumOfQS >= 2 && NumOfKS >= 2
                && NumOfTS >= 1 && NumOfAS >= 1)
            {
                if (!HasTwentyThreePounderSpades() && !HasTwentySevenPounderSpades())
                {
                    if (!HasDoubleRunSpades() && !HasTripleRunSpades()
                        && !HasQuadrupleRunSpades())
                    {

                        return true;
                    }
                    else
                        return false;

                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasTwentyThreePounderSpades()
        {
            if (NumOfJS >= 1 && NumOfQS >= 3 && NumOfKS >= 3
               && NumOfTS >= 1 && NumOfAS >= 1)
            {
                if (!HasTwentySevenPounderSpades())
                {
                    if (!HasDoubleRunSpades() && !HasTripleRunSpades()
                        && !HasQuadrupleRunSpades())
                    {

                        return true;
                    }
                    else
                        return false;

                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasTwentySevenPounderSpades()
        {
            if (NumOfJS >= 1 && NumOfQS == 4 && NumOfKS == 4
               && NumOfTS >= 1 && NumOfAS >= 1)
            {
                if (!HasDoubleRunSpades() && !HasTripleRunSpades()
                    && !HasQuadrupleRunSpades())
                {

                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasDoubleRunSpades()
        {
            if (NumOfJS >= 2 && NumOfQS >= 2 && NumOfKS >= 2
                && NumOfTS >= 2 && NumOfAS >= 2)
            {
                if (!HasTripleRunSpades()
                    && !HasQuadrupleRunSpades())
                {


                    return true;
                }

                else
                    return false;
            }
            else
                return false;
        }

        public bool HasTripleRunSpades()
        {
            if (NumOfJS >= 3 && NumOfQS >= 3 && NumOfKS >= 3
                && NumOfTS >= 3 && NumOfAS >= 3)
            {
                if (!HasQuadrupleRunSpades())
                {

                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool HasQuadrupleRunSpades()
        {
            if (NumOfJS == 4 && NumOfQS == 4 && NumOfKS == 4
                && NumOfTS == 4 && NumOfAS == 4)
            {

                return true;
            }
            else
                return false;

        }

        public bool HasRun()
        {
            if (HasRunClubs() || HasRunDiamonds()
                || HasRunHearts() || HasRunSpades())
            {
                return true;
            }
            else
                return false;
        }

        public bool HasDoubleRun()
        {
            if (HasDoubleRunClubs() || HasDoubleRunDiamonds()
                || HasDoubleRunHearts() || HasDoubleRunSpades())
            {
                return true;
            }
            else
                return false;
        }

        public bool HasTripleRun()
        {
            if (HasTripleRunClubs() || HasTripleRunDiamonds()
                || HasTripleRunHearts() || HasTripleRunSpades())
            {
                return true;
            }
            else
                return false;
        }

        public bool HasQuadrupleRun()
        {
            if (HasQuadrupleRunClubs() || HasQuadrupleRunDiamonds()
                || HasQuadrupleRunHearts() || HasQuadrupleRunSpades())
            {
                return true;
            }
            else
                return false;
        }

        public bool HasNineteenPounder()
        {
            if (HasNineteenPounderClubs() || HasNineteenPounderDiamonds()
                || HasNineteenPounderHearts() || HasNineteenPounderSpades())
            {
                return true;
            }
            else
                return false;
        }

        public bool HasTwentyThreePounder()
        {
            if (HasTwentyThreePounderClubs() || HasTwentyThreePounderDiamonds()
                || HasTwentyThreePounderHearts() || HasTwentyThreePounderSpades())
            {
                return true;
            }
            else
                return false;
        }

        public bool HasTwentySevenPounder()
        {
            if (HasTwentySevenPounderClubs() || HasTwentySevenPounderDiamonds()
                || HasTwentySevenPounderHearts() || HasTwentySevenPounderSpades())
            {
                return true;
            }
            else
                return false;
        }

        

        
       
        

         public void Add(Card card)
            {
                hand.Add(card);

            }
            public void Remove(Card card)
            {
                hand.Remove(card);
            }

            public Card GetCard(int index)
            {
                Card card = hand[index];


                return card;


            }
            public override string ToString()
            {
                string output = "";
                foreach (Card c in hand)
                {
                    output += c.ToString() + "\n";
                }
                return output;
            }

        

        public IEnumerator<Card> GetEnumerator()
        {
            foreach (Card item in hand)
            {
                yield return item;
            }
        }
        
        System.Collections.IEnumerator
            System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
       
        public List<Card> SortHand()
        {
            List<Card> sortedHand = 
                hand.OrderByDescending(c => c.Suit).ThenByDescending(c => c.Value).ToList();
            return sortedHand;
        }




    }
}
