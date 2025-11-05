using Ninjasoft.HtmlBuilder.Builders;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninjasoft.HtmlBuilder.UnitTests
{
    [TestFixture]
    public class DivBuilderTests
    {
        [Test]
        public void Test()
        {
            //setup
            var SUT = new DivBuilder();

            //test
            var result = SUT.AddHtml("<p>Hello</p>").Build().ToString();

            //validate
            Assert.That(result, Is.EqualTo("<div><p>Hello</p></div>"));
        }

        [Test]
        public void Test1()
        {
            //setup
            var SUT = new DivBuilder();

            //test
            var result = SUT.AddHtml("Hello").Build().ToString();

            //validate
            Assert.That(result, Is.EqualTo("<div>Hello</div>"));
        }
    }
}
