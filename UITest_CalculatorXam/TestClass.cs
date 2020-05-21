using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UITest_CalculatorXam
{
    class TestClass
    {
        MainScreenModel _msModel = new MainScreenModel();
        [SetUp]
        public void StartAppBeforeEachTest()
        {
            AppInitializer.StartApp();
        }
        [Test]
        public void MyFirstMobileTest()
        {
            _msModel.TapOnOne()
                .TapOnPlus()
                .TapOnTwo()
                .TapOnEgual();
            Assert.AreEqual("3", _msModel.GetTextFromTextField());
        }
        
        [Test]
        public void CheckMult()
        {
            _msModel.TapOnThree()
                .TapOnMult()
                .TapOnFour()                         
                .TapOnEgual();
            Assert.AreEqual("12", _msModel.GetTextFromTextField());
        }
        [Test]
        public void CheckDiv()
        {
            _msModel.TapOnFive()
                .TapOnDiv()
                .TapOnSix()
                .TapOnEgual();
            Assert.AreEqual("0,833333333333333", _msModel.GetTextFromTextField());
        }
        [Test]
        public void CheckMinus()
        {
            _msModel.TapOnEight()
                .TapOnMinus()
                .TapOnSeven()
                .TapOnEgual();
            Assert.AreEqual("1", _msModel.GetTextFromTextField());
        }
        [Test]
        public void CheckPoint()
        {
            _msModel.TapOnNine()
                .TapOnPoint()
                .TapOnFour()
                .TapOnPlus()
                .TapOnFour()
                .TapOnPoint()
                .TapOnThree()
                .TapOnEgual();
            Assert.AreEqual("13,7", _msModel.GetTextFromTextField());
        }
        [Test]
        public void CheckDel()
        {
            _msModel.TapOnNine()
                .TapOnPoint()
                .TapOnFour()
                .TapOnPlus()
                .TapOnFour()
                .TapOnPoint()
                .TapOnThree()
                .TapOnDel();
            Assert.AreEqual("0", _msModel.GetTextFromTextField());
        }
    }
}
