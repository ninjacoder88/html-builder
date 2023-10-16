using Ninjasoft.HtmlBuilder.Builders;
using Ninjasoft.HtmlBuilder.Enumerations;
using System.Xml.Linq;

namespace Ninjasoft.HtmlBuilder
{
    internal static class XElementExtensions
    {
        public static void AddAnchor(this XElement element, Action<AnchorBuilder> builder)
        {
            AnchorBuilder anchorBuilder = new AnchorBuilder();
            builder(anchorBuilder);
            element.Add(anchorBuilder.Build());
        }

        public static void AddButton(this XElement element, Action<ButtonBuilder> builder)
        {
            ButtonBuilder buttonBuilder = new ButtonBuilder();
            builder(buttonBuilder);
            element.Add(buttonBuilder.Build());
        }

        public static void AddDiv(this XElement element, Action<DivBuilder> builder)
        {
            DivBuilder divBuilder = new DivBuilder();
            builder(divBuilder);
            element.Add(divBuilder.Build());
        }

        public static void AddForm(this XElement element, Action<FormBuilder> builder)
        {
            FormBuilder formBuilder = new FormBuilder();
            builder(formBuilder);
            element.Add(formBuilder.Build());
        }

        public static void AddHeading(this XElement element, Heading heading, string text)
        {
            element.Add(new XElement(heading.Tag, text));
        }

        public static void AddHorizontalRule(this XElement element)
        {
            element.Add(new XElement("hr"));
        }

        public static void AddImage(this XElement element, string source)
        {
            var imageElement = new XElement("img");
            imageElement.SetAttributeValue("src", source);
            element.Add(imageElement);
        }

        public static void AddInput(this XElement element, InputType inputType, Action<InputBuilder> builder)
        {
            InputBuilder inputBuilder = new InputBuilder(inputType);
            builder(inputBuilder);
            element.Add(inputBuilder.Build());
        }

        public static void AddLabel(this XElement element, string text)
        {
            element.Add(new XElement("label", text));
        }

        public static void AddLineBreak(this XElement element)
        {
            element.Add(new XElement("br"));
        }

        public static void AddList(this XElement element, ListType listType, Action<ListBuilder> builder)
        {
            ListBuilder listBuilder = new ListBuilder(listType);
            builder(listBuilder);
            element.Add(listBuilder.Build());
        }

        public static void AddParagraph(this XElement element, string text)
        {
            element.Add(new XElement("p", text));
        }

        public static void AddScript(this XElement element, string scriptType, string source)
        {
            var xe = new XElement("script");
            xe.SetAttributeValue("type", scriptType);
            xe.SetAttributeValue("src", source);
            element.Add(xe);
        }

        public static void AddSelect(this XElement element, Action<SelectBuilder> builder)
        {
            SelectBuilder selectBuilder = new SelectBuilder();
            builder(selectBuilder);
            element.Add(selectBuilder.Build());
        }

        public static void AddTable(this XElement element, Action<TableBuilder> builder)
        {
            TableBuilder tableBuilder = new TableBuilder();
            builder(tableBuilder);
            element.Add(tableBuilder.Build());
        }

        public static void AddTextarea(this XElement element, Action<TextareaBuilder> builder)
        {
            TextareaBuilder textareaBuilder = new TextareaBuilder();
            builder(textareaBuilder);
            element.Add(textareaBuilder.Build());
        }

        //b, blockquote, canvas, datalist, em, footer, headings, header, iframe, nav, pre, span, style, sub, sup, svg, u
    }
}
