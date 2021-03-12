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