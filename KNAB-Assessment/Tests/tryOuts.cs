using System;

namespace KNAB_Assessment.Tests
{
	[TestFixture]
	class tryOuts
	{
		private int expectedNumber;
		private int actualNumber;

		public tryOuts() {
            this.expectedNumber = 1;
            this.actualNumber = 2;
        }

		[SetUp]
		public void Setup()
		{
			
        }

		[Test]
		public void checkEqual()
		{
			Assert.That(actualNumber, Is.EqualTo(expectedNumber), "actual number "+ actualNumber + " is not equal to expected number " + expectedNumber);
		}
	}
}

