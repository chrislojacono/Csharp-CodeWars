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

/*
An avid hiker keeps meticulous records of their hikes. During the last hike that took exactly  steps, for every step it was noted if it was an uphill, , or a downhill,  step. Hikes always start and end at sea level, and each step up or down represents a  unit change in altitude. We define the following terms:

A mountain is a sequence of consecutive steps above sea level, starting with a step up from sea level and ending with a step down to sea level.
A valley is a sequence of consecutive steps below sea level, starting with a step down from sea level and ending with a step up to sea level.
Given the sequence of up and down steps during a hike, find and print the number of valleys walked through.

Example

 

The hiker first enters a valley  units deep. Then they climb out and up onto a mountain  units high. Finally, the hiker returns to sea level and ends the hike.

Function Description

Complete the countingValleys function in the editor below.

countingValleys has the following parameter(s):

int steps: the number of steps on the hike
string path: a string describing the path
Returns

int: the number of valleys traversed
Input Format

The first line contains an integer , the number of steps in the hike.
The second line contains a single string , of  characters that describe the path.

Constraints
*/
public class Solution{
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
}

