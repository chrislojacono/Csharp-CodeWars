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