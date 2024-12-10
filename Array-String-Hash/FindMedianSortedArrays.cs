public class Solution {
   public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1.Length == 0)
        {
            return media(nums2);
        }
        if (nums2.Length == 0)
        {
            return media(nums1);
        }

        int tamanho = nums1.Length + nums2.Length;
        int[] array = new int[tamanho];
        
        int ponteiron1 = 0, ponteiron2 = 0, i = 0;

        while (ponteiron1 < nums1.Length && ponteiron2 < nums2.Length)
        {
            if (nums1[ponteiron1] <= nums2[ponteiron2])
            {
                array[i++] = nums1[ponteiron1++];
            }
            else
            {
                array[i++] = nums2[ponteiron2++];
            }
        }

        while (ponteiron1 < nums1.Length)
        {
            array[i++] = nums1[ponteiron1++];
        }

        while (ponteiron2 < nums2.Length)
        {
            array[i++] = nums2[ponteiron2++];
        }

       return media(array);
    }

    public double media(int[] array)
    {
        int tamanho = array.Length;
        int meio = tamanho / 2;
        if (tamanho % 2 == 0)
        {
            return (array[meio - 1] + array[meio]) / 2.0;
        }
        else
        {
            return array[meio];
        }
    }
}
