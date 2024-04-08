namespace _13_Static_Interface.Extension
{
    static class EditPhrase
    {
        public static string Capitalize(this string phrase)
        {
            return String.Concat(phrase.Substring(0,1).ToUpper(), phrase.Substring(1).ToLower());
        }

       
    }
}
