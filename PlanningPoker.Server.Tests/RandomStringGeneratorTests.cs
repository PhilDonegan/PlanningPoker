using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanningPoker.Server.Hubs.Helpers;
using System.Collections.Generic;

namespace PlanningPoker.Server.Tests
{
	[TestClass]
	public class RandomStringGeneratorTests
	{
		[TestMethod]
		public void TestStringGeneratorLength()
		{
			Assert.AreEqual(5, RandomStringGenerator.RandomString(5).Length);
		}

		[TestMethod]
		public void TestStringGeneratorIsRandom()
		{
			HashSet<string> values = new HashSet<string>();

			for (var i = 0; i < 1000; i++)
			{
				Assert.IsTrue(values.Add(RandomStringGenerator.RandomString(5)));
			}
		}
	}
}
