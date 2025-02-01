# Intuition
Este código converte uma string em um inteiro de 32 bits de forma segura, detectando e tratando o overflow. Ele itera pelos dígitos da string, construindo o número inteiro dígito a dígito. A verificação de overflow garante que o resultado sempre permaneça dentro dos limites de um Int32.

# Approach
Verifica cada caraceter do array de string e retorna o valor total

# Complexity
- Time complexity: O(n)

- Space complexity: O(1)

# Code
```csharp []
public class Solution {
    public int MyAtoi(string s) {
        //remove todos os espaços em branco
        s = s.Trim();

        //verifica se a string é nula ou vazia
        if(string.IsNullOrEmpty(s)){
            return 0;
        }

        //variaveis de controle
        // i= index
        // num = numero que acumula e sera retornado no final
        //sign = variável de controle denumero negativo ou inteiro
        int i =0;
        int num = 0;
        int sign = 1;

        //Se o valor for == - ou + substitui por -1 ou 1 para mais a
        // frente multiplicar  por este valor
        if(s[0] == '+' || s[0] == '-'){
            sign = (s[0] == '-') ? -1:1;
            i++;
        }

        //enquanto i for menor que o tamanho da string 
        //o caractere na posição do index atual for um 
        //digito numérico de 0 a 9
        while(i<s.Length && Char.IsDigit(s[i])){
            
            //Esta linha extrai o valor numérico do caractere.
            // Subtrair o caractere '0' do   
            //caractere do dígito converte o caractere em seu valor inteiro equivalente. 
            int digit = s[i] - '0';
            
            //lida com o overflow. Ele verifica se adicionar o próximo dígito causará um 
            //overflow no Int32.MaxValue
            if(num > (Int32.MaxValue - digit)/10){
                //Se a condição de overflow for verdadeira, a função retorna Int32.MaxValue
                //se o número for positivo (sign == 1) ou Int32.MinValue se o número for 
                //negativo. Isso garante que o resultado permaneça dentro dos limites do 
                //Int32.
                return (sign == 1) ? Int32.MaxValue : Int32.MinValue;
            }

            // Se não houver overflow, o dígito atual é adicionado ao número acumulado num. 
            //Multiplicar num por 10 desloca os dígitos existentes para a esquerda, abrindo 
            //espaço para o novo dígito.
            num = num * 10 + digit;
            i++;
        }
        return  sign * num;
   
    }
}
```
