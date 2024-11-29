# Intuition
Tentei usar ponteiros que mostram sempre o proximo lugar que começaria a substring, e ir comparando, caso não fosse igual, iria para o proximo apontamento.Na maioria dos casos deu certo, porém em somente 1 não retornava o valor correto.

# Approach
Usar .Substring para fazer o trabalho de comparação.

# Complexity
- Time complexity: O(n x m)

- Space complexity: O(1)

# Code
```csharp []
public class Solution {
    public int StrStr(string haystack, string needle) {
        
         // Caso especial: needle é vazio
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
    }
}
```
