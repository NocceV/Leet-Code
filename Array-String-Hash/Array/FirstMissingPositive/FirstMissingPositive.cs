public class Solution {
    public int FirstMissingPositive(int[] nums) {
        
        //o numero inteiro menor sempre é maior que zero?
        //o array vem ordenado?
        

        //vou ordenar o array
        //vou criar uma variavel menor = 1


        // Array.Sort(nums);
        // int temp =1;

        // for(int i =0;i<nums.Length;i++){
        //     if(nums[i] <= 0){
        //         continue;
        //     }
        //     else{
        //         if(nums[i]>temp){
        //             return temp;
        //         }
        //         else if(nums[i] == temp){
        //             temp++;
        //         }
        //     }
        // }

        // return temp;

        //Revisao

        //Sort the array
        //Create a base number= 1, that will compare the positions
        //Create a pointer
        //Crate a for loop, that will compare at the number in array[pointer] > 0
            //If pointer > 0 just stop
        //Create a loop starting in the position pointer, and will comparae with the variable number
            //IF number = array[i]
                //number++
            //If number < array[i]
                //return number
        //Time = O(n log n)
        //Space = O(1)

        if(nums ==null){
            return 1;
        }

        Array.Sort(nums);
        int result = 1;

        for(int i = 0;i<nums.Length;i++){

            if(nums[i] <=0){
                continue;
            }
            else{
                if(result < nums[i]){
                    return result;
                }
                else if(nums[i] == result){
                    result++;
                }
            }
        }

        return result;
    }
}
