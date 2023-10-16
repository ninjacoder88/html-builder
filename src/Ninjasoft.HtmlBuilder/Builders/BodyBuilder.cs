using Ninjasoft.HtmlBuilder.Enumerations;
using System.Xml.Linq;

namespace Ninjasoft.HtmlBuilder.Builders
{
    public sealed class BodyBuilder
    {
        public BodyBuilder()
        {
            _bodyElement = new XElement("body");
        }

        public BodyBuilder AddAnchor(Action<AnchorBuilder> builder)
        {
            _bodyElement.AddAnchor(builder);
            return this;
        }

        public BodyBuilder AddButon(Action<ButtonBuilder> builder)
        {
            _bodyElement.AddButton(builder);
            return this;
        }

        public BodyBuilder AddDiv(Action<DivBuilder> builder)
        {
            _bodyElement.AddDiv(builder);
            return this;
        }

        public BodyBuilder AddForm(Action<FormBuilder> builder)
        {
            _bodyElement.AddForm(builder);
            return this;
        }

        public BodyBuilder AddHeading(Heading heading, string text)
        {
            _bodyElement.AddHeading(heading, text);
            return this;
        }

        public BodyBuilder AddHorizontalRule()
        {
            _bodyElement.AddHorizontalRule();
            return this;
        }

        public BodyBuilder AddImage(string source)
        {
            _bodyElement.AddImage(source);
            return this;
        }

        public BodyBuilder AddInput(InputType inputType, Action<InputBuilder> builder)
        {
            _bodyElement.AddInput(inputType, builder);
            return this;
        }

        public BodyBuilder AddLineBreak()
        {
            _bodyElement.AddLineBreak();
            return this;
        }

        public BodyBuilder AddList(ListType listType, Action<ListBuilder> builder)
        {
            _bodyElement.AddList(listType, builder);
            return this;
        }

        public BodyBuilder AddParagraph(string text)
        {
            _bodyElement.AddParagraph(text);
            return this;
        }

        public BodyBuilder AddScript(ScriptType scriptType, string source)
        {
            _bodyElement.AddScript(scriptType.TheType, source);
            return this;
        }

        public BodyBuilder AddScript(string scriptType, string source)
        {
            _bodyElement.AddScript(scriptType, source);
            return this;
        }

        public BodyBuilder AddTable(Action<TableBuilder> builder)
        {
            _bodyElement.AddTable(builder);
            return this;
        }

        public BodyBuilder SetAttribute(string name, string value)
        {
            _bodyElement.SetAttributeValue(name, value);
            return this;
        }

        public BodyBuilder SetClass(string className) => SetAttribute("class", className);

        public BodyBuilder SetId(string className) => SetAttribute("id", className);

        internal XElement Build()
        {
            return _bodyElement;
        }

        private readonly XElement _bodyElement;
    }
}
