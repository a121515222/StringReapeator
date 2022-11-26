using NUnit.Framework;
using StringReapeator;
namespace String_Repeat_UniTest;

public class Tests
{
    
    [TestCase("Jack")]
    public void Test1(string data)
    {
        StringRepeat action = new StringRepeat();
        Assert.AreEqual("JackJackJackJack", StringRepeat.RepeatString(data));
    }
}