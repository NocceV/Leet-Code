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
