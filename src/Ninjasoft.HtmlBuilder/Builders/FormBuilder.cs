using Ninjasoft.HtmlBuilder.Enumerations;
using System.Xml.Linq;

namespace Ninjasoft.HtmlBuilder.Builders
{
    public class FormBuilder
    {
        public FormBuilder()
        {
            _formElement = new XElement("form");
        }

        public FormBuilder AddDiv(Action<DivBuilder> builder)
        {
            _formElement.AddDiv(builder);
            return this;
        }

        public FormBuilder SetAction(string url)
        {
            SetAttribute("action", url);
            return this;
        }

        public FormBuilder SetAttribute(string name, string value)
        {
            _formElement.SetAttributeValue(name, value);
            return this;
        }

        public FormBuilder SetClass(string className) => SetAttribute("class", className);

        public FormBuilder SetId(string className) => SetAttribute("id", className);

        public FormBuilder SetMethod(FormMethod method)
        {
            SetAttribute("method", method.Method);
            return this;
        }

        internal XElement Build()
        {
            return _formElement;
        }

        private readonly XElement _formElement;
    }
}
