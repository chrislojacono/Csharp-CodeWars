//APRIL C# SOLUTIONS!!

// Given an integer as input, can you round it to the next (meaning, "higher") multiple of 5?

public class Kata
{
  public static int RoundToNext5(int n)
  {
    while(n % 5 != 0){
      n++;
    }
    return n;
  }
}


//Check to see if a string has the same amount of 'x's and 'o's. The method must return a boolean and be case insensitive. The string can contain any char.
using System;
using System.Linq;

public static class Kata 
{
  public static bool XO (string input)
  {
     return input.ToLower().Count(i => i == 'x') == input.ToLower().Count(i => i == 'o');
  }
}
