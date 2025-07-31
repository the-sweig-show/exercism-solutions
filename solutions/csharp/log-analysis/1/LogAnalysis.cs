public static class LogAnalysis 
{
    // DONE: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimiter)
    {
        return str.Substring(str.IndexOf(delimiter) + delimiter.Length);
    }
    // DONE: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string start, string stop)
    {
        return str.Substring(0, str.IndexOf(stop)).SubstringAfter(start);
    }
    // DONE: define the 'Message()' extension method on the `string` type
    public static string Message(this string log)
    {
        return log.SubstringAfter("]: ");
    }
    // DONE: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string log)
    {
         return log.SubstringBetween("[", "]");   
    }
}