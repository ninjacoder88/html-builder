using Ninjasoft.HtmlBuilder.Enumerations;
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

        public ListBuilder Add(int number) => Add(number.ToString());

        public ListBuilder Add(decimal number) => Add(number.ToString());

        public ListBuilder SetAttribute(string name, string value)
        {
            _listElement.SetAttributeValue(name, value);
            return this;
        }

        public ListBuilder SetClass(string className) => SetAttribute("class", className);

        public ListBuilder SetId(string className) => SetAttribute("id", className);

        public XElement Build()
        {
            return _listElement;
        }

        private readonly XElement _listElement;
    }
}
