using Ninjasoft.HtmlBuilder.Builders;
using NUnit.Framework;

namespace Ninjasoft.HtmlBuilder.UnitTests
{
    [TestFixture]
    public class AnchorBuilderTests
    {
        [Test]
        public void AttributeIsSetCorrectly()
        {
            //SETUP
            var SUT = new AnchorBuilder();
            
            //TEST
            var result = SUT.SetAttribute("data-bind", "hidden: hidden").Build().ToString();

            //VALIDATE
            Assert.That(result, Is.EqualTo("<a data-bind=\"hidden: hidden\"></a>"));
        }

        [Test]
        public void AttributeSetTwice_TakesMostRecentValue()
        {
            //SETUP
            var SUT = new AnchorBuilder();

            //TEST
            var result = SUT.SetAttribute("data-bind", "click: doIt").SetAttribute("data-bind", "hidden: hidden").Build().ToString();

            //VALIDATE
            Assert.That(result, Is.EqualTo("<a data-bind=\"hidden: hidden\"></a>"));
        }

        [Test]
        public void ClassIsSetCorrectly()
        {
            //SETUP
            var SUT = new AnchorBuilder();

            //TEST
            var result = SUT.SetClass("btn").Build().ToString();

            //VALIDATE
            Assert.That(result, Is.EqualTo("<a class=\"btn\"></a>"));
        }

        [Test]
        public void ClassSetTwice_TakesMostRecentValue()
        {
            //SETUP
            var SUT = new AnchorBuilder();

            //TEST
            var result = SUT.SetClass("button").SetClass("btn").Build().ToString();

            //VALIDATE
            Assert.That(result, Is.EqualTo("<a class=\"btn\"></a>"));
        }

        [Test]
        public void HrefIsSetCorrectly()
        {
            //SETUP
            var SUT = new AnchorBuilder();

            //TEST
            var result = SUT.SetHref("http://test.com").Build().ToString();

            //VALIDATE
            Assert.That(result, Is.EqualTo("<a href=\"http://test.com\"></a>"));
        }

        [Test]
        public void HrefSetTwice_TakesMostRecentValue()
        {
            //SETUP
            var SUT = new AnchorBuilder();

            //TEST
            var result = SUT.SetHref("http://demo.com").SetHref("http://test.com").Build().ToString();

            //VALIDATE
            Assert.That(result, Is.EqualTo("<a href=\"http://test.com\"></a>"));
        }

        [Test]
        public void ValueIsSetCorrectly()
        {
            //SETUP
            var SUT = new AnchorBuilder();

            //TEST
            var result = SUT.SetValue("Click Me").Build().ToString();

            //VALIDATE
            Assert.That(result, Is.EqualTo("<a>Click Me</a>"));
        }

        [Test]
        public void ValueSetTwice_TakesMostRecentValue()
        {
            //SETUP
            var SUT = new AnchorBuilder();

            //TEST
            var result = SUT.SetValue("Click Here").SetValue("Click Me").Build().ToString();

            //VALIDATE
            Assert.That(result, Is.EqualTo("<a>Click Me</a>"));
        }

        [Test]
        public void BuilderIsSettingAllValuesCorrectly()
        {
            //SETUP
            var SUT = new AnchorBuilder();

            //TEST
            var result = SUT.SetClass("btn")
                .SetAttribute("data-bind", "hidden: hidden")
                .SetValue("Click Me")
                .SetHref("http://test.com")
                .Build().ToString();

            //VALIDATE
            Assert.That(result, Is.EqualTo("<a class=\"btn\" data-bind=\"hidden: hidden\" href=\"http://test.com\">Click Me</a>"));
        }
    }
}
