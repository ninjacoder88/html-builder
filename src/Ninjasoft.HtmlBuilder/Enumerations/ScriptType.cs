namespace Ninjasoft.HtmlBuilder.Enumerations
{
    public sealed class ScriptType
    {
        private ScriptType(string scriptType)
        {
            TheType = scriptType;
        }

        public string TheType { get; }

        public static ScriptType JavaScript = new ScriptType("text/javascript");
    }
}
