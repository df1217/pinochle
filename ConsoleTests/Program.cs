using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pinochle_Game;

namespace ConsoleTests
{
   public class Program
    {
        static void Main(string[] args)
        {
            //TestGetters();
            //TestClubsMeld();
            //TestCalcPinochleMeld();
            //TestCalcPinochleandJacksMeld();
            TestMeld();
        }

        static void TestGetters()
        {
            Deck d = new Deck();
            d.ShuffleCards();
            Hand h = new Hand(d, 20);
            IEnumerable<Card> h2 = h.SortHand();


            foreach (Card item in h2)
            {
                Console.WriteLine(item.ToString() + "\n");
            }
            Console.WriteLine();

            int one = 1000;
            Console.WriteLine(one);
            Console.WriteLine(h.HasNineteenPounderClubs());
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine(h.Meld);
            Console.WriteLine();
            Console.WriteLine(h.NumOfClubs);
            Console.ReadLine();
            Console.ReadLine();
        }

       static void TestClubsMeld()
        {
            Card c1 = new Card(1, 1);
            Card c2 = new Card(2, 1);
            Card c3 = new Card(3, 1);
            Card c4 = new Card(4, 1);
            Card c5 = new Card(5, 1);

            Hand h1 = new Hand();
            h1.Add(c1);
            h1.Add(c2);
            h1.Add(c3);
            h1.Add(c4);
            h1.Add(c5);
            h1.Add(c3);
            h1.Add(c2);
            h1.Add(c1);
            h1.Add(c2);
            h1.Add(c3);
            h1.Add(c4);
            h1.Add(c5);
            h1.Add(c3);
            h1.Add(c2);

          

           Console.WriteLine(h1.HasRunClubs());
           Console.WriteLine();
           Console.WriteLine(h1.HasNineteenPounderClubs());
           Console.WriteLine();
           Console.WriteLine(h1.HasTwentyThreePounderClubs());
           Console.WriteLine();
           Console.WriteLine(h1.HasTwentySevenPounderClubs());
           Console.WriteLine();
           Console.WriteLine(h1.HasMarriageClubs());
           Console.WriteLine();
           Console.WriteLine(h1.HasDoubleRunClubs());
           Console.WriteLine();
          
           Console.ReadLine();
        }

       static void TestCalcPinochleandJacksMeld()
       {
           Card c1 = new Card(1, 2);
           Card c3 = new Card(1, 1);
           Card c4 = new Card(1, 3);
           Card c5 = new Card(1, 4);
           Card c2 = new Card(2, 4);
           Hand h = new Hand();
           h.Add(c1);
           h.Add(c2);
           h.Add(c1);
           h.Add(c2);
           h.Add(c1);
           h.Add(c2);
           h.Add(c3);
           h.Add(c4);
           h.Add(c5);
           h.Add(c3);
           h.Add(c4);
           h.Add(c5);
           Console.WriteLine(h.Meld);
           Console.ReadLine();
       }

       static void TestMeld()
       {
           Deck d = new Deck();
           d.ShuffleCards();
           Hand h = new Hand(d, 15);
           List<Card> h2 = h.SortHand();
         
           foreach (Card item in h2)
           {
               Console.WriteLine(item.ToString() + "\n");
           }
          
           Console.WriteLine();
           Console.WriteLine(h.Meld);
           Console.ReadLine();
       }
    }
}
