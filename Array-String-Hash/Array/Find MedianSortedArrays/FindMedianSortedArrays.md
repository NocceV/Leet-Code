# Intuition
Ir comparando os dois arrays com base em ponteiros ir alocar os valores ate a metade do valor total do tamanho em um array, para então retornar o ultimo valor caso seja impar, ou a media dos dois ultimos caso seja par

# Approach
Usar dois ponteiros para resolver a questão, sem precisar de criar um novo array, apenas alocando os dois ultimos valores em variaveis ate o final das comparações, que param ate ovalor da metadade da soma dos dois arrays juntos, apos isso retornarmos o ultimo valor caso seja imparou entao retornamos a media dos dois ultimos valores registrados caso seja par

# Complexity
- Time complexity: O(n)

- Space complexity: O(1)

# Code
```csharp []
public class Solution {
   public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        //     if (nums1.Length == 0)
        //     {
        //         return media(nums2);
        //     }
        //     if (nums2.Length == 0)
        //     {
        //         return media(nums1);
        //     }

        //     int tamanho = nums1.Length + nums2.Length;
        //     int[] array = new int[tamanho];
            
        //     int ponteiron1 = 0, ponteiron2 = 0, i = 0;

        //     while (ponteiron1 < nums1.Length && ponteiron2 < nums2.Length)
        //     {
        //         if (nums1[ponteiron1] <= nums2[ponteiron2])
        //         {
        //             array[i++] = nums1[ponteiron1++];
        //         }
        //         else
        //         {
        //             array[i++] = nums2[ponteiron2++];
        //         }
        //     }

        //     while (ponteiron1 < nums1.Length)
        //     {
        //         array[i++] = nums1[ponteiron1++];
        //     }

        //     while (ponteiron2 < nums2.Length)
        //     {
        //         array[i++] = nums2[ponteiron2++];
        //     }

        //    return media(array);

        //Revisao

        //Create a array (N+M+1), that will save the numbers
        //Create the pointers a and b
        //create the sizes, n,m and global
        //Create a media function
        //Add values in a while loop, that will end in (n+m+1)/2
        //Calls the media function
        //Time = o(n)
        //Space = O(n)

        //Create n and m values, that represents the lenght of the arrays
        //Create variables that represents the n+m lengths and the halve value
        //Create variables that will be pointers for each array
        //Create a itarator variable count
        //Create the last 2 values, prev and current, prev represents the last value that will serve if the total length if is even
        //Inicialize the while loop, that goes only at the half
            //IF ponteir1 is less than n and the value inside the array is lass tha value in the array2, we put current = nums1[ponteir1]
            //Else current = nums2[pointer2]
        //Return the media
        //Time =  O(n)
        //Space = O(1)

        int n = nums1.Length;
        int m = nums2.Length;
        int totalLength = n + m;
        int half = (totalLength) / 2; 

        int ponteiro1 = 0; 
        int ponteiro2 = 0;
        int count = -1;
        int current = 0;
        int prev = 0;

        while (count < half) { 
            prev = current; 
            if (ponteiro1 < n && (ponteiro2 >= m || nums1[ponteiro1] <= nums2[ponteiro2])) {
                current = nums1[ponteiro1++];
            } else {
                current = nums2[ponteiro2++];
            }
            count++;
        }

        if (totalLength % 2 == 0) {
            return (current + prev) / 2.0;
        } 
        return current;
    }

    // public double media(int[] array){

    //     // int meio = array.Length/2;
    //     // if(array.Length%2==0){
    //     //     return (double)(array[meio]+array[meio-1])/2;
    //     // }
        
    //     // return array[meio];

    //     if(array.Length%2==0){
    //         return (double)(array[array.Length-2]+array[array.Length-1])/2;
    //     }

    //     return array.Length-1;
    // }

}
```
