// See https://aka.ms/new-console-template for more information

namespace StringReapeator
{
    public class StringRepeat
    {
        public static string RepeatString(string data)
        {
            return data.Aggregate("", (current, t) => current + data);
        }
    }
}