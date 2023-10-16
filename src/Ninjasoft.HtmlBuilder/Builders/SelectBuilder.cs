using System.Xml.Linq;

namespace Ninjasoft.HtmlBuilder.Builders
{
    public sealed class SelectBuilder
    {
        public SelectBuilder()
        {
            _textareaElement = new XElement("select", "");
        }

        public SelectBuilder AddOption(string text)
        {
            _textareaElement.Add(new XElement("option", text));
            return this;
        }

        public SelectBuilder SetAttribute(string name, string value)
        {
            _textareaElement.SetAttributeValue(name, value);
            return this;
        }

        public SelectBuilder SetClass(string className) => SetAttribute("class", className);

        public SelectBuilder SetId(string className) => SetAttribute("id", className);

        internal XElement Build()
        {
            return _textareaElement;
        }

        private readonly XElement _textareaElement;
    }
}
