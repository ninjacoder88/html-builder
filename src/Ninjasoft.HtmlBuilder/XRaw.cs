using System.Xml.Linq;
using System.Xml;

namespace Ninjasoft.HtmlBuilder
{
    public class XRaw : XText
    {
        public XRaw(string html)
            : base(html)
        {
            _html = html;
        }

        public override void WriteTo(XmlWriter writer)
        {
            writer.WriteRaw(_html);
        }

        private readonly string _html;
    }
}
