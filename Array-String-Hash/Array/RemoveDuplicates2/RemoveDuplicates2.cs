public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        //Create a pointer = 0
        //Create a appeareances = 0
        //Create a for loop
        //Inside the for loop we will compare the values
        //if the valies are equals and de number of appearances is down by 2, then we cont appar++
        //Elase we restart the values
        //Return the pointer

        int pointer = 1;
        int appar = 1;

        for(int i = 1;i<nums.Length;i++){

            if(nums[i-1] == nums[i]){
                if(appar < 2){
                    nums[pointer] = nums[i];
                    appar++;
                    pointer++;
                }
            }
            else{
                nums[pointer] = nums[i];
                pointer++;
                appar = 1;
            }
            
        }

        return pointer;
    }
}
