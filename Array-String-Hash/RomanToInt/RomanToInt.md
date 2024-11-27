# Intuition
Transformar os algarismos romanos em numeros inteiros e ir somando ou subraindo da direita para a esquerda, tratando a  string como um vetor de char.

# Approach
Primeiro coloco a variavel temp2 = ao ultimo algarismo romano, apos isso igualo o resultado a isso. Depois, vou fazendo o mesmo procedimento dentro do laço for, utilizando uma função criada para transformar os algarismos romanos em numeros inteiros, usando a string como um vetor de char. Se o proximo algarismo é maior o resultado incrementa, se é menor ele subtrai.

# Complexity
- Time complexity:
O(N)

- Space complexity:
O(1)

# Code
```csharp []
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
```
