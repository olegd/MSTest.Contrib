namespace MSTest.Contrib
{
    public static class ExtensionMethods
    {
        public static string With(this string template, params object[] formatParameters)
        {
            return string.Format(template, formatParameters);
        }
    }
}