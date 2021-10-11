using ExoVersionning.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoVersionning.Functions
{
    [TestClass]
    public class UnitTestFunctions
    {
        [TestMethod]
        public void SetNameAndDisplayIt()
        {
            Example example = new Example();
            example.Name = "Dorian";
            Assert.AreEqual(example.Name, "Dorian");
        }
    }
}
