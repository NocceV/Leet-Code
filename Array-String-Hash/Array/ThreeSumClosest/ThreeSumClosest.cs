public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        
        //target pode ter valor 0 e valor nums.Length?
        //se puder ter ele como eu somo o terceiro valor? seria nulo?
        //nums pode ser null?
    
        //ordeno o array
       //crio ponteiro anterior
       //crio ponteiro atualque sera o i
       //crio ponteiro posterior
       //crio um while no qual o anterior tem que ser menor que o posterior
       //faço a soma, se a soma atual for maior eu diminuo o posterior
       //se menor eu somo o anterior
       //e vou achando a menor soma enquanto isso

        //    Array.Sort(nums);

        //    int melhor = nums[0] + nums[1]+ nums[2];

        //     if(melhor ==target){
        //         return melhor;
        //     }

        //     for(int i=0;i<nums.Length-2;i++){

        //         int anterior = i+1;
        //         int posterior = nums.Length-1;

        //         while(anterior < posterior){

        //             int atual = nums[anterior] + nums[i]+ nums[posterior];
        //             if (Math.Abs(target - atual) < Math.Abs(target - melhor)){
        //                 melhor = atual;
        //             }
                        
        //             if(atual < target){
        //                 anterior++;
        //             }
        //             else if(atual > target){
        //                 posterior--;
        //             }
        //             else{
        //                 return atual;
        //             }
        //         }
        //     }
        //     return melhor;

        //Revisao

        //Sort the array
        //Create a variable called best
        //Create a for loop from 0 to array.length -2 
            //Create a variable called left = i+1
            //Right = array.length-1
            //Start a while loop ledt < right
                //Create a variable called temp, is the result of the sum
                    //If temp is more next to target, we update result
                    //else we just update the variables left or right
            //Return the result variable

        Array.Sort(nums);

        int result = nums[0]+nums[1]+nums[2];

        if(result == target){
            return result;
        }

        for(int i  = 0;i< nums.Length-2;i++){

            int left = i+1;
            int right = nums.Length - 1;

            while(left < right){

                int tempSum =  nums[i]+nums[left]+nums[right];
                if(Math.Abs(target - tempSum) < Math.Abs(target - result)){
                    result = tempSum;
                }

                if(tempSum < target){
                    left++;
                }
                else{
                    right--;
                }
            }
        }

        return result;

    }
}
