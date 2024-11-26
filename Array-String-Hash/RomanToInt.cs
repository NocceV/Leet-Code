public class Solution {
    public int RomanToInt(string s) {
        
        
        int temporary2 = calculo(s,s.Length-1);
        int result = temporary2;

        for(int i=s.Length-2;i>=0;i--){
           int temporary = calculo(s,i);

           if(temporary >= temporary2){
                result+= temporary;
                temporary2=temporary;
           }
           else{
                result-= temporary;
                temporary2=temporary;
           }
        }
        return result;

    }

    public static int calculo(string s,int i){
        int temporary;
        if(s[i] == 'I'){
            temporary = 1;
        }
        else if(s[i]== 'V'){
            temporary = 5;
        }
        else if(s[i] == 'X'){
            temporary = 10;
        }
        else if(s[i] == 'L'){
            temporary = 50;
        }
        else if(s[i] == 'C'){
            temporary = 100;
        }
        else if(s[i] == 'D'){
            temporary = 500;
        }
        else{
            temporary = 1000;
        }
            
        return temporary;    

        
    }
}
