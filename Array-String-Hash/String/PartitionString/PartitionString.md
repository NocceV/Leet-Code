# Intuition
Ir usando métodos de string do c# para encontrar o menor numero sub strings possivel ou usar uma tabela hash para guardar os valores e a comparação ser O(1), e somente quando limpar a tabela ser O(n)

# Approach
Uso o metodo de contains do c# para verificar se a substring atual contem o caracter da string analisada. Se contem nos criamos uma nova subtring a partir deste caracter e somamos +1 no numero minimo de caracteres, caso não tenha so adicionamos oc caractere atual na substring em analise. Fazemos isso também em ordem decrescente para ter certeza do resultado final. USar a tabela hash pois a comparação é mais rapida, o unico porem é quando for limpar a tabela que acaba sendo  O(n)

# Complexity
- Time complexity: O(n^2) visto que temos um .Contains dentro do for loop ou um hash.Clear


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

        // s.Trim();

        // int numMinCre = 1;
        // string atual = s[0].ToString();
        // for(int i =1;i<s.Length;i++){
        //     if(atual.Contains(s[i])){
        //         numMinCre++;
        //         atual = s[i].ToString();
        //     }
        //     else{
        //         atual+=s[i].ToString();
        //     }
        // }
         
        // int numMinDecre = 1;
        // atual = s[s.Length-1].ToString();
        // for(int i =s.Length-1;i>0;i--){
        //     if(atual.Contains(s[i])){
        //         numMinDecre++;
        //         atual = s[i].ToString();
        //     }
        //     else{
        //         atual+=s[i].ToString();
        //     }
        // }

        // return Math.Min(numMinDecre,numMinCre);

        //Revisao

        //Create a string variable that will increment the values
        //Create a int variable that will cont the incresing partitions
        //Create a for loop that will interate all the string
            //If the string variable contains the s[i]
                //We cocrescente++
                //Restart the string variable
            //Else we just
                //String variavble +=
        //We do this again but decresing

        //Time = O(n^2)
        //Space = O(1)

        // string temp = s[0].ToString();
        // int incre = 0;

        // for(int i = 0;i<s.Length;i++){

        //     if(temp.Contains(s[i])){
        //         temp=s[i].ToString();
        //         incre++;
        //     }
        //     else{
        //         temp+=s[i].ToString();
        //     }
        // }

        // int decre = 0;

        // for(int i = s.Length-1;i>=0;i--){

        //     if(temp.Contains(s[i])){
        //         temp=s[i].ToString();
        //         decre++;
        //     }
        //     else{
        //         temp+=s[i].ToString();
        //     }
        // }

        // return Math.Min(incre,decre);;

        // return incre;

        //Create a hashTable to compare the values
        //Create a count variable
        //Start a for loop
            //If the table contains the character
                //We clear the table
                //And count++
            //else
                //Table.Add(value)
        //return count

        //Time = O(n^2)
        //Space = O(n)
        //Se saiu melhor
        HashSet<char> table = new HashSet<char>();

        int count = 1;

        for(int i=0;i<s.Length;i++){
            if(table.Contains(s[i])){
                table.Clear();
                count++;
            }

            table.Add(s[i]);
        }

        return count;
    }
}
```
