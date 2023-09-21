using System.Xml.Linq;

namespace Ninjasoft.HtmlBuilder.Builders
{
    public sealed class BodyBuilder
    {
        public BodyBuilder()
        {
            _bodyElement = new XElement("body");
        }

        public BodyBuilder AddAnchor(Action<AnchorBuilder> action)
        {
            AnchorBuilder anchorBuilder = new AnchorBuilder();
            action(anchorBuilder);
            _bodyElement.Add(anchorBuilder.Build());
            return this;
        }

        public BodyBuilder AddButon(string text)
        {
            _bodyElement.Add(new XElement("button", text));
            return this;
        }

        public BodyBuilder AddDiv()
        {
            _bodyElement.Add(new XElement("div"));
            return this;
        }

        public BodyBuilder AddForm()
        {
            _bodyElement.Add(new XElement("form"));
            return this;
        }

        public BodyBuilder AddHeading(Heading heading, string text)
        {
            _bodyElement.Add(new XElement(heading.Tag, text));
            return this;
        }

        public BodyBuilder AddHorizontalRule()
        {
            _bodyElement.Add(new XElement("hr"));
            return this;
        }

        public BodyBuilder AddImage(string source)
        {
            var imageElement = new XElement("img");
            imageElement.SetAttributeValue("src", source);
            _bodyElement.Add(imageElement);
            return this;
        }

        public BodyBuilder AddInput(InputType inputType)
        {
            var inputElement = new XElement("input");
            inputElement.SetAttributeValue("type", inputType.Type);
            _bodyElement.Add(inputElement);
            return this;
        }

        public BodyBuilder AddLineBreak()
        {
            _bodyElement.Add(new XElement("br"));
            return this;
        }

        public BodyBuilder AddList(ListType listType, Action<ListBuilder> action)
        {
            ListBuilder listBuilder = new ListBuilder(listType);
            action(listBuilder);
            _bodyElement.Add(listBuilder.Build());
            return this;
        }

        public BodyBuilder AddParagraph(string text)
        {
            _bodyElement.Add(new XElement("p", text));
            return this;
        }

        public BodyBuilder AddTable(Action<TableBuilder> action)
        {
            TableBuilder tableBuilder = new TableBuilder();
            action(tableBuilder);
            _bodyElement.Add(tableBuilder.Build());
            return this;
        }

        internal XElement Build()
        {
            return _bodyElement;
        }

        private readonly XElement _bodyElement;
    }
}
