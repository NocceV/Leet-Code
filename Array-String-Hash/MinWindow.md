# Intuition
<!-- Describe your first thoughts on how to solve this problem. -->

# Approach
Approach
Initialize a character array map of size 128 to store the frequency of characters in string t.
Initialize variables count, start, end, minLen, and startIndex.
Iterate through each character in string t and update the character frequency in the map.
Use two pointers (start and end) to slide the window and find the minimum window that contains all characters from string t.
Increment end and decrease the frequency in map for each character encountered until all characters from t are present in the window.
When all characters from t are present, update minLen and startIndex based on the current window size and starting index.
Increment start and increase the frequency in map until the window no longer contains all characters from t.
After the iteration, the minimum window is found, and the result is a substring of s starting from startIndex with length minLen.

# Complexity
- Time complexity: O(n)

- Space complexity: O(1)

# Code
```csharp []
public class Solution {
    public string MinWindow(string s, string t){

       if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || s.Length < t.Length) {
            return "";
        }

        int[] map = new int[128];
        int count = t.Length;
        int start = 0, end = 0, minLen = int.MaxValue, startIndex = 0;
        /// UPVOTE !
        foreach (char c in t) {
            map[c]++;
        }

        char[] chS = s.ToCharArray();

        while (end < chS.Length) {
            if (map[chS[end++]]-- > 0) {
                count--;
            }

            while (count == 0) {
                if (end - start < minLen) {
                    startIndex = start;
                    minLen = end - start;
                }

                if (map[chS[start++]]++ == 0) {
                    count++;
                }
            }
        }

        return minLen == int.MaxValue ? "" : new string(chS, startIndex, minLen);
        
    }
}
```
