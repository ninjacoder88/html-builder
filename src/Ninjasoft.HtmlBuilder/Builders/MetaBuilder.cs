using System.Xml.Linq;

namespace Ninjasoft.HtmlBuilder.Builders
{
    public sealed class MetaBuilder
    {
        public MetaBuilder()
        {
            _metaElment = new XElement("meta");
        }

        public MetaBuilder Set(string name, string value)
        {
            _metaElment.SetAttributeValue(name, value);
            return this;
        }

        internal XElement Build()
        {
            return _metaElment;
        }

        private readonly XElement _metaElment;
    }
}
