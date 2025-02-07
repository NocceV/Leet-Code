public class Solution {
    public bool IsSubsequence(string s, string t) {
        

        // bool isSubesequence = false;
        // int pointer = 0;
        // int limit= s.Length;

        // for(int i=0;i<t.Length;i++){
        //     if(pointer < limit){
        //         if(t[i] == s[pointer]){
        //             pointer++;
        //         }
        //     }
        //     else{
        //         i=t.Length;
        //     }
        // }

        // if(pointer == limit){
        //     isSubesequence = true;
        // }

        // return isSubesequence;

        //Revisao

        //Create a pointer for the string s
        //Create a pinter for the string t
        //Create a while loop that will end when the string t ends
            //Inside the while we will compare the strings in the positions of the pointers
                //if are equal, we update the pointer of the string s
                //If are not equal, we just update the pointer of the string t
                    //If the pointer s ends, we return true
            //If the while ends we return false


        if(s==null || t ==null || s==""){
            return true;
        }
        if(t==""){

            return false;
        }
        
        int pointerS= 0;
        int pointerT = 0;

        while(pointerT < t.Length){
            if(s[pointerS] == t[pointerT]){
                pointerS++;
                if(pointerS >= s.Length){
                    return true;
                }
            }
            pointerT++;
        }
        return false;
    }
}
