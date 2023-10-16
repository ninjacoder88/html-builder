using Ninjasoft.HtmlBuilder.Enumerations;
using System.Xml.Linq;

namespace Ninjasoft.HtmlBuilder.Builders
{
    public sealed class DivBuilder
    {
        public DivBuilder()
        {
            _divElement = new XElement("div");
        }

        public DivBuilder AddAnchor(Action<AnchorBuilder> builder)
        {
            _divElement.AddAnchor(builder);
            return this;
        }

        public DivBuilder AddButton(Action<ButtonBuilder> builder)
        {
            _divElement.AddButton(builder);
            return this;
        }

        public DivBuilder AddDiv(Action<DivBuilder> builder)
        {
            _divElement.AddDiv(builder);
            return this;
        }

        public DivBuilder AddForm(Action<FormBuilder> builder)
        {
            _divElement.AddForm(builder);
            return this;
        }

        public DivBuilder AddHeading(Heading heading, string text)
        {
            _divElement.AddHeading(heading, text);
            return this;
        }

        public DivBuilder AddHorizontalRule()
        {
            _divElement.AddHorizontalRule();
            return this;
        }

        public DivBuilder AddImage(string source)
        {
            _divElement.AddImage(source);
            return this;
        }

        public DivBuilder AddInput(InputType inputType, Action<InputBuilder> builder)
        {
            _divElement.AddInput(inputType, builder);
            return this;
        }

        public DivBuilder AddLabel(string text)
        {
            _divElement.AddLabel(text);
            return this;
        }

        public DivBuilder AddLineBreak()
        {
            _divElement.AddLineBreak();
            return this;
        }

        public DivBuilder AddList(ListType listType, Action<ListBuilder> builder)
        {
            _divElement.AddList(listType, builder);
            return this;
        }

        public DivBuilder AddParagraph(string text)
        {
            _divElement.AddParagraph(text);
            return this;
        }

        public DivBuilder AddSelect(Action<SelectBuilder> builder)
        {
            _divElement.AddSelect(builder);
            return this;
        }

        public DivBuilder AddTable(Action<TableBuilder> builder)
        {
            _divElement.AddTable(builder);
            return this;
        }

        public DivBuilder AddTextarea(Action<TextareaBuilder> builder)
        {
            _divElement.AddTextarea(builder);
            return this;
        }

        public DivBuilder SetAttribute(string name, string value)
        {
            _divElement.SetAttributeValue(name, value);
            return this;
        }

        public DivBuilder SetClass(string className) => SetAttribute("class", className);

        public DivBuilder SetId(string className) => SetAttribute("id", className);

        internal XElement Build()
        {
            return _divElement;
        }

        private readonly XElement _divElement;
    }
}
