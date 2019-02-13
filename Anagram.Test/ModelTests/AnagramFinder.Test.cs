using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Anagram.Models;

namespace Anagram.Test
{
    [TestClass]
    public class AnagramTest
    {
        [TestMethod]
        public void AnagramTester_CanAcceptInput_String()
        {
            string testString1 = "Poorly";
            AnagramFinder testFinder = new AnagramFinder(testString1);
            Assert.AreEqual (testString1, testFinder.GetString());
            
        }  
    }
}