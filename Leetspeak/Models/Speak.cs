using System;
using System.Collections.Generic;

namespace Leetspeak
{
  public class Speak
  {
    public string Translate(string userInput)
    {
      char[] array = userInput.ToCharArray();
      for (int i = 0; i <= array.Length; i++)
      {
        if (array[0] == 's' || array[i] == 's' && array[i-1] == ' ')
        {
          return 's';
        }
        else
        {
          IsCharSpecialChar(array[i]);
        }
      }
      string result = string.Join("", array);
      return result;
    }

    public char IsCharSpecialChar(char arrayIndexPoint)
    {
      if (arrayIndexPoint == 's')
      {
        return 'z';
      }
      else if (arrayIndexPoint == 't')
      {
        return '7';
      }
      else if (arrayIndexPoint =='I')
      {
        return '1';
      }

      else if (arrayIndexPoint == 'o')
      {
        return '0';
      }
      else if (arrayIndexPoint == 'e')
      {
        return '3';
      }
      return arrayIndexPoint;
    }
  }
}
