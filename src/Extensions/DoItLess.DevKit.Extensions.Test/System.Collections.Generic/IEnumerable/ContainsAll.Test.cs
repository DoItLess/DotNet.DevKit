﻿using System.Collections.Generic;
using NUnit.Framework;

namespace DoItLess.DevKit.Extensions.Test.System.Collections.Generic.IEnumerable
{
    public class ContainsAllTest
    {
        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public bool Test1(IEnumerable<string> input, IEnumerable<string> items)
        {
            return input.ContainsAll(items);
        }


        private class TestCase
        {
            public static IEnumerable<TestCaseData> Case1
            {
                get
                {
                    yield return new TestCaseData(new List<string> {"dd", "ddd"}, new[] {"aaa"}).Returns(false);
                    yield return new TestCaseData(new List<string> {"dd", "ddd"}, new[] {"dd"}).Returns(true);
                    yield return new TestCaseData(new List<string> {"dd", "ddd"}, new[] {"ddd", "dd"}).Returns(true);
                    yield return new TestCaseData(new List<string> {"dd", "ddd"}, new[] {"ddd", "dd", "ccc"}).Returns(false);
                    yield return new TestCaseData(new[] {"dd", "ddd"}, new[] {"dd"}).Returns(true);
                    yield return new TestCaseData(new[] {"dd", "ddd"}, new[] {"aaa"}).Returns(false);
                    yield return new TestCaseData(new[] {"dd", "ddd"}, new[] {"ddd", "dd"}).Returns(true);
                    yield return new TestCaseData(new[] {"dd", "ddd"}, new[] {"ddd", "dd", "ccc"}).Returns(false);
                }
            }
        }
    }
}