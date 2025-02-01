public class Solution {
    public void SortColors(int[] nums) {
        
        QuickSort(0,nums.Length-1,nums);
    }

    static void QuickSort(int start, int end, int[] nums){
        
        if (start < end){
            int pivot = Partition(start,end,nums);
            QuickSort(start,pivot-1,nums);  
            QuickSort(pivot+1,end,nums); 
        }
    }

    static int Partition(int start,int end,int[] nums)
    {
        int pivot = nums[end]; 
        int i = start - 1; 

        for (int j = start; j < end; j++)
        {
            if (nums[j] <= pivot)
            {
                i++;
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
        }

        int temp1 = nums[i + 1];
        nums[i + 1] = nums[end];
        nums[end] = temp1;

        return i + 1;
    }
}
