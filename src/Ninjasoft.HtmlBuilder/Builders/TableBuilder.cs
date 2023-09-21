using System.Xml.Linq;

namespace Ninjasoft.HtmlBuilder.Builders
{
    public sealed class TableBuilder
    {
        public TableBuilder()
        {
            _tableElement = new XElement("table");
        }

        public TableBuilder AddHead(Action<TableHeadBuilder> action)
        {
            TableHeadBuilder tableHeadBuilder = new TableHeadBuilder();
            action(tableHeadBuilder);
            _tableElement.Add(tableHeadBuilder.Build());
            return this;
        }

        public TableBuilder AddBody(Action<TableBodyBuilder> action)
        {
            TableBodyBuilder tableBodyBuilder = new TableBodyBuilder();
            action(tableBodyBuilder);
            _tableElement.Add(tableBodyBuilder.Build());
            return this;
        }

        internal XElement Build()
        {
            return _tableElement;
        }

        private readonly XElement _tableElement;
    }
}
