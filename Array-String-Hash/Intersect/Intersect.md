# Intuition
Tentei usar hashset para controlar os valroes que entrariam no vetor de retorno, porém, como pode repetir valor o hashset nao é uma boa opção

# Approach
A melhor opção é um dicionario que pode indicar quantos valores iguais estao guardados nele por meio de variaveis iteradoras, entao sempre quando entra mais uma variavel, nos iteramos++ e sempre quando  ela sai nos iteramos -- ate ficar 0 e assim cotnrolando cquantos valores iguais que podem se repetir tem nos dois vetores

# Complexity
- Time complexity: O(n)

- Space complexity: O(n)

# Code
```csharp []
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
```
