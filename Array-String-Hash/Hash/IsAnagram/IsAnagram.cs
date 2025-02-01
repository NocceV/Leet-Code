public class Solution {
    public bool IsAnagram(string s, string t) {
        
        //anagrama é uma string que tem os mesmos caracteres, porem, em posicoes diferentes
        //uma string pode ser null?
        //Pode repetir letras?

        //Entao tenho que verificar se duas strings sao anagramas

        //Primeiro crio um dicionario
        //Passo todos os valores da string s para a tabela hash
        //Se ja contem a char atual eu dou num++
        //Crio um laco for do tamanho de t
        //Vou verificando se existe o caractere atual no dicionario se existe, eu subrario num
        //se nao existe eu retorno false
        //se chega ao fim retorno true
        if(s.Length != t.Length){
            return false;
        }
        Dictionary<char,int> dic = new Dictionary<char,int>();

        foreach(char chac in s){
             if (dic.ContainsKey(chac)){
                dic[chac]++;
            }
            else{
                dic[chac] = 1;
            }
        }

        foreach(char chac in t){
            if(dic.ContainsKey(chac) && dic[chac] > 0){
                dic[chac]--;
            }
            else{
                return false;
            }
        }

        return true;
    }
}
