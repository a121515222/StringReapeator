// See https://aka.ms/new-console-template for more information

namespace StringReapeator
{
    public class StringRepeat
    {
        public string RepeatString(string data)
        {
            var stringLen = data.Length;
            var result = "";
            for (var i = 0; i < stringLen; i++)
            {
                result += data;
            }

            return result;
        }
    }
}