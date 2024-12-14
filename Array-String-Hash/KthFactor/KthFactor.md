# Intuition
Usar uma lista para retornar o valor kth

# Approach
criar lista 
criar num iterador
criar while enquanto o numero é menor que n
se n % i for == 0 add na lista
se nao i++ somente
depois se o tamanho da lista for menor que k retorna -1
se nao retorno o numero na posicao de k-1

# Complexity
- Time complexity: O(n)

- Space complexity: O(n)

# Code
```csharp []
public class Solution {
    public int KthFactor(int n, int k) {
        
        //n sempre vai ser maior ou igual a k?
        //eu posso so parar o kth numero e retornar ele o utengho que add na lista todos os numeros diviziveis


        //criar lista 
        //criar num iterador
        //criar while enquanto o numero é menor que n
        //se n % i for == 0 add na lista
        //se nao i++ somente
        //depois se o tamanho da lista for menor que k retorna -1
        //se nao retorno o numero na posicao de k-1

        List<int> lista = new List<int>();

        int iterador = 1;

        while(iterador <= n){

            if(n % iterador == 0){
                lista.Add(iterador);
                iterador++;
            }
            else{
                iterador++;
            }

            if(lista.Count == k){
                int tamanho = lista.Count;
                return lista[tamanho-1];
            }
        } 

        if(lista.Count < k){
            return -1;
        }
        else{
            return lista[k-1];
        }
    }
}
```
