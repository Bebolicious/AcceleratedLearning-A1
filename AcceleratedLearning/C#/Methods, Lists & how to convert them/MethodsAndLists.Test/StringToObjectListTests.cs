using MethodsAndLists.Core;
using MethodsAndLists.Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodsAndLists.Test
{
    [TestClass]
    public class StringToObjectListTests
    {
        StringToObjectList x = new StringToObjectList();

        [TestMethod]
#pragma warning restore IDE1006 // Naming Styles
        public void parsecities_should_return_four_cites()
#pragma warning restore IDE1006 // Naming Styles
        {
            List<City> cities = x.ParseCities("Göteborg,401956;Lomma,13016;Mönsterås,5201;Östra Tommarp,293");

            Assert.AreEqual(4, cities.Count());

            Assert.AreEqual("Göteborg", cities[0].Name);
            Assert.AreEqual(401956, cities[0].Population);

            Assert.AreEqual("Lomma", cities[1].Name);
            Assert.AreEqual(13016, cities[1].Population);

            Assert.AreEqual("Mönsterås", cities[2].Name);
            Assert.AreEqual(5201, cities[2].Population);

            Assert.AreEqual("Östra Tommarp", cities[3].Name);
            Assert.AreEqual(293, cities[3].Population);
        }

        [TestMethod]
#pragma warning disable IDE1006 // Naming Styles
        public void parsecities_should_return_one_city_when_just_one_city_is_supplied()
#pragma warning restore IDE1006 // Naming Styles
        {
            List<City> cities = x.ParseCities("Mönsterås,5201");

            Assert.AreEqual(1, cities.Count());

            Assert.AreEqual("Mönsterås", cities[0].Name);
            Assert.AreEqual(5201, cities[0].Population);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
#pragma warning disable IDE1006 // Naming Styles
        public void parsecities_should_not_allow_null()
#pragma warning restore IDE1006 // Naming Styles
        {
            List<City> cities = x.ParseCities(null);
        }

        [TestMethod]
#pragma warning disable IDE1006 // Naming Styles
        public void parsecities_should_give_empty_list_if_just_white_spaces_is_supplied()
#pragma warning restore IDE1006 // Naming Styles
        {
            var result1 = x.ParseCities("");
            Assert.AreEqual(0, result1.Count);

            var result2 = x.ParseCities("   ");
            Assert.AreEqual(0, result2.Count);

            var result3 = x.ParseCities(" \t   \t   \n  \n");
            Assert.AreEqual(0, result3.Count);
        }

        [TestMethod]
        [DataRow("")]
        [DataRow("   ")]
        [DataRow(" \t   \t   \n  \n")]
#pragma warning disable IDE1006 // Naming Styles
        public void same_test_with_datarows(string input)
#pragma warning restore IDE1006 // Naming Styles
        {
            var result = x.ParseCities(input);
            Assert.AreEqual(0, result.Count);
        }
    }
}
