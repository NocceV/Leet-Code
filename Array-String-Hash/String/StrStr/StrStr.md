# Intuition
Tentei usar ponteiros que mostram sempre o proximo lugar que começaria a substring, e ir comparando, caso não fosse igual, iria para o proximo apontamento.Na maioria dos casos deu certo, porém em somente 1 não retornava o valor correto.

# Approach
Usar .Substring para fazer o trabalho de comparação. Foi tentado usar uma lista para reiniciar sempre no proximo começo, porem o tempo de execução ficou 1milissegundo maior, apesar da complexidade de espaço ter abaixado

# Complexity
- Time complexity: O(n x m) ou O(n)

- Space complexity: O(1)* ou O(n)

# Code
```csharp []
public class Solution {
    public int StrStr(string haystack, string needle) {
        
        //  // Caso especial: needle é vazio
        if (string.IsNullOrEmpty(needle)) return 0;

        // Iterar pelo haystack até o ponto onde needle pode caber
        for (int i = 0; i <= haystack.Length - needle.Length; i++) {
            // Verificar se a substring de tamanho needle.Length em haystack
            // corresponde ao needle
            if (haystack.Substring(i, needle.Length) == needle) {
                return i;
            }
        }

        // Se não encontrou correspondência
        return -1;


        //Revisao

        //Fix the strings or check if the strings are null or empty
        //Create a pointerNeedle = 0
        //Start a for loop i = 0
            //If the pointerNeedle == haystack[i]
                //pointerNeedle++
            //else just continue
            //if the pointerNeedle == needle.Length
                //return 0 
        //if the loop ends just return -1

        if(string.IsNullOrEmpty(needle)){
            return 0;
        }

        List<int> starts = new List<int>();

        for(int i = 0;i<haystack.Length;i++){
            if(haystack[i] == needle[0]){
                starts.Add(i);
            }
        }

        int startsPointer= 0;
        int needlePointer = 0;
        int indexNeedle = -1;

        for(int i = 0;i<haystack.Length;i++){

            if(haystack[i] == needle[needlePointer]){
                if(needlePointer == 0){
                    indexNeedle = i;
                }
                needlePointer++;
                if(needlePointer==needle.Length){
                    return indexNeedle;
                }
            }
            else{
                if(startsPointer >= starts.Count()){
                    return -1;
                }
                i=starts[startsPointer++]-1;
                needlePointer = 0;
                indexNeedle = -1;
            }

        }

        return -1;
    }
```
