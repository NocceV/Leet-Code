# Intuition
Criar um solução usando ponteiro

![Imagem da solução](./RemoveElement "RemoveElement Image")
# Approach
O ponteiro vai indicar o lugar que é para colocar o valor != do value e o i vai ir iterando e comparando todos os valores. Caso seja = ele so pula, caso seja diferente colocamos o valor da posição i no lugar da posição ponteiro e atualizamos o ponteiro++ e i++

# Complexity
- Time complexity: O(n)

- Space complexity:O(1)

# Code
```csharp []
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        

        //sempre tem um numero para ser removido?
        //tem que estar em ordem no final?
        //o array sempre vem com um valor?

        //eu crio um ponteiro n = 0
        //inicio um for loop
        //caso o numero na posicao i do for == k
        //eu oloco n++
        //fora da condicao if eu coloco [i] == [n]
        //retorno n


        int ponteiro = 0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i] != val){
                nums[ponteiro]=nums[i];
                ponteiro++;
            }
        }

        return ponteiro;
    }
}
```
