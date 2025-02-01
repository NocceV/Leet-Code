# Intuition
<!-- Describe your first thoughts on how to solve this problem. -->
Fiz uma estrutura de repetição que define quando os valores do array já existentes irão ser trocados através de ponteiros.

Use pointers to compare and remove the duplicates

# Approach
<!-- Describe your approach to solving the problem. -->
Na questão RemoveDuplicates eu usei a estrutura de repetição "for" e o padrão de ponteiros para reduzir a complexidade de espaço para O(1). com isso aprendi que não prcecisaria necessariamente criar um novo array para resolver a questão.

Use two pointers to compare the values,the first one is a iterator, and the seconde is where the "real" array goes. When the value repeat we just ignore this value and overwrite this value in the future, case comes a diferente value.

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
        

        //can the array be null or with 1 value?
        //does the array contain only positive numbers?

        //Create a pointer = 0
        //Create a for loop 
        //Inside the for loop i will compare the pointer qith the iterator
        //if the pointer is equal the iterator i just continue
        //else i will add 1 in the pointer and give the same value that the iterator
        //return the pointer

        //Time O(n)
        //Space O(1)

        // [1,2,3,5,9,10,3,5,9,10,10]
            
        //pointer = 5
        // i = 9

        int pointer = 0;
        for(int i = 0; i< nums.Length;i++){

            if(nums[pointer] != nums[i]){
                pointer++;
                nums[pointer] = nums[i];
            }
        }

        return pointer+1;
    }
}
```
