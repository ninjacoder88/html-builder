namespace Ninjasoft.HtmlBuilder.Enumerations
{
    public sealed class FormMethod
    {
        private FormMethod(string method)
        {
            Method = method;
        }

        public string Method { get; }

        public static FormMethod Get = new FormMethod("get");
        public static FormMethod Set = new FormMethod("set");
    }
}
