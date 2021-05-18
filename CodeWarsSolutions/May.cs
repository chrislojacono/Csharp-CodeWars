//Write a function to find the longest common prefix string amongst an array of strings.

//If there is no common prefix, return an empty string "".

public class Solution {
public String LongestCommonPrefix(String[] strs) {
    if (strs == null || strs.Count() == 0) return "";
    for (int i = 0; i < strs[0].Count() ; i++){
        char c = strs[0][i];
        for (int j = 1; j < strs.Count(); j ++) {
            if (i == strs[j].Count() || strs[j][i] != c)
                return strs[0].Substring(0, i);             
        }
    }
    return strs[0];
  }
}

    public static int countingValleys(int steps, string path)
    {
        var valleys = 0;
        var altitude = 0;
        var previousAlt = 0;
        var listPath = path.ToCharArray();
        var backAboveSeaLevel = true;
        for(var i = 0; i < steps; i++){
            previousAlt = altitude;
            if(listPath[i] == 'D'){
                altitude--;
            }
            else if(listPath[i] == 'U'){
                altitude++;
            }
            if(previousAlt == 0 && altitude == -1){
                valleys++;
            }
        }
        return valleys;
    }
