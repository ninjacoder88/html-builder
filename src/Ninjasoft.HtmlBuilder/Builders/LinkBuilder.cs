using System.Xml.Linq;

namespace Ninjasoft.HtmlBuilder.Builders
{
    public sealed class LinkBuilder
    {
        public LinkBuilder()
        {
            _linkElement = new XElement("link");
        }

        public LinkBuilder SetHref(string href)
        {
            _linkElement.SetAttributeValue("href", href);
            return this;
        }

        public LinkBuilder SetRel(string relationship)
        {
            _linkElement.SetAttributeValue("rel", relationship);
            return this;
        }

        public LinkBuilder SetType(string type)
        {
            _linkElement.SetAttributeValue("type", type);
            return this;
        }

        public LinkBuilder SetAttribute(string name, string value)
        {
            _linkElement.SetAttributeValue(name, value);
            return this;
        }

        public LinkBuilder SetClass(string className) => SetAttribute("class", className);

        public LinkBuilder SetId(string className) => SetAttribute("id", className);

        internal XElement Build()
        {
            return _linkElement;
        }

        private readonly XElement _linkElement;
    }
}
