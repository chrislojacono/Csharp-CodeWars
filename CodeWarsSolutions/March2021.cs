//In DNA strings, symbols "A" and "T" are complements of each other, as "C" and "G". You have function with one side of the DNA (string, except for Haskell); you need to get the other complementary side. DNA strand is never empty or there is no DNA at all (again, except for Haskell).

public class DnaStrand 
    {
        public static string MakeComplement(string dna)
        {
        var builder = new StringBuilder();
        foreach(char ch in dna){
          switch (ch)
            {
          case 'A':
              builder.Append("T");
              break;
          case 'T':
              builder.Append("A");
              break;
          case 'G':
              builder.Append("C");
              break;
          case 'C':
              builder.Append("G");
              break;
          default:
              Console.WriteLine("Default case");
              break;
              }
            }
          return builder.ToString();
        }
    }


/* Create a function that returns the sum of the two lowest positive numbers given an array of minimum 4 positive integers. No floats or non-positive integers will be passed.

For example, when an array is passed like [19, 5, 42, 2, 77], the output should be 7.

[10, 343445353, 3453445, 3453545353453] should return 3453455. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public static class Kata
{
	public static int sumTwoSmallestNumbers(int[] numbers)
	{
		var smallestFirst = numbers.Min();
    numbers = numbers.Where((source) => source != smallestFirst).ToArray();
    var secondNum = numbers.Min();
    return smallestFirst + secondNum;
	}
}

// BEST SOLUTION
using System.Linq;

public static class Kata
{
  public static int sumTwoSmallestNumbers(int[] numbers)
  {
    return numbers.OrderBy(i => i).Take(2).Sum();
  }
}


//Very simple, given a number, find its opposite.
using System;

public class Kata
    {
        public  static int Opposite(int number)
        {
            if(number > 0){
              return number * -1;
            }
          else{
            return Math.Abs(number);
          }
        }
    }

//Write a function called repeat_str which repeats the given string src exactly count times.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solution
{
  public static class Program
  {
    public static string repeatStr(int n, string s)
    {
      var finalString = new StringBuilder();
      for(var i = 0; i < n; i++){
        finalString.Append(s);
      }
      return finalString.ToString();
    }
  }
}


/*
Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.

It should remove all values from list a, which are present in list b.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    var newList = a.Where((item) => !b.Contains(item));
    return newList.Cast<int>().ToArray();
  }
}

/*
In this kata you are required to, given a string, replace every letter with its position in the alphabet.

If anything in the text isn't a letter, ignore it and don't return it.

"a" = 1, "b" = 2, etc. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Kata
{
  public static string AlphabetPosition(string text)
  {
    var finalString = new StringBuilder();
    foreach(var cha in text){
      switch(Char.ToLower(cha)){
          case 'a':
          finalString.Append("1 ");
          break;
          case 'b':
          finalString.Append("2 ");
          break;
          case 'c':
          finalString.Append("3 ");
          break;
          case 'd':
          finalString.Append("4 ");
          break;
          case 'e':
          finalString.Append("5 ");
          break;
          case 'f':
          finalString.Append("6 ");
          break;
          case 'g':
          finalString.Append("7 ");
          break;
          case 'h':
          finalString.Append("8 ");
          break;
          case 'i':
          finalString.Append("9 ");
          break;
          case 'j':
          finalString.Append("10 ");
          break;
          case 'k':
          finalString.Append("11 ");
          break;
          case 'l':
          finalString.Append("12 ");
          break;
          case 'm':
          finalString.Append("13 ");
          break;
          case 'n':
          finalString.Append("14 ");
          break;
          case 'o':
          finalString.Append("15 ");
          break;
          case 'p':
          finalString.Append("16 ");
          break;
          case 'q':
          finalString.Append("17 ");
          break;
          case 'r':
          finalString.Append("18 ");
          break;
          case 's':
          finalString.Append("19 ");
          break;
          case 't':
          finalString.Append("20 ");
          break;
          case 'u':
          finalString.Append("21 ");
          break;
          case 'v':
          finalString.Append("22 ");
          break;
          case 'w':
          finalString.Append("23 ");
          break;
          case 'x':
          finalString.Append("24 ");
          break;
          case 'y':
          finalString.Append("25 ");
          break;
          case 'z':
          finalString.Append("26 ");
          break;
          default:
          Console.WriteLine("invalid");
          break;
      }
    }
    return finalString.ToString().Trim();
  }


  //An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that determines whether a string that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Kata
{
  public static bool IsIsogram(string str) 
  {
    var testString = new StringBuilder();
    foreach(var cha in str){
      if(testString.ToString().Contains(Char.ToLower(cha))){
        return false;
      }
      testString.Append(Char.ToLower(cha));
    }
    return true;
  }
}

//BEST ANSWER
using System;
using System.Linq;
public class Kata
{
  public static bool IsIsogram(string str) 
  {
    return str.ToLower().Distinct().Count()==str.Length;
  }
}

/* Welcome. In this kata, you are asked to square every digit of a number and concatenate them.

For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1. */
using System;
using System.Linq;

public class Kata
{
  public static int SquareDigits(int n)
  {
    var final = Convert.ToString(n).Select((x) => Convert.ToInt32(Char.GetNumericValue(x)) * Convert.ToInt32(Char.GetNumericValue(x)));
    var finalString = string.Join("", final);
    return Convert.ToInt32(finalString);
  }
}