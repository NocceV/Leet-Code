# Intuition
Ir comparando o inicio e o fim do array e caso fosse maior eu deceremntava e caso fosse menor eu aumentava. Porem o array nao é ordenado. 

# Approach
Criei um dicionario e caso o dicionario contesse a subtracao de target pelo numero atual em nums eu pegava o numero atual em nums e pegava tambem a chave no dicionario e retornaria os dois. Caso nao desse eu so guardava o numero dentro do dicionario.

# Complexity
- Time complexity: O(n)

- Space complexity: O(n)
# Code
```csharp []
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // [1,4,5,7,8,8,9] target = 16
        //        ^     ^
        // return the indices of the "correct" sum

        //is the array sorted?
        //can the array dont have a response?
        //can the array be null or have just one number?
        //we have only one solution
        
        //space O(n^2) and time = O(1)~

        //[1,4,5,8,8,9] target = 16
        //       ^ ^
        //sum = 16
        //keep the response = [3,4]
        // Time = O(n log n) Space = O(1)

        //Sort the array
        //leftPointer = 0
        //rightPointer = nums.Length-1
        //while(leftPointer <= rightPointer)
            //sum = leftPointer + rightPointer
            //if sum == target
                //storage result
                //return result
            //else
                //if sum < target
                    //left++
                //else
                    //right--
        //return vet[-1,-1]

        // int[] baseNums = nums;
        // Array.Sort(nums);

        // int[] resultVet = new int[2];

        // int leftPointer = 0;
        // int rightPointer = nums.Length-1;

        // while(leftPointer <= rightPointer){
        //     int sum = nums[leftPointer] + nums[rightPointer];
        //     if(sum == target){
        //         resultVet[0] = nums[leftPointer];
        //         resultVet[1] = nums[rightPointer];
        //     }
        //     else if(sum < target){
        //         leftPointer++;
        //     }
        //     else{
        //         rightPointer--;
        //     }
        // }
        // int changes = 0;
        // for(int i = 0;i<nums.Length;i++){
        //     if(baseNums[i] == resultVet[0]){
        //         resultVet[0] = i;
        //         changes++;
        //     }
        //     else if(baseNums[i] == resultVet[1]){
        //         resultVet[1] = i;
        //         changes++;
        //     }
        //     if(changes ==2){
        //         return resultVet;
        //     }
        // }

        // return resultVet;

        //TIME LIMIT EXCEEDED

        //Time = O(n)
        //Space = O(n)

        // Dictionary<int,int> numMap = new Dictionary<int,int>();
        // int [] vetorRetorno = new int[2];

        // for(int i = 0; i<nums.Length;i++){
        //     int complemento = target - nums[i];

        //     if(numMap.ContainsKey(complemento)){
                
        //         vetorRetorno[0] = numMap[complemento];
        //         vetorRetorno[1] = i;
        //         return vetorRetorno;
        //     }
            
        //     if(!numMap.ContainsKey(nums[i])){
        //         numMap[nums[i]] = i;
        //     }

        // }

        // return vetorRetorno;

        //----------------------------------

        //Conclusions
            //We have only one result/solution
            //We always will receive validate inputs

        //Questions
            //Will the target be always an positive number?
            //Is the array sorted?
            //can the array be null or have just one number?
            //can  the array have negative numbers?
            //Can the array repeat numbers?
            //Is time complexity more important than space?
                //Yes -> O(N) time and O(n) space
                //Not -> O(n^2) time and O(1) space
        //Solution
            //[2,5,8,11,20,3,0] target = 19
            
            //complement = 8
            // i = 3
            // resultValues [2,3]
            //numMap = {
            //   2,   0
            //   5,   1
            //   8,   2
            //         }
        
        // O(N) time and O(N) space
        Dictionary<int,int> numMap = new Dictionary<int,int>();
        int[] resultValues = new int[2];

        for(int i =0; i< nums.Length;i++){

            int complement = target - nums[i];

            if(numMap.ContainsKey(complement)){

                resultValues[0] = numMap[complement];
                resultValues[1] = i;
                return resultValues;
            }

            if(!numMap.ContainsKey(nums[i])){
                numMap[nums[i]] = i;
            }
        }

        return resultValues;
    }
}
```
