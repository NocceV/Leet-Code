public class Solution {
    public bool WordPattern(string pattern, string s) {
        //So tem a e b?
        //Um pode ser null?
        //Paternn pode se
        //Se tiver maiuscula e minuscula conta?
        //Se tiver mais espaço em branco conta?

        //Entao eu verifico se as palavras sao aprentes de acordo com o dicionario

        //Crio um dicionario de char e string
        //Crio um vetor para a string s dando split nos espaços em branco
        //Crio um laco de repeticao do tamanho de pattern
        //Verifico cada caractere de pattern
        //Se ele nao existe no dicionario eu adiciono ele junto a string atual no dicionario
        //Se ele ja existe e a string atual for igual, prosseguimos
        //Se ele ja existe porem a string atual é diferente da armazenada retornamos false
        //Se chegar ao fim retornamos true
        //Tempo = O(n)
        //Espaço = O(n) 

        Dictionary<char,string> map = new Dictionary<char,string>();
        HashSet<string> usedWords = new HashSet<string>();
        string[] vet = s.Split(' '); 
        if (pattern.Length != vet.Length)
        {
            return false;
        }

        for(int i =0;i<pattern.Length;i++){
            if(!map.ContainsKey(pattern[i])){
                if (usedWords.Contains(vet[i]))
                {
                    return false;
                }
                map.Add(pattern[i],vet[i]);
                usedWords.Add(vet[i]);
            }
            else{
                if(map[pattern[i]] != vet[i] ){
                    return false;
                }
            }
        }
        return true;

    }
}
