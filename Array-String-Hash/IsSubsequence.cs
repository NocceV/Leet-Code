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
