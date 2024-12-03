# Intuition
Ir trocando os valores com base no ponteiro

# Approach
iniciar variavel ponteiro = s.Length -1 
iniciar for loop ate metade do array
ter uma variavel que guarda temporariamente valor na posicao i
trocar valor da posicao i pelo ponteiro
trocar valor do ponteiro pelo temporario
atualizar ponteiro--

# Complexity
- Time complexity: O(n)

- Space complexity: O(1)

# Code
```csharp []
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

        int ponteiro = s.Length-1;
        int metade =  s.Length/2;

        for(int i=0;i<metade;i++){

            char temp = s[i];
            s[i] = s[ponteiro];
            s[ponteiro] = temp;
            ponteiro--;
        }

        
    }
}
```
