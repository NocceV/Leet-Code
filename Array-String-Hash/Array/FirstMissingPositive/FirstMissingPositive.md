# Intuition
Achar o menor valor usando uma variavel temporaria

# Approach
Primeiro ordenar o array, apos isso ir iterando ele usando um for loop ate achar o menor valor

# Complexity
- Time complexity: O(n)

- Space complexity: O(1)

# Code
```csharp []
public class Solution {
    public int FirstMissingPositive(int[] nums) {
        
        //o numero inteiro menor sempre é maior que zero?
        //o array vem ordenado?
        

        //vou ordenar o array
        //vou criar uma variavel menor = 1


        Array.Sort(nums);
        int temp =1;

        for(int i =0;i<nums.Length;i++){
            if(nums[i] <= 0){
                continue;
            }
            else{
                if(nums[i]>temp){
                    return temp;
                }
                else if(nums[i] == temp){
                    temp++;
                }
            }
        }

        return temp;
    }
}
```
