using System.Xml.Linq;

namespace Ninjasoft.HtmlBuilder.Builders
{
    public sealed class LinkBuilder
    {
        public LinkBuilder()
        {
            _linkElement = new XElement("link");
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

        public LinkBuilder SetHref(string href)
        {
            _linkElement.SetAttributeValue("href", href);
            return this;
        }

        internal XElement Build()
        {
            return _linkElement;
        }

        private readonly XElement _linkElement;
    }
}
