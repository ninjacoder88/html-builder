using System.Xml.Linq;

namespace Ninjasoft.HtmlBuilder.Builders
{
    public interface ITableHeadRowBuilder
    {
        ITableHeadRowBuilder AddDataHeading(string text);

        ITableHeadRowBuilder AddDataHeading(int number);

        ITableHeadRowBuilder AddDataHeading(decimal number);
    }

    public interface ITableBodyRowBuilder
    {
        ITableBodyRowBuilder AddData(string text);

        ITableBodyRowBuilder AddData(int number);

        ITableBodyRowBuilder AddData(decimal number);
    }

    public sealed class TableRowBuilder : ITableHeadRowBuilder, ITableBodyRowBuilder
    {
        public TableRowBuilder()
        {
            _tableRowElement = new XElement("tr");
        }

        public ITableBodyRowBuilder AddData(string text)
        {
            _tableRowElement.Add(new XElement("td", text));
            return this;
        }

        public ITableBodyRowBuilder AddData(int number) => AddData(number.ToString());

        public ITableBodyRowBuilder AddData(decimal number) => AddData(number.ToString());

        public ITableHeadRowBuilder AddDataHeading(string text)
        {
            _tableRowElement.Add(new XElement("th", text));
            return this;
        }

        public ITableHeadRowBuilder AddDataHeading(int number) => AddDataHeading(number.ToString());

        public ITableHeadRowBuilder AddDataHeading(decimal number) => AddDataHeading(number.ToString());

        internal XElement Build()
        {
            return _tableRowElement;
        }

        private readonly XElement _tableRowElement;
    }
}
