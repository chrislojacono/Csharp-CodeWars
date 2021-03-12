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
