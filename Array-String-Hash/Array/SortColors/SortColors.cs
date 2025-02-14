public class Solution {
    public void SortColors(int[] nums) {
        //Just call Array.sort()
        //Time = O(nlog n)
        //Space = O(n)

        // Array.Sort(nums);

        //Implement the QuickSort algorithim
        //Time = O(nlog n)
        //Space = O(n)

        QuickSort(nums,0,nums.Length-1);
    }

    public void QuickSort(int[] nums,int left, int right){

        if(left < right){
            int pivot = Core(nums,left,right);
            QuickSort(nums,left,pivot-1);
            QuickSort(nums,pivot+1,right);
        }
    }   

    public int Core(int[] nums,int left,int right){


        int pivot = nums[right];
        int pointer = left-1;

        int temp = 0;

        for(int i = left;i<=right;i++){

            if(nums[i] <= pivot){
                pointer++;
                temp = nums[pointer];
                nums[pointer] = nums[i];
                nums[i] = temp;
            }
        }

        return pointer;
    }
}
