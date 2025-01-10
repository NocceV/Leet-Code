# Intuition
Usar tabela hash para guardar todos os valores e depois compara-los
para ver o faltante. 
Tempo = O(n)
Espaço = O(n)

# Approach
Usar formula matemática para no final comparar o valor esperado com o valor real, e assim achar a diferença entre os dois que no caso é a resposta.
Tempo = O(n)
Espaço = O(1)

# Complexity
- Time complexity: O(n)

- Space complexity: O(1)

# Code
```csharp []
public class Solution {
    public int MissingNumber(int[] nums) {
        
        // O array sempre vem com numeros?
        //o array vem somente com numeros maiores que 0?
        //qual o tamanho maximo do array?
        //no array so vem numeros inteiros
        //sempre tera um numero faltando?
        //o array pode ter valores repetidos?

        //Preciso pegar o maior numero e verificar de 0 a n qual numero esta faltando

        //Primeira forma 
        //Ordenar o array
        //Pegar e registrar o ultimo valor
        //Criar um laço for 
        //ir comparando o iterador com o numero atual
        //se for diferente eu retorno o iterador
        //tempo = O(n log n) ou O(n^2)
        //espaco = O(1)

        // Array.Sort(nums);
        // int maiorValor = nums[nums.Length-1];
        // for(int i = 0;i<=maiorValor;i++){
        //     if(nums[i] != i){
        //         return nums[i]-1;
        //     }
        // }

        // return maiorValor+=1;

        //Segunda forma
        //crio uma tabela hash
        //crio um laço de repeticao para ir adicionando os valores na tabela
        //crio uma variavel de maior valor
        //depois de todos os valores registrados e a variavel de maior valor
        //eu crio outro laco de repeticao de 0 ate o maior valor
        //se o numero do iterador nao conter na tabela eu retorno este numero
        //tempo = O(n)
        //espaço = O(n)

        // HashSet<int> table = new HashSet<int>();
        // int maiorValor=nums[0];

        // for(int i=0;i<nums.Length;i++){

        //     if(nums[i]> maiorValor){
        //         maiorValor= nums[i];
        //     }
        //     if(!table.Contains(nums[i])){
        //         table.Add(nums[i]);
        //     }
        // }

        // for(int j = 0;j<=maiorValor;j++){
        //     if(!table.Contains(j)){
        //         return j;
        //     }
        // }

        // return maiorValor+=1;

        //Terceira Forma

        //Pego o tamanho do array
        //faço um calculo soma todos os valores do array
        //depois calculo todos os valores dentro do array
        //e faço a diferença entre os dois valores para ver o numero que falta
        //Tempo = O(n)
        //Espaço = O(1)

        int tamanho = nums.Length;
        int somaEsperada = tamanho*(tamanho+1)/2;

        int somaDosValores = 0;

        foreach(int num in nums){
            somaDosValores+=num;
        }

        int valorFaltante = (somaEsperada - somaDosValores);

        return valorFaltante;
    }
}
```
