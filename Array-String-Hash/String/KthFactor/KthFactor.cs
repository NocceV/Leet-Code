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

        // List<int> lista = new List<int>();

        // int iterador = 1;

        // while(iterador <= n){

        //     if(n % iterador == 0){
        //         lista.Add(iterador);
        //         iterador++;
        //     }
        //     else{
        //         iterador++;
        //     }

        //     if(lista.Count == k){
        //         int tamanho = lista.Count;
        //         return lista[tamanho-1];
        //     }
        // } 

        // if(lista.Count < k){
        //     return -1;
        // }
        // else{
        //     return lista[k-1];
        // }

        //Revisao

        //If k > n, return -1
        //Create a kComparer to compare the value k
        //Create a result variable to store the result value
        //Create a iterator i = 1 to start a while loop
        //Start a while loop with i <= n
            //if n % i == 0
                //We add the value of the i into the result variable
                //if the kComparer++ == k, 
                    //we just return the result
            //else we just iterator++
        //If we go at the i == n
            //return -1
        //Time = O(n)
        //Space = O(1)

        if(k>n){
            return -1;
        }

        int result;
        int kComparer = 0;
        int iterator = 1;

        while(iterator <= n){

            if(n % iterator == 0){
                result = iterator;
                kComparer++;              
                if(kComparer == k){
                    return result;
                }
            }

            iterator++;
        }

        return -1;

    }
}
