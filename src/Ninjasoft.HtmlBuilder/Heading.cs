namespace Ninjasoft.HtmlBuilder
{
    public sealed class Heading
    {
        private Heading(string tag)
        {
            Tag = tag;
        }

        public string Tag { get; }

        public static Heading H1 = new Heading("h1");
        public static Heading H2 = new Heading("h2");
        public static Heading H3 = new Heading("h3");
        public static Heading H4 = new Heading("h4");
        public static Heading H5 = new Heading("h5");
        public static Heading H6 = new Heading("h6");
        public static Heading H7 = new Heading("h7");
    }
}
