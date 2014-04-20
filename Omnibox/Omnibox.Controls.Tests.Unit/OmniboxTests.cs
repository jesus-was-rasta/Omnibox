using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;


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
