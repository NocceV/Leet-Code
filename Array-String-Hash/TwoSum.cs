public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //nos sempre teremos uma solucao?
        //o array sempre estara ordenado?
        

        //Declarar um ponteiro = nums.Length - 1
        //Declarar um iterador = 0
        // iniciar um while loop enquanto iterador < ponteiro
        //faço a soma do momento 
        //caso a soma de maior eu subtrario ponteiro
        //caso a soma de menor eu adiciono iterador
        //se a soma der = target eu crio um array e guardos as posições dentro dele
        //retorno este array

        // int[] temp = nums;
        // Array.Sort(temp);

        // int ponteiro = nums.Length -1 ;
        // int iterador = 0;
        // int[] vetorRetorno = new int[2];
    
        // while(iterador < ponteiro){
        //     int soma = temp[ponteiro] + temp[iterador];
        //     if(soma > target){
        //         ponteiro--;
        //     }
        //     else if(soma<target){
        //         iterador++;
        //     }
        //     else{
        //         vetorRetorno[0] = temp[iterador];
        //         vetorRetorno[1] = temp[ponteiro];
        //         iterador = ponteiro;
        //     }
        // } 

        // for(int i=0;i<nums.Length;i++){

        //     if(nums[i]==vetorRetorno[0]){
        //         vetorRetorno[0] = i;
        //     }
        //     else if(nums[i] == vetorRetorno[1]){
        //         vetorRetorno[1] = i;
        //     }
        // }
        // return vetorRetorno;

        Dictionary<int,int> numMap = new Dictionary<int,int>();
        int [] vetorRetorno = new int[2];
        for(int i = 0; i<nums.Length;i++){
            int complemento = target - nums[i];

            if(numMap.ContainsKey(complemento)){
                
                vetorRetorno[0] = numMap[complemento];
                vetorRetorno[1] = i;
                return vetorRetorno;
            }
            
            if(!numMap.ContainsKey(nums[i])){
                numMap[nums[i]] = i;
            }

        }

        return vetorRetorno;
    }
}
