# Intuition
<!-- Describe your first thoughts on how to solve this problem. -->
Fiz uma estrutura de repetição que define quando os valores do array já existentes irão ser trocados através de ponteiros.

# Approach
<!-- Describe your approach to solving the problem. -->
Na questão RemoveDuplicates eu usei a estrutura de repetição "for" e o padrão de ponteiros para reduzir a complexidade de espaço para O(1). com isso aprendi que não prcecisaria necessariamente criar um novo array para resolver a questão.

# Complexity
- Time complexity:
<!-- Add your time complexity here, e.g. $$O(n)$$ -->
O(n)

- Space complexity:
<!-- Add your space complexity here, e.g. $$O(n)$$ -->
O(1)

# Code
```csharp []
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        

        int counter = 0;

        for(int i = 1;i<nums.Length;i++){

            if(nums[i] != nums[counter]){
                counter++;
                nums[counter] = nums[i];
            }
        }

        return counter+1;
    }
}
```
