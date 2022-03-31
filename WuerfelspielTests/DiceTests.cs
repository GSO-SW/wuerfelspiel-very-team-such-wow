using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class DiceTests
    {
        [TestMethod]
        public void DiceInstantiateTest()
        {
            Dice dice = new Dice();
        
            Assert.IsNotNull(dice);
            Assert.IsTrue(dice.Sides == 6);
            Assert.IsTrue(dice.Locked == false);
        } 
        
        [TestMethod]
        public void DiceInstantiateWithSidesTest()
        {
            Dice dice = new Dice(12);
            
            Assert.IsNotNull(dice);
            Assert.IsTrue(dice.Sides == 12);
            Assert.IsTrue(dice.Locked == false);
        }
    }
}
