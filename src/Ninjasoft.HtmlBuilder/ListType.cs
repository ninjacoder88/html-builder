namespace Ninjasoft.HtmlBuilder
{
    public sealed class ListType
    {
        private ListType(string tag)
        {
            Tag = tag;
        }

        public string Tag { get; }

        public static ListType UnorderedList = new ListType("ul");
        public static ListType OrderedList = new ListType("ol");
    }
}
