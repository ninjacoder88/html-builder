namespace Ninjasoft.HtmlBuilder
{
    public sealed class InputType
    {
        private InputType(string type)
        {
            Type = type;
        }

        public string Type { get; }

        public static InputType Text = new InputType("text");
    }
}
