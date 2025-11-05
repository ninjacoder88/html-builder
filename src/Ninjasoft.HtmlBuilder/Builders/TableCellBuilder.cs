using System.Xml.Linq;

namespace Ninjasoft.HtmlBuilder.Builders
{
    public sealed class TableCellBuilder
    {
        public TableCellBuilder(string cellType = "td")
        {
            _tableCellElement = new XElement(cellType);
        }

        public TableCellBuilder SetData(string text)
        {
            _tableCellElement.Value = text;
            return this;
        }

        public TableCellBuilder SetData(int number)
        {
            _tableCellElement.Value = number.ToString();
            return this;
        }

        public TableCellBuilder SetData(decimal number)
        {
            _tableCellElement.Value = number.ToString();
            return this;
        }

        public TableCellBuilder SetData(bool value)
        {
            _tableCellElement.Value = value.ToString();
            return this;
        }

        public TableCellBuilder SetAttribute(string name, string value)
        {
            _tableCellElement.SetAttributeValue(name, value);
            return this;
        }

        public TableCellBuilder SetId(string id) => SetAttribute("id", id);

        public TableCellBuilder SetClass(string className) => SetAttribute("class", className);

        internal XElement Build() => _tableCellElement;

        private readonly XElement _tableCellElement;
    }
}
