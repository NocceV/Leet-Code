public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        
        //O array vem ordenado?
        //o array contem somente numeros inteiros positivos?
        //algum array pode vir null?
        //algum array sempre vem menor que o outro?

        //Entao eu  tenho que comparar os valores dos dois arrays
        //E retornar os valores que eles possuem em comum
        //Podendo ser valores repetidos

        //Primeiro crio uma tabela hash
        //Insiro todos os valores do nums1 na tabela
        //Crio um vetor de tamanho do menor dos vetores
        //faço um laço for para percorrer todo o vetor nums2
        //Se a tabela contem o valor de nums[i] eu add no vetor novo
        //e removo o valor da tabela
        //Se nao eu so continuo
        //retorno o vetor criado no fim

        Dictionary<int, int> countMap = new Dictionary<int, int>();
        List<int> result = new List<int>();

        foreach(int num in nums1){

            if (countMap.ContainsKey(num)){
                countMap[num]++;
            }
            else{
                countMap[num] = 1;
            }
        }

        foreach (int num in nums2) {
            if (countMap.ContainsKey(num) && countMap[num] > 0) {
                result.Add(num); 
                countMap[num]--; 
            }
        }
        return result.ToArray();

    }
}
