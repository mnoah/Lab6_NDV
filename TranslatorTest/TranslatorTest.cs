using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab6_NDV;

namespace TranslatorTest
{
    [TestClass]
    public class TranslatorTest1
    {
        [TestMethod]
        public void TestThatAppleTranslateToAppleway()
        {
            string toTranslate = "apple";
           Translator brad = new Translator();
           string translatedSreing = brad.Translate(toTranslate);
            Assert.AreEqual("appleway", translatedSreing);

           
        }

        [TestMethod]
        public void TestLaptop()
        {
            string toTranslate = "laptop";
            Translator brad = new Translator();
            string translatedSreing = brad.Translate(toTranslate);
            Assert.AreEqual("aptoplay", translatedSreing);


        }

        [TestMethod]
        public void TestBread()
        {
            string toTranslate = "Bread";
            Translator brad = new Translator();
            string translatedSreing = brad.Translate(toTranslate);
            Assert.AreEqual("eadbray", translatedSreing);


        }

        [TestMethod]
        public void TestScrap()
        {
            string toTranslate = "scrap";
            Translator brad = new Translator();
            string translatedSreing = brad.Translate(toTranslate);
            Assert.AreEqual("apscray", translatedSreing);


        }
    }
}
