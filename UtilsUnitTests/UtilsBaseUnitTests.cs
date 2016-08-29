using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReflectionUnitTesting;
using System.Reflection;

namespace Utils.UnitTests
{
    [TestClass]
    public class UtilsBaseUnitTest
    {
        [TestMethod]
        public void UtilsAssemblyShouldExist()
        {
            GetAssembly();
        }

        public Assembly GetAssembly()
        {
            return ReflectionAssert.AssemblyExists("Utils.dll");
        }       
    }
}
