using System.Xml.Linq;

namespace Ninjasoft.HtmlBuilder.Builders
{
    public sealed class TextareaBuilder
    {
        public TextareaBuilder()
        {
            _textareaElement = new XElement("textarea", "");
        }

        public TextareaBuilder SetAttribute(string name, string value)
        {
            _textareaElement.SetAttributeValue(name, value);
            return this;
        }

        public TextareaBuilder SetClass(string className) => SetAttribute("class", className);

        public TextareaBuilder SetId(string className) => SetAttribute("id", className);

        internal XElement Build()
        {
            return _textareaElement;
        }

        private readonly XElement _textareaElement;
    }
}
