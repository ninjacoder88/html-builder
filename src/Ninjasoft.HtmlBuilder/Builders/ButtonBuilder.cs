using Ninjasoft.HtmlBuilder.Enumerations;
using System.Xml.Linq;

namespace Ninjasoft.HtmlBuilder.Builders
{
    public sealed class ButtonBuilder
    {
        public ButtonBuilder()
        {
            _buttonElement = new XElement("button");
        }

        public ButtonBuilder SetAttribute(string name, string value)
        {
            _buttonElement.SetAttributeValue(name, value);
            return this;
        }

        public ButtonBuilder SetClass(string className) => SetAttribute("class", className);

        public ButtonBuilder SetId(string className) => SetAttribute("id", className);

        public ButtonBuilder SetText(string text)
        {
            _buttonElement.SetValue(text);
            return this;
        }

        public ButtonBuilder SetType(ButtonType buttonType)
        {
            SetAttribute("type", buttonType.TheType);
            return this;
        }

        internal XElement Build()
        {
            return _buttonElement;
        }

        private readonly XElement _buttonElement;
    }
}
