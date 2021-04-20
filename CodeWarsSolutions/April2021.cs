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
public class Solution {
    public int Reverse(int x) {
        var reversed = x.ToString().Reverse().Aggregate(0, (b, x) => 10 * b + x - '0');
        if (reversed > 2147483647){
            return 0;
        } 
        return reversed;
    }
}


//Given an integer x, return true if x is palindrome integer.

//An integer is a palindrome when it reads the same backward as forward. For example, 121 is palindrome while 123 is not.

public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0){
            return false;
        }
        var listOfDigits = x.ToString().ToCharArray().Select(c => (int) c).ToList();
        var firstIndex = 0;
        var secondIndexer = listOfDigits.Count() - 1;
        while(firstIndex < secondIndexer){
            if(listOfDigits[firstIndex] != listOfDigits[secondIndexer]){
                return false;
            }
            firstIndex++;
            secondIndexer--;
        }
        return true;
    }
}