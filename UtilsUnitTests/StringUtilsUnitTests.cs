using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReflectionUnitTesting;
using System.Reflection;

namespace Utils.UnitTests
{
    [TestClass]
    public class StringUtilsUnitTests : UtilsBaseUnitTest
    {
        [TestMethod]
        public void AssemblyShouldExist()
        {
            GetAssembly();
        }

        [TestMethod]
        public void ClassShouldExist()
        {
            GetType();
        }          
    }
}
