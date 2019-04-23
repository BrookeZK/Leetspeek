using System;
using System.Collections.Generic;

namespace Leetspeak {

  public class Program
  {
    public static void Main()
    {
      Speak newSpeak = new Speak();
      Console.WriteLine("Enter a word or phrase, and I will translate it into Leetspeak: ");
      string userInput = Console.ReadLine();
      newSpeak.Translate(userInput);
    }
  }
}
