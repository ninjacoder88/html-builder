using System.Xml.Linq;

namespace Ninjasoft.HtmlBuilder.Builders
{
    public sealed class HtmlDocument
    {
        public HtmlDocument()
        {
            _htmlElement = new XElement("html");
        }

        public HtmlDocument AddBody(Action<BodyBuilder> action)
        {
            BodyBuilder bodyBuilder = new BodyBuilder();
            action(bodyBuilder);
            _htmlElement.Add(bodyBuilder.Build());
            return this;
        }

        public HtmlDocument AddHead(Action<HeadBuilder> action)
        {
            HeadBuilder headBuilder = new HeadBuilder();
            action(headBuilder);
            _htmlElement.Add(headBuilder.Build());
            return this;
        }

        public HtmlDocument SetAttribute(string name, string value)
        {
            _htmlElement.SetAttributeValue(name, value);
            return this;
        }

        public HtmlDocument SetClass(string className) => SetAttribute("class", className);

        public string Build()
        {
            var xDocument = new XDocument();
            xDocument.Add(_htmlElement);
            return xDocument.ToString();
        }
        private readonly XElement _htmlElement;
    }
}