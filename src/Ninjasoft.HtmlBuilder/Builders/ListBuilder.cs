using System.Xml.Linq;

namespace Ninjasoft.HtmlBuilder.Builders
{
    public sealed class ListBuilder
    {
        public ListBuilder(ListType listType)
        {
            _listElement = new XElement(listType.Tag);
        }

        public ListBuilder Add(string text)
        {
            _listElement.Add(new XElement("li", text));
            return this;
        }

        public XElement Build()
        {
            return _listElement;
        }

        private readonly XElement _listElement;
    }
}
