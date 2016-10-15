using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReflectionUnitTesting;
using System.Reflection;

namespace Utils.UnitTests
{
    [TestClass]
    public class UtilsBaseUnitTest
    {
        public Assembly GetAssembly()
        {
            return ReflectionAssert.AssemblyExists("Utils.dll");
        }

        public Type GetClass()
        {
            var assembly = GetAssembly();
            return assembly.TypeExists("Utils", "StringUtils");
        }
    }
}
