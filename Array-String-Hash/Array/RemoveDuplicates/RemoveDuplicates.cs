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


