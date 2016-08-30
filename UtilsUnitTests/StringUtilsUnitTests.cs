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
            GetMethod();
        }

        private MethodInfo GetMethod()
        {
            var type = GetType();
            return type.MethodExists("Pluralize");
        }

        [TestMethod]
        public void PluralizeMethodShouldBeStatic()
        {
            var method = GetMethod();
            Assert.IsTrue(method.IsStatic, "Method should be static.");
        }

        [TestMethod]
        public void PluralizeMethodShouldReturnAString()
        {
            var method = GetMethod();
            Assert.AreEqual(method.ReturnType, typeof(string), "Method should return a string.");
        }

        [TestMethod]
        public void PluralizeMethodShouldAcceptTwoParameters()
        {
            var method = GetMethod();
            var parameters = method.GetParameters();
            var expected = 2;
            Assert.AreEqual(expected, parameters.Length, "Method should accept two parameters.");
        }

        [TestMethod]
        public void PluralizeFirstParameterShouldBeAString()
        {
            var method = GetMethod();
            var parameter = method.GetParameters()[0];
            var expected = typeof(string);
            Assert.AreEqual(expected, parameter.ParameterType, "First parameter should be a string.");
        }
    }
}
