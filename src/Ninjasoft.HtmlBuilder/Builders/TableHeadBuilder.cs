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

        public TableHeadBuilder SetAttribute(string name, string value)
        {
            _tableHeadElement.SetAttributeValue(name, value);
            return this;
        }

        public TableHeadBuilder SetClass(string className) => SetAttribute("class", className);

        public TableHeadBuilder SetId(string className) => SetAttribute("id", className);

        internal XElement Build()
        {
            return _tableHeadElement;
        }

        private readonly XElement _tableHeadElement;
    }
}
