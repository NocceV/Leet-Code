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
