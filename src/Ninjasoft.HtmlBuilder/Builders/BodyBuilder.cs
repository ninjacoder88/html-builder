using System.Xml.Linq;

namespace Ninjasoft.HtmlBuilder.Builders
{
    public sealed class BodyBuilder
    {
        public BodyBuilder()
        {
            _bodyElement = new XElement("body");
        }

        public BodyBuilder AddParagraph(string text)
        {
            _bodyElement.Add(new XElement("p"));
            return this;
        }

        public BodyBuilder AddTable(Action<TableBuilder> action)
        {
            TableBuilder tableBuilder = new TableBuilder();
            action(tableBuilder);
            _bodyElement.Add(tableBuilder.Build());
            return this;
        }

        public BodyBuilder AddHeading(Heading heading, string text)
        {
            _bodyElement.Add(new XElement(heading.Tag, text));
            return this;
        }

        public BodyBuilder AddLineBreak()
        {
            _bodyElement.Add(new XElement("br"));
            return this;
        }

        public BodyBuilder AddHorizontalRule()
        {
            _bodyElement.Add(new XElement("hr"));
            return this;
        }

        public BodyBuilder AddDiv()
        {
            _bodyElement.Add(new XElement("div"));
            return this;
        }

        public BodyBuilder AddList(ListType listType, Action<ListBuilder> action)
        {
            ListBuilder listBuilder = new ListBuilder(listType);
            action(listBuilder);
            _bodyElement.Add(listBuilder.Build());
            return this;
        }

        internal XElement Build()
        {
            return _bodyElement;
        }

        private readonly XElement _bodyElement;
    }
}
