using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeak;

namespace Leetspeak.Test
{
  [TestClass]
  public class SpeakTest
  {
    [TestMethod]
    public void IsCharSpecialChar_ReturnsChar_Char()
    {
      Speak testSpeak = new Speak();
      Assert.AreEqual('h', testSpeak.IsCharSpecialChar('h'));
    }

    [TestMethod]
    public void IsCharSpecialChar_Return3WhenCharEInput_Char()
    {
      Speak testSpeak = new Speak();
      Assert.AreEqual('3', testSpeak.IsCharSpecialChar('e'));
    }

    [TestMethod]
    public void IsCharSpecialChar_Return1WhenCharIInput_Char()
    {
      Speak testSpeak = new Speak();
      Assert.AreEqual('1', testSpeak.IsCharSpecialChar('I'));
    }

    [TestMethod]
    public void IsCharSpecialChar_Return7WhenCharTInput_Char()
    {
      Speak testSpeak = new Speak();
      Assert.AreEqual('7', testSpeak.IsCharSpecialChar('t'));
    }

    [TestMethod]
    public void IsCharSpecialChar_ReturnZWhenCharSInput_Char()
    {
      Speak testSpeak = new Speak();
      Assert.AreEqual('z', testSpeak.IsCharSpecialChar('s'));
    }

    [TestMethod]
    public void Translate_ReturnSIfSIsFirstLetterOfWordInput_Char()
    {
      Speak testSpeak = new Speak();
      Assert.AreEqual('s', testSpeak.Translate("s"));
    }
  }
}
