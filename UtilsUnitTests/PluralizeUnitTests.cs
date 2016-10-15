using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReflectionUnitTesting;
using System.Reflection;
using System.Collections.Generic;

namespace Utils.UnitTests
{
    [TestClass]
    public class PluralizeUnitTests : UtilsBaseUnitTest
    {
        [TestMethod]
        public void MethodShouldExist()
        {
            GetMethod();
        }

        private MethodInfo GetMethod()
        {
            var type = GetClass();
            return type.MethodExists(
                methodName: "Pluralize",
                shouldBeStatic: true,
                shouldReturnType: typeof(string),
                parameterTypesAndNames: new List<Tuple<Type, String>> {
                    Tuple.Create(typeof(int), "number"),
                    Tuple.Create(typeof(string), "word") });
        }

        [TestMethod]
        public void Passing1ShouldReturn1Word()
        {
           ReflectionAssert.TestMethod(GetMethod(), null, new object[] {1, "word"}, "1 word");
        }

        [TestMethod]
        public void Passing2ShouldReturn2Words()
        {
            ReflectionAssert.TestMethod(GetMethod(), null, new object[] { 2, "word" }, "2 words");
        }


    }
}
