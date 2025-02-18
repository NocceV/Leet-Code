public class Solution {
    public void ReverseString(char[] s) {
        //pode ser em O(n)?
        //sempre vai ter caracteres?
        //qual é o output?
        //entao eu recebo um vetor de char e tenho que inverter os valores dele?

        //iniciar variavel ponteiro = s.Length -1 
        // iniciar for loop ate metade do array
        //ter uma variavel que guarda temporariamente valor na posicao i
        //trocar valor da posicao i pelo ponteiro
        //trocar valor do ponteiro pelo temporario
        //atualizar ponteiro--

        // int ponteiro = s.Length-1;
        // int metade =  s.Length/2;

        // for(int i=0;i<metade;i++){

        //     char temp = s[i];
        //     s[i] = s[ponteiro];
        //     s[ponteiro] = temp;
        //     ponteiro--;
        // }
        
        //Revisao
        
        //Create a pointer left = 0
        //Create a pointer right = s.Length-1
        //Start a while loop into left < right
            //Inside the loop we will switch the caracter places using the position of the pointers and a 
            //temporary variable
        //Time = O(n)
        //Space = O(1)

        int left = 0;
        int right = s.Length-1;

        char temp;
        while(left<right){
            
            temp = s[left];
            s[left] = s[right];
            s[right] = temp;

            left++;
            right--;
        }
    }
}
