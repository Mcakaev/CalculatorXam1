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
                .TapOnEqual();
            Assert.AreEqual("3", _msModel.GetTextFromTextField());
        }
        
        [Test]
        public void CheckMult()
        {
            _msModel.TapOnThree()
                .TapOnMult()
                .TapOnFour()                         
                .TapOnEqual();
            Assert.AreEqual("12", _msModel.GetTextFromTextField());
        }
        [Test]
        public void CheckDiv()
        {
            _msModel.TapOnFive()
                .TapOnDiv()
                .TapOnSix()
                .TapOnEqual();
            Assert.AreEqual("0,833333333333333", _msModel.GetTextFromTextField());
        }
        [Test]
        public void CheckMinus()
        {
            _msModel.TapOnEight()
                .TapOnMinus()
                .TapOnSeven()
                .TapOnEqual();
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
                .TapOnEqual();
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
        [Test]
        public void CheckFourOperation()
        {
            _msModel.TapOnNine()
                .TapOnPlus()
                .TapOnFour()
                .TapOnMinus()
                .TapOnThree()
                .TapOnMult()
                .TapOnFive()
                .TapOnDiv()
                .TapOnOne()
                .TapOnZero()
                .TapOnEqual();

            Assert.AreEqual("5", _msModel.GetTextFromTextField());
        }
        [Test]
        public void CheckDivOnZero()
        {
            _msModel.TapOnNine()
                .TapOnDiv()
                .TapOnZero()                
                .TapOnEqual();
            Assert.AreEqual("бесконечность", _msModel.GetTextFromTextField());
        }
        [Test]
        public void CheckAllNumbers()
        {
            _msModel.TapOnOne()
                .TapOnTwo()
                .TapOnThree()
                .TapOnFour()
                .TapOnFive()
                .TapOnSix()
                .TapOnSeven()
                .TapOnEight()
                .TapOnNine()
                .TapOnZero();
            Assert.AreEqual("01234567890", _msModel.GetTextFromTextField());
        }
        [Test]
        public void CheckDifferntFunction()
        {
            _msModel.TapOnOne()
                .TapOnPlus()
                .TapOnMinus()
                .TapOnMult()
                .TapOnDiv()
                .TapOnOne()
                .TapOnEqual();
            Assert.AreEqual("1", _msModel.GetTextFromTextField());
        }
    }
}
