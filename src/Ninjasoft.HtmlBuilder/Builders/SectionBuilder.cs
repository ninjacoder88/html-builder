using Ninjasoft.HtmlBuilder.Enumerations;
using System.Xml.Linq;

namespace Ninjasoft.HtmlBuilder.Builders
{
    public sealed class SectionBuilder
    {
        public SectionBuilder()
        {
            _sectionElement = new XElement("section");
        }

        public SectionBuilder SetAttribute(string name, string value)
        {
            _sectionElement.SetAttributeValue(name, value);
            return this;
        }

        public SectionBuilder AddAnchor(Action<AnchorBuilder> builder)
        {
            _sectionElement.AddAnchor(builder);
            return this;
        }

        public SectionBuilder AddButton(Action<ButtonBuilder> builder)
        {
            _sectionElement.AddButton(builder);
            return this;
        }

        public SectionBuilder AddDiv(Action<DivBuilder> builder)
        {
            _sectionElement.AddDiv(builder);
            return this;
        }

        public SectionBuilder AddForm(Action<FormBuilder> builder)
        {
            _sectionElement.AddForm(builder);
            return this;
        }

        public SectionBuilder AddHeading(Heading heading, string text)
        {
            _sectionElement.AddHeading(heading, text);
            return this;
        }

        public SectionBuilder AddHorizontalRule()
        {
            _sectionElement.AddHorizontalRule();
            return this;
        }

        public SectionBuilder AddImage(string source)
        {
            _sectionElement.AddImage(source);
            return this;
        }

        public SectionBuilder AddInput(InputType inputType, Action<InputBuilder> builder)
        {
            _sectionElement.AddInput(inputType, builder);
            return this;
        }

        public SectionBuilder AddLabel(string text)
        {
            _sectionElement.AddLabel(text);
            return this;
        }

        public SectionBuilder AddLineBreak()
        {
            _sectionElement.AddLineBreak();
            return this;
        }

        public SectionBuilder AddList(ListType listType, Action<ListBuilder> builder)
        {
            _sectionElement.AddList(listType, builder);
            return this;
        }

        public SectionBuilder AddParagraph(string text)
        {
            _sectionElement.AddParagraph(text);
            return this;
        }

        public SectionBuilder AddSection(Action<SectionBuilder> builder)
        {
            _sectionElement.AddSection(builder);
            return this;
        }

        public SectionBuilder AddSelect(Action<SelectBuilder> builder)
        {
            _sectionElement.AddSelect(builder);
            return this;
        }

        public SectionBuilder AddTable(Action<TableBuilder> builder)
        {
            _sectionElement.AddTable(builder);
            return this;
        }

        public SectionBuilder AddTextarea(Action<TextareaBuilder> builder)
        {
            _sectionElement.AddTextarea(builder);
            return this;
        }

        public SectionBuilder AddHtml(string html)
        {
            _sectionElement.Add(new XRaw(html));
            return this;
        }


        public SectionBuilder SetClass(string className) => SetAttribute("class", className);

        public SectionBuilder SetId(string className) => SetAttribute("id", className);

        public SectionBuilder SetText(string text)
        {
            _sectionElement.SetValue(text);
            return this;
        }

        public SectionBuilder SetType(ButtonType buttonType)
        {
            SetAttribute("type", buttonType.TheType);
            return this;
        }

        internal XElement Build()
        {
            return _sectionElement;
        }

        private readonly XElement _sectionElement;
    }
}