using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Pinochle_Game;

namespace Pinochle_Tests
{
    [TestFixture]
    public class CardTests
    {
        [Test]
        public void TestGetters()
        {
            

            //Assert.AreEqual(7, h1.NumOfClubs);
            //Assert.AreEqual(1, h1.NumOfAces);
            //Assert.AreEqual(0, h1.Meld);
       
       

        }

        [Test]
        public void TestRunsOfClubs()
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

            Assert.AreEqual(1, h1.NumOfAC);
            Assert.True(h1.HasNineteenPounderClubs());
        }

        [SetUp]
        public void SetUp()
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
        }

    }

}
