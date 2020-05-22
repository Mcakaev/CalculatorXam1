using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace UITest_CalculatorXam
{
    public class MainScreenModel
    {
        public static IApp App => AppInitializer.App;

        public Query textField = x => x.Id("input");
        public Query buttonDel = x => x.Marked("DEL");
        public Query buttonDiv = x => x.Marked("÷");
        public Query buttonSeven = x => x.Marked("7");
        public Query buttonEight = x => x.Marked("8");
        public Query buttonNine = x => x.Marked("9");
        public Query buttonMult = x => x.Marked("x");
        public Query buttonFour = x => x.Marked("4");
        public Query buttonFive = x => x.Marked("5");
        public Query buttonSix = x => x.Marked("6");
        public Query buttonMinus = x => x.Marked("-");
        public Query buttonOne = x => x.Marked("1");
        public Query buttonTwo = x => x.Marked("2");
        public Query buttonThree = x => x.Marked("3");
        public Query buttonPlus = x => x.Marked("+");
        public Query buttonPoint = x => x.Marked(",");
        public Query buttonZero = x => x.Marked("0");
        public Query buttonEgual = x => x.Marked("=");

        public MainScreenModel TapOnOne()
        {
            App.Tap(buttonOne);
            return this;
        }
        public MainScreenModel TapOnTwo()
        {
            App.Tap(buttonTwo);
            return this;
        }
        public MainScreenModel TapOnPlus()
        {
            App.Tap(buttonPlus);
            return this;
        }
        public MainScreenModel TapOnEqual()
        {
            App.Tap(buttonEgual);
            return this;
        }
        public MainScreenModel TapOnThree()
        {
            App.Tap(buttonThree);
            return this;
        }
        public MainScreenModel TapOnFour()
        {
            App.Tap(buttonFour);
            return this;
        }
        public MainScreenModel TapOnFive()
        {
            App.Tap(buttonFive);
            return this;
        }
        public MainScreenModel TapOnSix()
        {
            App.Tap(buttonSix);
            return this;
        }
        public MainScreenModel TapOnSeven()
        {
            App.Tap(buttonSeven);
            return this;
        }
        public MainScreenModel TapOnEight()
        {
            App.Tap(buttonEight);
            return this;
        }
        public MainScreenModel TapOnNine()
        {
            App.Tap(buttonNine);
            return this;
        }
        public MainScreenModel TapOnZero()
        {
            App.Tap(buttonZero);
            return this;
        }
        public MainScreenModel TapOnPoint()
        {
            App.Tap(buttonPoint);
            return this;
        }
        public MainScreenModel TapOnMult()
        {
            App.Tap(buttonMult);
            return this;
        }
        public MainScreenModel TapOnDiv()
        {
            App.Tap(buttonDiv);
            return this;
        }
        public MainScreenModel TapOnMinus()
        {
            App.Tap(buttonMinus);
            return this;
        }
        public MainScreenModel TapOnDel()
        {
            App.Tap(buttonDel);
            return this;
        }

        public string GetTextFromTextField()
        {
            return App.Query(textField)[0].Text.Trim();
        }
    }
}
