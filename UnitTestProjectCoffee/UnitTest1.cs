using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Кофемашина.Forms;

namespace UnitTestProjectCoffee
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_OK_180ml()
        {
            int ml = 180;
            string name_coffee = "Капучино";
            Mixing mix = new Mixing(name_coffee, ml);
            string milk = "20";
            string water = "60";
            string expectedResult = "90";
            string actualResult = mix.ML(milk, water);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod_OK_60ml()
        {
            int ml = 60;
            string name_coffee = "Капучино";
            Mixing mix = new Mixing(name_coffee, ml);
            string milk = "20";
            string water = "0";
            string expectedResult = "30";
            string actualResult = mix.ML(milk, water);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod_OK_300ml()
        {
            int ml = 300;
            string name_coffee = "Капучино";
            Mixing mix = new Mixing(name_coffee, ml);
            string milk = "0";
            string water = "60";
            string expectedResult = "230";
            string actualResult = mix.ML(milk, water);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod_Fail_milk_is_not_a_number()
        {
            int ml = 300;
            string name_coffee = "Капучино";
            Mixing mix = new Mixing(name_coffee, ml);
            string milk = "dfrgb";
            string water = "60";
            try
            {
                mix.ML(milk, water);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void TestMethod_Fail_water_is_not_a_number()
        {
            int ml = 300;
            string name_coffee = "Капучино";
            Mixing mix = new Mixing(name_coffee, ml);
            string milk = "10";
            string water = "";
            try
            {
                mix.ML(milk, water);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void TestMethod_Fail_water_less_than_0()
        {
            int ml = 300;
            string name_coffee = "Капучино";
            Mixing mix = new Mixing(name_coffee, ml);
            string milk = "10";
            string water = "-9";
            try
            {
                mix.ML(milk, water);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void TestMethod_Fail_milk_less_than_0()
        {
            int ml = 300;
            string name_coffee = "Капучино";
            Mixing mix = new Mixing(name_coffee, ml);
            string milk = "-10";
            string water = "12";
            try
            {
                mix.ML(milk, water);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void TestMethod_Fail_maxML_less_than_50()
        {
            int ml = 300;
            string name_coffee = "Капучино";
            Mixing mix = new Mixing(name_coffee, ml);
            string milk = "10";
            string water = "";
            try
            {
                mix.ML(milk, water);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void TestMethod_Fail_water_greater_than_maxML()
        {
            int ml = 300;
            string name_coffee = "Капучино";
            Mixing mix = new Mixing(name_coffee, ml);
            string milk = "1000";
            string water = "9";
            try
            {
                mix.ML(milk, water);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void TestMethod_Fail_greater_than_maxM()
        {
            int ml = 300;
            string name_coffee = "Капучино";
            Mixing mix = new Mixing(name_coffee, ml);
            string milk = "10";
            string water = "1000";
            try
            {
                mix.ML(milk, water);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void TestMethod_Fail_maxML_greater_than_290()
        {
            int ml = 600;
            string name_coffee = "Капучино";
            Mixing mix = new Mixing(name_coffee, ml);
            string milk = "10";
            string water = "10";
            try
            {
                mix.ML(milk, water);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void TestMethod_Fail_mikl_and_water_greater_than_maxML()
        {
            int ml = 60;
            string name_coffee = "Капучино";
            Mixing mix = new Mixing(name_coffee, ml);
            string milk = "30";
            string water = "30";
            try
            {
                mix.ML(milk, water);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void TestMethod_Fail_mikl_and_water_is_maxML()
        {
            int ml = 60;
            string name_coffee = "Капучино";
            Mixing mix = new Mixing(name_coffee, ml);
            string milk = "20";
            string water = "30";
            try
            {
                mix.ML(milk, water);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
            Assert.Fail();
        }
    }
}
