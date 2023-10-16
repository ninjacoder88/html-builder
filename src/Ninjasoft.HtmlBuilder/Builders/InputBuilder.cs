using Ninjasoft.HtmlBuilder.Enumerations;
using System.Xml.Linq;

namespace Ninjasoft.HtmlBuilder.Builders
{
    public sealed class InputBuilder
    {
        public InputBuilder(InputType inputType)
        {
            _inputElement = new XElement("input");
            SetAttribute("type", inputType.Type);
        }

        public InputBuilder SetAttribute(string name, string value)
        {
            _inputElement.SetAttributeValue(name, value);
            return this;
        }

        public InputBuilder SetClass(string className) => SetAttribute("class", className);

        public InputBuilder SetId(string className) => SetAttribute("id", className);

        internal XElement Build()
        {
            return _inputElement;
        }

        private readonly XElement _inputElement;
    }
}
