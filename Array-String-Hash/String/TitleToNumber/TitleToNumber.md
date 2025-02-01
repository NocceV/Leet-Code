# Intuition
Usar dicionario

# Approach
 Em vez de usar uma tabela hash, podemos resolver esse problema de forma mais eficiente usando a matemática de base 26. Essa abordagem é semelhante a converter um número escrito em sistema decimal para base 10, mas aqui estamos usando o alfabeto (A-Z como 1-26).

# Complexity
- Time complexity: O(n)

- Space complexity: O(1)

# Code
```csharp []
public class Solution {
    public int TitleToNumber(string columnTitle) {
        //Pode vir um valor null?
        //Pode vir com espaço?
        //Pode vir ate quandos caracteres?
        //Vem todos em Uppercase?
        //Tem caracteres especiais?

        //Devo retornar o valor int da string passada

        //Crio uma variavel para o resultado
        //crio um foreach que ira transformar os valores int value = c - 'A' + 1;
        //faço o calculo do result
        //retorno result

        long result = 0;

        foreach(char c in columnTitle){
            int value = c - 'A' + 1;
            Console.WriteLine(value);

            result = result * 26 + value;
        }

        return (int)result;
    }
}
```
