namespace Ninjasoft.HtmlBuilder.Enumerations
{
    public sealed class ButtonType
    {
        private ButtonType(string theType)
        {
            TheType = theType;
        }

        public string TheType { get; }

        public static ButtonType Button = new ButtonType("button");
        public static ButtonType Submit = new ButtonType("submit");
        public static ButtonType Reset = new ButtonType("reset");
    }
}
