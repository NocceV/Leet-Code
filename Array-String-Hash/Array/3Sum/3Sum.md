# Intuition
Usar ponteiros para indicar a posicao atual e dois outros para serem esquerda e direita, e ir incrementando e avaliando todas as pisições possiveis

# Approach
Ordenamos o array e começamos a avaliar a soma atual com i,esquerda e direita, apos a soma feita, se o valor = 0, entao adicionamos na lista, se for maior que 0 ou entao ja tiver sido lido um valor igual a este, nos decrementamoso  valor da variavel dirieta ate ter um valor diferente do atual. fazemoso  o mesmo com o esquerda, caso o valor seja menor que -, nos acresentamoso  valor left++ ate ter um valor diferente do atual de left, fazemos isso em ambos para evitar de adicionar as mesmas sequencias e otimizaro o algoritmo, alem disso, nos damos i++ ate o valor em num[i] for diferente de nums[i++] para evitar de adicionar sequencias iguais no resultado e otimizar o algoritmo

# Complexity
- Time complexity:
O(n^2)

- Space complexity:
O(n^2)

# Code
```csharp []
public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        //Como assim todas as posiçoes tem que ser igual a 0?
        //Entao eu devo somar todas as 3 diferentes posições nas quais a soma das tres de 0?

        //Força bruta, seria fazer 3 for loops aninhados. Porém , darai alta complexidade de tempo


        //Crio a lista de listas de inteiros
        //Faço o primeiro for loop
        //Faço o segundoi for loop
        //Faço o terceiro for loop
        //Dentro do terceiro for loop eu avalio se a soma das 3 posições da 0
        //Se der 0 eu adiciono na lista
        //Se nao der 0 eu prossigo
        //No fim eu retorno a lista de lista de inteiros

        //Força Bruta
        // Array.Sort(nums);
        // IList<IList<int>> lista = new List<IList<int>>();
        // HashSet<string> seen = new HashSet<string>();

        // if(nums[0] ==0 && nums[nums.Length-1]==0 && nums.Length >=3){
        //     IList<int> sublist = new List<int> {0,0,0};
        //     lista.Add(sublist);
        //     return lista;
        // }


        // for(int i=0;i<nums.Length-2;i++){

        //     for(int j=i+1;j<nums.Length-1;j++){

        //         for(int k=j+1;k<nums.Length;k++){

        //             if((nums[i]+nums[j]+nums[k]) == 0){

        //                 IList<int> sublist = new List<int> {nums[i],nums[j],nums[k]};
        //                 string key = string.Join(",", sublist);

        //                 if (!seen.Contains(key))
        //                 {
        //                     lista.Add(sublist);
        //                     seen.Add(key);
        //                 }
                        
        //             }
        //         }
        //     }
        // }

        // return lista;

        //Solução correta
        // Array.Sort(nums);

        // IList<IList<int>> result = new List<IList<int>>();
        // int i = 0;

        // while (i < nums.Length - 2)
        // {
        //     var j = i + 1;
        //     var k = nums.Length - 1;
        //     while (j < k)
        //     {
        //         var sum = nums[i] + nums[j] + nums[k];
        //         if (sum == 0)
                
        //             result.Add(new List<int>() {nums[i], nums[j], nums[k]});

        //         if (sum >= 0)
        //             while(j < k && nums[k] == nums[--k]) { }
        //         if (sum <= 0)
        //             while(j < k && nums[j] == nums[++j]) { }
        //     }

        //     while(i < nums.Length - 2 && nums[i] == nums[++i]) { }
        // }

        // return result;

        //Revisão

        //Create a new list of integers
        //Sort the array
        //Start a for loop, ending in array.length-2, because we want 3 numbers to have a sum
        //Create the pointers left and right
        //Create a variable sum, that will represents the sum of the actual values.
        //If the sum is == 0, we add the values in a new array, and add the new array in the list created and left++
        //If the sum is < 0 or the actual value is equal the left--, we just left++
        //If the sum is < 0 or the actual value is equal the right++, we just right--
        //return the list
        //Time = O(n^2)
        //Space = O(n^2)
        //menor e ao quadrado

        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);

        for(int i = 0;i < nums.Length-2;){
            int left = i+1;
            int right = nums.Length-1;

            while(left< right){
                int tempSum = nums[left]+nums[right]+nums[i];
                if(tempSum == 0){
                    result.Add(new List<int>(){nums[i], nums[left], nums[right]});               
                }
                if(tempSum >= 0){
                    while(left < right && nums[right] == nums[--right]) { }
                }
                if(tempSum <= 0){
                    while(left < right && nums[left] == nums[++left]) { }
                }
            }

            while(i < nums.Length - 2 && nums[i] == nums[++i]) { }
        }

        return result;
    }
}
```
