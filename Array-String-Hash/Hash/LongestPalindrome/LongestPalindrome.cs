public class Solution {
    public int LongestPalindrome(string s) {
        
        //A string pode ser nula?
        //A string contem caracteres especiais e letras maiusculas?
        //A string contem espaços?

        //Entao preciso achar o maior palindromo dentro de uma string
        //e retornar o tamanho do maior palindromo

        HashSet<char> table = new HashSet<char>();
        int maxLength = 0;

        for(int i =0;i<s.Length;i++){

            if(table.Contains(s[i])){
                table.Remove(s[i]);
                maxLength+=2;
            }
            else{
                table.Add(s[i]);
            }
        }

        if(table.Count > 0){
            return maxLength+1;
        }
        
        return maxLength;
    }
}
