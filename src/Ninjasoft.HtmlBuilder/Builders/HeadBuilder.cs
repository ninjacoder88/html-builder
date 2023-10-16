using System.Xml.Linq;

namespace Ninjasoft.HtmlBuilder.Builders
{
    public sealed class HeadBuilder
    {
        public HeadBuilder()
        {
            _headElement = new XElement("head");
        }

        public HeadBuilder AddLink(Action<LinkBuilder> action)
        {
            LinkBuilder linkBuilder = new LinkBuilder();
            action(linkBuilder);
            _headElement.Add(linkBuilder.Build());
            return this;
        }

        public HeadBuilder AddMeta(Action<MetaBuilder> action)
        {
            MetaBuilder metaBuilder = new MetaBuilder();
            action(metaBuilder);
            _headElement.Add(metaBuilder.Build());
            return this;
        }

        public HeadBuilder SetTitle(string title)
        {
            _headElement.Add(new XElement("title", title));
            return this;
        }

        public HeadBuilder SetAttribute(string name, string value)
        {
            _headElement.SetAttributeValue(name, value);
            return this;
        }

        public HeadBuilder SetClass(string className) => SetAttribute("class", className);

        public HeadBuilder SetId(string className) => SetAttribute("id", className);

        public XElement Build()
        {
            return _headElement;
        }

        private readonly XElement _headElement;
    }
}
