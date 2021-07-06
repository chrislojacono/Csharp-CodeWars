public class Solution {
    public bool IsPalindrome(string input) {
            var newString = input.Replace('`', '.');
            var joinedInput = string.Concat(newString.Where(c => !char.IsWhiteSpace(c)));

            char[] inputCharArray = joinedInput.ToCharArray();
            char[] comparisonCharArray = joinedInput.ToCharArray();

            Array.Reverse(comparisonCharArray);

            var nonresversedStringWithPunctuationRemoved = new string(inputCharArray.Where(c => !char.IsPunctuation(c)).ToArray());
            var reversedStringWithPunctuationRemoved = new string(comparisonCharArray.Where(c => !char.IsPunctuation(c)).ToArray());
            
            if (nonresversedStringWithPunctuationRemoved.Equals(reversedStringWithPunctuationRemoved, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            return false;
    }
}