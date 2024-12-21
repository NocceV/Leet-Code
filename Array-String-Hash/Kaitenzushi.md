# Intuition
Uso de uma fila para ir adicionando e comparando os valores

# Approach
Usei uma fila de tamanho K para comparar os valores, ou seja se o valor estivesse na fila a pessoa não comeria o prato em questão. Porém, para otimizar ainda mais a comparação, utilizei uma tabela hash.


# Complexity
- Time complexity: O(n)
- Space complexity: O(n)

# Code
```csharp []
using System;
using System.Collections.Generic;

class Solution {
  
  public int getMaximumEatenDishCount(int N, int[] D, int K) {
    // Write your code here
    //Crio uma lista ou fila
    //inicio um laco for ate o fim de D
    //se D na posicao i do laço nao estiver contido nas k ultimas posicoes
    //a gente add na lista
    // se estiver so pulamos mesmo
    
    HashSet<int> conjunto = new HashSet<int>();
    Queue<int> fila = new Queue<int>();
    int contador = 0;
    
    for(int i =0;i<N;i++){        
      if(!conjunto.Contains(D[i])){        
        if (fila.Count == K){
          int removido = fila.Dequeue(); 
          conjunto.Remove(removido); 
        }
        fila.Enqueue(D[i]); 
        conjunto.Add(D[i]); 
        contador++;        
      }
    }
    return contador;
  }
  
}

```
