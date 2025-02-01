# Intuition
<!-- Describe your first thoughts on how to solve this problem. -->

# Approach
A função Backtrack é o núcleo do algoritmo. Ela é uma função recursiva que tenta formar todas as combinações possíveis de letras. O backtracking permite explorar todas as possibilidades e voltar atrás (voltar ao ponto anterior) quando uma combinação não for válida.

# Complexity
- Time complexity: O(m×n×N)

- Space complexity: O(m×n×N)

# Code
```csharp []
public class Solution {
    public IList<string> LetterCombinations(string digits) {
        
        //sao somente os numeros que poderao ser digitados?
        //sao no maximo 4 digitos entao

        //criar dicionario
        // depois pegar os digitos e mesclar todas as possibilidades
        //adicionar cada possivblilidade dentro de uma lista de string
        
        Dictionary<int,string> dict= criarDicionario();;
        

        IList<string> listaFinal = new List<string>();
        if(string.IsNullOrEmpty(digits)){
            return listaFinal;
        }

        void Backtrack(int index, string current)
        {
            // Caso base: Se o comprimento da string atual for igual ao número de dígitos
            if (index == digits.Length)
            {
                listaFinal.Add(current);
                return;
            }

            // Obter as letras correspondentes ao dígito atual
            int digit = digits[index] - '0'; // Converte o caractere para número inteiro
            string letters = dict[digit];

            // Iterar sobre cada letra e continuar a combinação
            foreach (char letter in letters)
            {
                Backtrack(index + 1, current + letter);
            }
        }
        Backtrack(0, "");

        return listaFinal;
    }

    public  Dictionary<int, string> criarDicionario(){

        return new Dictionary<int, string>
        {
            { 2, "abc" },
            { 3, "def" },
            { 4, "ghi" },
            { 5, "jkl" },
            { 6, "mno" },
            { 7, "pqrs" },
            { 8, "tuv" },
            { 9, "wxyz" }
        };
    } 
}
```
