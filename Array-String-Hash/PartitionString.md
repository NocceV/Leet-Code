# Intuition
Ir usando métodos de string do c# para encontrar o menor numero sub strings possivel

# Approach
Uso o metodo de contains do c# para verificar se a substring atual contem o caracter da string analisada. Se contem nos criamos uma nova subtring a partir deste caracter e somamos +1 no numero minimo de caracteres, caso não tenha so adicionamos oc caractere atual na substring em analise. Fazemos isso também em ordem decrescente para ter certeza do resultado final.

# Complexity
- Time complexity: O(n^2) visto que temos um .Contains dentro do for loop


- Space complexity: O(n)

# Code
```csharp []
public class Solution {
    public int PartitionString(string s) {

        //a string tem espaçoes em branco?
        //a string tem caracteres especiais?
        // as sub strings podem ter varios caracteres, sebdi eles diferentes?
        //se a string puder ter espaçoes ou caracteres especiais, eles podem aparecer somente uma vez na substring também?


        //entao eu tenho que pegar uma string, a ver o numero minimo de substrings que podem ter nesta string
        //sendo que as subtrings nao podem ter caracteres iguais

        //recebo a tring e trato ela retirando os espaços em branco
        //inicializo a variavel que ira contar o numero minimo crescente
        //inicializo a string que ira iterar a string atual 
        //inicializo o for
        //se o caracter atual estiver contido na string de ieracao
        //somamos++ na variavel de numero minimo
        //igualamos a string aa nova posicao recomecando ela
        //se nao for igaul so adicionamos a string o valor atual
        //fazermos isso tudo novamente e mum outro for, porém de tras para frente para ter mais certeza

        s.Trim();

        int numMinCre = 1;
        string atual = s[0].ToString();
        for(int i =1;i<s.Length;i++){
            if(atual.Contains(s[i])){
                numMinCre++;
                atual = s[i].ToString();
            }
            else{
                atual+=s[i].ToString();
            }
        }
         
        int numMinDecre = 1;
        atual = s[s.Length-1].ToString();
        for(int i =s.Length-1;i>0;i--){
            if(atual.Contains(s[i])){
                numMinDecre++;
                atual = s[i].ToString();
            }
            else{
                atual+=s[i].ToString();
            }
        }

        return Math.Min(numMinDecre,numMinCre);
    }
}
```
