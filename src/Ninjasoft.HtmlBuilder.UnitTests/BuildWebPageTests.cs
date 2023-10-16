using Ninjasoft.HtmlBuilder.Builders;
using Ninjasoft.HtmlBuilder.Enumerations;
using NUnit.Framework;
using System.IO;

namespace Ninjasoft.HtmlBuilder.UnitTests
{
    [TestFixture]
    public class BuildWebPageTests
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
                    head.AddMeta(meta => meta.Set("name", "viewport").Set("content", "width=device-width, initial-scale=1.0"))
                        .AddMeta(meta => meta.Set("charset", "utf-8"))
                        .SetTitle("HTML Builder")
                        .AddLink(link => link.SetRel("stylesheet").SetType("text/css").SetHref("css/lib/bootstrap-5.1.3.min.css")))
                .AddBody(body => 
                    body.AddDiv(div => div.SetClass("container")
                            .AddHeading(Heading.H1, "HTML Builder")
                            .AddForm(form => form.SetId("form1")
                                .AddDiv(div => div.SetClass("mb-3")
                                    .AddLabel("Name")
                                    .AddInput(InputType.Text, input => input.SetClass("form-control"))
                                )
                                .AddDiv(div => div.SetClass("mb-3")
                                    .AddLabel("Quantity")
                                    .AddSelect(select => select.SetClass("form-control")
                                        .AddOption("Option 1")
                                        .AddOption("Option 2"))
                                    )
                                .AddDiv(div => div.SetClass("mb-3")
                                    .AddLabel("Notes")
                                    .AddTextarea(textarea => textarea.SetClass("form-control")))
                            )
                            .AddButton(button => button.SetType(ButtonType.Button).SetClass("btn btn-primary").SetText("Load"))
                            .AddHorizontalRule()
                            .AddTable(table =>
                                table.SetClass("table")
                                .AddHead(thead => thead.AddRow(tr => tr.AddDataHeading("Name").AddDataHeading("Address")))
                                .AddBody(tbody => tbody.AddRow(tr => tr.AddData("John Doe").AddData("123 Fake St")))
                            )
                            .AddHorizontalRule()
                            .AddParagraph("")
                            .AddLineBreak()
                            .AddAnchor(a => a.SetValue("Click Here").SetHref("#"))
                            .AddLineBreak()
                            .AddImage("images/transparent-ninjasoft-nuget.png")
                            .AddList(ListType.UnorderedList, ul => 
                                ul.Add("Item 1")
                                    .Add("Item 2")
                                    .Add("Item 3"))
                        )
                        .AddScript(ScriptType.JavaScript, "js/lib/jquery-3.6.0.min.js")
                        .AddScript(ScriptType.JavaScript, "js/lib/bootstrap.bundle-5.1.3.min.js")
                    )
                .Build();

            File.WriteAllText(@"D:\git\html-builder\test\html.html", html);
        }
    }
}