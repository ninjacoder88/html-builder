using System.Xml.Linq;

namespace Ninjasoft.HtmlBuilder.Builders
{
    public interface ITableHeadRowBuilder
    {
        ITableHeadRowBuilder AddDataHeading(string text);
    }

    public interface ITableBodyRowBuilder
    {
        ITableBodyRowBuilder AddData(string text);
    }

    public sealed class TableRowBuilder : ITableHeadRowBuilder, ITableBodyRowBuilder
    {
        public TableRowBuilder()
        {
            _tableRowElement = new XElement("tr");
        }

        public ITableHeadRowBuilder AddDataHeading(string text)
        {
            _tableRowElement.Add(new XElement("th", text));
            return this;
        }

        public ITableBodyRowBuilder AddData(string text)
        {
            _tableRowElement.Add(new XElement("td", text));
            return this;
        }

        internal XElement Build()
        {
            return _tableRowElement;
        }

        private readonly XElement _tableRowElement;
    }
}
