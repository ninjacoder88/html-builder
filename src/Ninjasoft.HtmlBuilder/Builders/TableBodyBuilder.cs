using System.Xml.Linq;

namespace Ninjasoft.HtmlBuilder.Builders
{
    public sealed class TableBodyBuilder
    {
        public TableBodyBuilder()
        {
            _tableBodyElement = new XElement("tbody");
        }

        public TableBodyBuilder AddRow(Action<ITableBodyRowBuilder> action)
        {
            TableRowBuilder tableRowBuilder = new TableRowBuilder();
            action(tableRowBuilder);
            _tableBodyElement.Add(tableRowBuilder.Build());
            return this;
        }

        internal XElement Build()
        {
            return _tableBodyElement;
        }

        private readonly XElement _tableBodyElement;
    }
}
