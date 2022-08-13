using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        [Category("UI")]
        public void PrompedLabelIsDisplayed()
        {
            AppResult[] results = app.WaitForElement(c => c.Marked("Select a die:"));

            Assert.IsTrue(results.Any());
        }
        [Test]
        [Category("UI")]
        public void OptionsAreDisplayed()
        {
            Assert.IsTrue(app.Query(c => c.Marked("d4")).Any());
            Assert.IsTrue(app.Query(c => c.Marked("d6")).Any());

            AppResult[] results = app.Query(c => c.Marked("d8"));
            Assert.IsTrue(results.Any());
        }
        [Test]
        [Category("UI")]
        public void OptionsCanBeChecked()
        {
            app.Tap(c => c.Marked("d4"));
            Assert.IsTrue(app.Query(c =>
            c.Marked("d4")                     // look for items 
            .Invoke("isChecked"))              // call the isChecked method of the RadioButton
                .FirstOrDefault()              // get the first result (there should only be one)
                .Equals(true)                   // check that the view is checked (isChecked = true)
                );
            app.Tap(c => c.Marked("d4"));
            Assert.IsTrue(app.Query(c =>
            c.Marked("d4")                     // look for items 
            .Invoke("isChecked"))              // call the isChecked method of the RadioButton
                .FirstOrDefault()              // get the first result (there should only be one)
                .Equals(true)                   // check that the view is checked (isChecked = true)
                );
            app.Tap(c => c.Marked("d4"));
            Assert.IsTrue(app.Query(c =>
            c.Marked("d4")                     // look for items 
            .Invoke("isChecked"))              // call the isChecked method of the RadioButton
                .FirstOrDefault()              // get the first result (there should only be one)
                .Equals(false)                   // check that the view is checked (isChecked = false)
                );
        }
        [Test]
        [Category("UI")]
        public void RollButtonsAreDisplayed()
        {
            //Assert.IsTrue(app.Query("Display one result").Any());
            //Assert.IsTrue(app.Query("Display two results").Any());
            AppResult[] results = app.Query(c => c.Property("text").Contains("Display "));
            Assert.IsTrue(results.Length == 2);
        }

        [Test]
        [Category("UI")]
        public void LabelResult1IsDisplayed()
        {
            app.Tap(c => c.Property("text").Contains("Display one result"));

            AppResult[] results = app.Query(c => c.Property("text").Contains("roll"));

            Assert.IsTrue(results.Length > 0);

        }

        [Test]
        [Category("UI")]
        public void LabelResult2IsDisplayed()
        {
            app.Tap(c => c.Marked("d4"));
            app.Tap(c => c.Property("text").Contains("Display two results"));

            AppResult[] results = app.Query(c => c.Property("text").Contains("Die 2"));

            Assert.IsTrue(results.Length > 0);

        }

        [Test]
        public void RollOnceIstapped()
        {
            app.Tap(c => c.Marked("Roll Once"));

            string resultOneText = app.Query(c => c.Id("ResultOne"))[0].Text;
            int resultVal = int.Parse(resultOneText);

            Assert.NotNull(resultVal);
        }

        [Test]
        public void RollTwiceIsTapped()
        {
            app.Tap(c => c.Marked("Roll Twice"));

            string resultOneText = app.Query(c => c.Id("resultOne"))[0].Text;
            int resultVal = int.Parse(resultOneText);

            Assert.NotNull(resultVal);

            string resultTwoText = app.Query(c => c.Id("resultTwice"))[0].Text;
            int resultValTwo = int.Parse(resultTwoText);

            Assert.NotNull(resultValTwo);
        }
    }
}
