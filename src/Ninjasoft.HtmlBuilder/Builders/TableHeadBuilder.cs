using System.Xml.Linq;

namespace Ninjasoft.HtmlBuilder.Builders
{
    public sealed class TableHeadBuilder
    {
        public TableHeadBuilder()
        {
            _tableHeadElement = new XElement("thead");
        }

        public TableHeadBuilder AddRow(Action<ITableHeadRowBuilder> action)
        {
            TableRowBuilder tableRowBuilder = new TableRowBuilder();
            action(tableRowBuilder);
            _tableHeadElement.Add(tableRowBuilder.Build());
            return this;
        }

        internal XElement Build()
        {
            return _tableHeadElement;
        }

        private readonly XElement _tableHeadElement;
    }
}
