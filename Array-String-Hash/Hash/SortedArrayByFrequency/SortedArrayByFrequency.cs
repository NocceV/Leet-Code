public class Solution {
    public string FrequencySort(string s) {

        //Criar dicionario que contem o numero de vezes que aparece, e o caracter
        //Criar um laço for e ir adicionando cada valor no dicionario
        //Ordernar o dicionario 
        //Criar uma laço de repeticao e ir adicionando o item o numero de vezes que aparecer

        Dictionary<char,int> map = new Dictionary<char,int>();

        for(int i = 0;i<s.Length;i++){
            if(!map.ContainsKey(s[i])){
                map.Add(s[i],1);
            }
            else{
                map[s[i]]++;
            }
        }

        var sortedMap = map.OrderByDescending(x => x.Value);
        StringBuilder result = new StringBuilder();
        foreach(var item in sortedMap)
        {
            result.Append(new string(item.Key, item.Value));
        }

        return result.ToString();
    }
}
