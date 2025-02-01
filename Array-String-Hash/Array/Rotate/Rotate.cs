public class Solution {
    public void Rotate(int[] nums, int k) {
        //o array pode ser nullo?
        //pode ter numeros negativos como k?ai iria para  aesquerda?
        //k pode ser = 0?
        
        //criar uma variavel chamada temporario1 e temporario2
        //iniciar uma laco de repeticao < k
        //temporario 2 guarda o numero trocado
        //temporaria 1 guarda o numero nao trocado
        //array na posicao 0 pega o ultimo valor

        // int temp1=0;
        // int temp2=0;
        // int last=1;

        
        // for(int j = 0;j<nums.Length;j++){

        //         if(j == 0){
        //             temp1 = nums[0];
        //             nums[0] = nums[nums.Length-1];
        //             last=1;
        //         }
        //         else{
        //             if(last == 1){
        //                 temp2 = nums[j];
        //                 nums[j] = temp1;
        //                 last=2;
        //             }
        //             else{
        //                 temp1 = nums[j];
        //                 nums[j] = temp2;
        //                 last=1;
        //             }
                    
        //         }
                
        //     }

        // }


        //reverter o array inteiro
        //reverter o grupo de k do array
        //reverter o grupo fora de k do array

        //reversao
        //uso dois ponteiros um esquerda e outro direita e inverto tudo dentro do grupo



        k = k % nums.Length;
        Revert(nums, 0, nums.Length - 1);
        Revert(nums, 0,k-1);
        Revert(nums, k, nums.Length - 1);
        
        
    }

    public void Revert(int[] array,int start,int end){

        int left = start;
        int right = end;
        int temp;

        while(left<right){
            temp = array[left];
            array[left] = array[right];
            array[right] = temp;
            left++;
            right--;
        }
    }

}
