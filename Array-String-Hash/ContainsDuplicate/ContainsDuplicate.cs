public class Solution {
    public bool ContainsDuplicate(int[] nums) {

        //o array vem ordenado?
        //o array coontem numeros negativos?
        

        //verificar se tem numeros repetidos no array, se sim retornar true

        //criar dicionario
        //crio um laco de repeticao for que vai iterar cada elemento do array
        //vou comparando, se o dicionario ja obter o numero atual, retornamos true
        //se nao, nos adicionamos o numero atual e continuamos
        //ser chegar ao fim, nos retornamos false

        //crio uma tabela hash
        //crio um laço foreach que itera todos os valores de num
        //se a tabela nao conseguir add o valor pois  ja possui o valor atual retornamos true
        //se nao o valor atual é adicionado
        //mo fim retormanos false
        
        HashSet<int> seenNumbers = new HashSet<int>();

        foreach (int num in nums) {
            if (!seenNumbers.Add(num)) {
                return true;
            }
        }

        return false;
    }
}
