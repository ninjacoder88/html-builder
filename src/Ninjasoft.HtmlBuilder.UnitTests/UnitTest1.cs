using Ninjasoft.HtmlBuilder.Builders;
using NUnit.Framework;
using System.IO;

namespace Ninjasoft.HtmlBuilder.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var html = new HtmlDocument()
                .AddHead(head => 
                    head.AddMeta(meta => meta.Set("name", "viewport").Set("content", "width=device-width")))
                .AddBody(body => 
                    body.AddTable(table => 
                        table.AddHead(thead => 
                            thead.AddRow(tr => tr.AddDataHeading("Name").AddDataHeading("Address")))
                        .AddBody(tbody => 
                            tbody.AddRow(tr => tr.AddData("John Doe").AddData("123 Fake St"))))
                    .AddParagraph("This is a paragraph")
                    .AddLineBreak()
                    .AddHorizontalRule()
                    .AddHeading(Heading.H3, "Hello")
                    .AddDiv()
                    .AddList(ListType.UnorderedList, ul => ul.Add("Step 1").Add("Step 2")))
                .Build();

            File.WriteAllText(@"c:\temp\html.html", html);
        }
    }
}