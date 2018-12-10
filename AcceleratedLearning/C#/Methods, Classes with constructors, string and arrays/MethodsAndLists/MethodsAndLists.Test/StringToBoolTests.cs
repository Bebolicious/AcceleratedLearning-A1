using MethodsAndLists.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace MethodsAndLists.Test
{
    public class StringToBoolTests
    {
        StringToBool x = new StringToBool();

        [TestMethod]

        public void Pilondrome()
        {

            var input = new List<string> { "" };
            var expected = new List<string> { "" };
            var result = x.IsPalindrome(input);

            CollectionAssert.AreEqual(expected, result);
        }
    


    }
}
