# Intuition
Usar ponteiros para ignorar os elementos repetidos

# Approach
<A principio tentei com um cetor auxiliar, logo depois percebe-se que nao precisa do vetor auxiliar.Eu vou usando comprações entre o numero anterior e o atual, atravéz de ponteiros.

# Complexity
- Time complexity: O(n)

- Space complexity: O(1)

# Code
```csharp []
public class Solution {
    public int RemoveDuplicates(int[] nums) {
    if (nums.Length <= 2) {
        return nums.Length; // Se a matriz tem 2 ou menos elementos, não há duplicatas a remover.
    }

    int count = 1; // Conta as ocorrências do elemento atual.
    int pointer = 1; // Aponta para o próximo local disponível na matriz resultante.

    for (int i = 1; i < nums.Length; i++) {
        if (nums[i] == nums[i - 1]) {
            // Se o elemento atual é igual ao anterior e o count < 2, permite mais uma ocorrência.
            if (count < 2) {
                nums[pointer] = nums[i];
                pointer++;
                count++;
            }
        } else {
            // Se encontrar um novo número, reinicia o count e move o ponteiro.
            nums[pointer] = nums[i];
            pointer++;
            count = 1; // Reseta a contagem para o novo número.
        }
    }

    return pointer; // Retorna o tamanho da nova matriz sem duplicatas excessivas.
}
}
```
