using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReflectionUnitTesting;

namespace Utils.UnitTests
{
    [TestClass]
    public class StringUtilsUnitTests : UtilsBaseUnitTest
    {
        [TestMethod]
        public void StringUtilsClassShouldExist()
        {
            GetType();
        }

        new Type GetType()
        {
            var assembly = GetAssembly();
            return assembly.TypeExists("Utils", "StringUtils");
        }

        [TestMethod]
        public void PluralizeMethodShouldExist()
        {
            var type = GetType();
            type.MethodExists("Pluralize");
        }
    }
}
