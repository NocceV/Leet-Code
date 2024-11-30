# Intuition
Usar força bruta para ir comparando os numeros de 3 em 3, e caso a tivesse uma sequenciade numeros igual eu nao adicionaria, deu certo em todos os casos, porém por se tratar de força brita em alguns casos passou o tempo limite

# Approach
Fazer os mesmos passos como mencionado anteriormente, porém com o código mais otimizado

# Complexity
- Time complexity:
O(n^3)

- Space complexity:
O(n logn)

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
        Array.Sort(nums);

        IList<IList<int>> result = new List<IList<int>>();
        int i = 0;

        while (i < nums.Length - 2)
        {
            var j = i + 1;
            var k = nums.Length - 1;
            while (j < k)
            {
                var sum = nums[i] + nums[j] + nums[k];
                if (sum == 0)
                
                    result.Add(new List<int>() {nums[i], nums[j], nums[k]});

                if (sum >= 0)
                    while(j < k && nums[k] == nums[--k]) { }
                if (sum <= 0)
                    while(j < k && nums[j] == nums[++j]) { }
            }

            while(i < nums.Length - 2 && nums[i] == nums[++i]) { }
        }

        return result;


    }
}
```
