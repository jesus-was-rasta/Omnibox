#region Usings
using System;

using NUnit.Framework;


#endregion


namespace Omnibox.Controls.Tests.Unit
{
	[TestFixture]
	public class OmniboxTests
	{
		[SetUp]
		public void SetUp()
		{
		}

		[TearDown]
		public void TearDown()
		{
		}

		[Test]
		public void OmniboxControl_AddKeywords_Null_ThrowsException()
		{
			var omnibox = new OmniboxControl();
			Assert.Throws<ArgumentNullException>(() => omnibox.AddKeywords(null));
		}
	}
}