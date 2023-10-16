using System.Xml.Linq;

namespace Ninjasoft.HtmlBuilder.Builders
{
    public sealed class TableBuilder
    {
        public TableBuilder()
        {
            _tableElement = new XElement("table");
        }

        public TableBuilder AddBody(Action<TableBodyBuilder> action)
        {
            TableBodyBuilder tableBodyBuilder = new TableBodyBuilder();
            action(tableBodyBuilder);
            _tableElement.Add(tableBodyBuilder.Build());
            return this;
        }

        public TableBuilder AddHead(Action<TableHeadBuilder> action)
        {
            TableHeadBuilder tableHeadBuilder = new TableHeadBuilder();
            action(tableHeadBuilder);
            _tableElement.Add(tableHeadBuilder.Build());
            return this;
        }

        public TableBuilder SetAttribute(string name, string value)
        {
            _tableElement.SetAttributeValue(name, value);
            return this;
        }

        public TableBuilder SetClass(string className) => SetAttribute("class", className);

        public TableBuilder SetId(string className) => SetAttribute("id", className);

        internal XElement Build()
        {
            return _tableElement;
        }

        private readonly XElement _tableElement;
    }
}
