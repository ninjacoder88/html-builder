using Ninjasoft.HtmlBuilder.Builders;
using NUnit.Framework;

namespace Ninjasoft.HtmlBuilder.UnitTests
{
    internal class TableBuilderTests
    {
        [Test]
        public void Test()
        {
            TableBuilder tableBuilder = new TableBuilder();
            tableBuilder.AddHead(h => h.AddRow(r => r.AddDataHeading("Id")))
                .AddBody(b => b.AddRow(r => r.AddData(d => d.SetData(100).SetAttribute("border", "1px solid #555"))));
            string tableHtml = tableBuilder.Build().ToString(System.Xml.Linq.SaveOptions.DisableFormatting);
        }
    }
}
