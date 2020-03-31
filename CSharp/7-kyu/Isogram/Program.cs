using System;

public class Kata
{
  public static bool IsIsogram(string str) 
  {
    string newStr = str.ToLower();
            if (newStr == null) return false;
            for (int i = 0; i < (newStr.Length - 1); i++)
            {
                string tempChar = newStr[i].ToString();
                for (int j = i + 1; j < (newStr.Length); j++)
                {
                    if (tempChar == newStr[j].ToString()) return false;
                }
            }
            return true;
  }
}