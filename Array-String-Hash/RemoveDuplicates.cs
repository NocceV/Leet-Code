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

//


