# Intuition
Usar a brute force para resolver, ou seja, n^2

# Approach
USar reversao de array para chegar ao resultado, primeiro pegando o valor de quantos swaps vamos fazer, como por exemplo k = 3. nums.Length = 7. 
k = k% nums.length. --> k = 3
Usamos este valor para dar swap, entao primeiro damos swap em todo o vetor, apos isso damos swap ate k-1, e depois de k ate nums.length-1.

# Complexity
- Time complexity: O(n)

- Space complexity: O(1)

# Code
```csharp []
public class Solution {
    public void Rotate(int[] nums, int k) {
        //o array pode ser nullo?
        //pode ter numeros negativos como k?ai iria para  aesquerda?
        //k pode ser = 0?
        
        //criar uma variavel chamada temporario1 e temporario2
        //iniciar uma laco de repeticao < k
        //temporario 2 guarda o numero trocado
        //temporaria 1 guarda o numero nao trocado
        //array na posicao 0 pega o ultimo valor

        // int temp1=0;
        // int temp2=0;
        // int last=1;

        
        // for(int j = 0;j<nums.Length;j++){

        //         if(j == 0){
        //             temp1 = nums[0];
        //             nums[0] = nums[nums.Length-1];
        //             last=1;
        //         }
        //         else{
        //             if(last == 1){
        //                 temp2 = nums[j];
        //                 nums[j] = temp1;
        //                 last=2;
        //             }
        //             else{
        //                 temp1 = nums[j];
        //                 nums[j] = temp2;
        //                 last=1;
        //             }
                    
        //         }
                
        //     }

        // }


        //reverter o array inteiro
        //reverter o grupo de k do array
        //reverter o grupo fora de k do array

        //reversao
        //uso dois ponteiros um esquerda e outro direita e inverto tudo dentro do grupo

        //Revisao

        //Calculate the real swap value in the array
        //Get the array reversed
        //Get the array from position 0 to k-1 reversed
        //Get the array from position k to nums.Lenght - 1 reversed

        k = k % nums.Length;
        Revert(nums, 0, nums.Length - 1);
        Revert(nums, 0,k-1);
        Revert(nums, k, nums.Length - 1);
        
        
    }

    public void Revert(int[] array,int start,int end){

        int temp;
        
        while(start<end){
            temp = array[start];
            array[start] = array[end];
            array[end] = temp;
            start++;
            end--;
        }
    }

}
```
