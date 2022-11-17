// See https://aka.ms/new-console-template for more information

namespace StringReapeator
{
    class StringRepeat
    {
        public string RepeatString(string data)
        {
            int stringLen = data.Length;
            string result = "";
            for (var i = 0; i < stringLen; i++)
            {
                result += data;
            }

            return result;
        }
    }
}