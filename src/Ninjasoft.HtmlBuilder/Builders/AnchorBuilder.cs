using System.Xml.Linq;

namespace Ninjasoft.HtmlBuilder.Builders
{
    public sealed class AnchorBuilder
    {
        public AnchorBuilder()
        {
            _anchorElement = new XElement("a");
        }

        public AnchorBuilder SetAttribute(string name, string value)
        {
            _anchorElement.SetAttributeValue(name, value);
            return this;
        }

        public AnchorBuilder SetClass(string className) => SetAttribute("class", className);

        public AnchorBuilder SetId(string className) => SetAttribute("id", className);

        public AnchorBuilder SetHref(string href) => SetAttribute("href", href);

        public AnchorBuilder SetValue(string value)
        {
            _anchorElement.Value = value;
            return this;
        }

        internal XElement Build()
        {
            if (string.IsNullOrEmpty(_anchorElement.Value))
                _anchorElement.Value = "";
            return _anchorElement;
        }

        private readonly XElement _anchorElement;
    }
}
