# Intuition
Usar ponteiros para ignorar os elementos repetidos usando um contador de vezes que o elemento apareceu

# Approach
Dentro do for loop nos comparamos o valor atual em i e o anterior, se eles sao iguais e o numero de vezes que apareceram for menor que 2, nos igualamos o vetor na posicao pointer ao valor atual em i damos um appar++ e pointer++
Caso as aparições sejam maiores que 2, nos simplesmente ignoramos
Agora caso nao entre no if do valor atual em i ser igual ao anteior, nos igualamos o valor na posicao de pointer ao valor em i e colocarmos o numero de aparicoes = 1 e damos pointer++
No fim retornamos pointer

# Complexity
- Time complexity: O(n)

- Space complexity: O(1)

# Code
```csharp []
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        //Create a pointer = 0
        //Create a appeareances = 0
        //Create a for loop
        //Inside the for loop we will compare the values
        //if the valies are equals and de number of appearances is down by 2, then we cont appar++
        //Elase we restart the values
        //Return the pointer

        int pointer = 1;
        int appar = 1;

        for(int i = 1;i<nums.Length;i++){

            if(nums[i-1] == nums[i]){
                if(appar < 2){
                    nums[pointer] = nums[i];
                    appar++;
                    pointer++;
                }
            }
            else{
                nums[pointer] = nums[i];
                pointer++;
                appar = 1;
            }
            
        }

        return pointer;
    }
}
```
