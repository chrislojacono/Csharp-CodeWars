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