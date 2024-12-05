# Intuition
Usar ponteiros para percorrer a string como um vetor

# Approach
PErcorri a string comparando cada passo, no final verifiquei se o numero de strings iguais era o mesmo da string "S"

# Complexity
- Time complexity:O(n)

- Space complexity:O(1)

# Code
```csharp []
public class Solution {
    public bool IsSubsequence(string s, string t) {
        

        bool isSubesequence = false;
        int pointer = 0;
        int limit= s.Length;

        for(int i=0;i<t.Length;i++){
            if(pointer < limit){
                if(t[i] == s[pointer]){
                    pointer++;
                }
            }
            else{
                i=t.Length;
            }
        }

        if(pointer == limit){
            isSubesequence = true;
        }

        return isSubesequence;
    }
}
```
