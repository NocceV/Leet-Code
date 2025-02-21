public class Solution {
    public int RomanToInt(string s) {
        //Revisao 
        //Create a roman transformer function
        //Create a first number
        //Create a for loop
            //Transform the numbers
            //If the number transformed is less than the previously
                //we sum
            //else we sum -=

        //Time = O(n)
        //Space = O(1)

        int after = transformer(s[s.Length-1]);  
        int actual;

        int sum = after;

        for(int i = s.Length-2;i>=0;i--){
            actual = transformer(s[i]);

            if(actual < after){
                sum -= actual;
            }
            else{
                sum+= actual;
            }

            after = actual;
        }  

        return sum;  
    }

    public int transformer(char s){
        //Function to transform the char into int in place
        if(s == 'I'){
            return 1;
        }
        else if(s== 'V'){
            return 5;
        }
        else if(s == 'X'){
            return 10;
        }
        else if(s == 'L'){
            return 50;
        }
        else if(s == 'C'){
            return 100;
        }
        else if(s == 'D'){
            return 500;
        }
        else{
            return 1000;
        }
            
        return -1;   
    }
}
