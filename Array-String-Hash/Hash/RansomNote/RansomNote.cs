public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        //MAs as letras em magazine precisam estar na mesma sequencia que ransomNote?

        //Verificar se é possivel contruir ransomNote usando as letras dentro de magazine

        //Criar um dicionario
        //Colocar todos os valores de magazine dentro do dicionario
        //Caso ele ja tenha um valor nele, nos incrementamos
        //Caso ele nao tenha add o valor com valor 1
        //Abrimos um laço for do tamanho de ransomNote
        //Verificamos dentro do dicionario se é possivel criar 
        //A cada possibilidade aceita decrementamos o valor de diconario ate 0
        //Se não, retornamos false
        //Se chegar ao fim, retornamos true


        Dictionary<char,int> map = new Dictionary<char,int>();

        for(int i = 0;i<magazine.Length;i++){
            if(map.ContainsKey(magazine[i])){
                map[magazine[i]]++;
            }
            else{
                map.Add(magazine[i],1);
            }
        }

        for(int j = 0 ; j< ransomNote.Length;j++){
            if(map.ContainsKey(ransomNote[j]) && map[ransomNote[j]] > 0){
                map[ransomNote[j]]--;
            }
            else{
                return false;
            }
        }

        return true;
    }
}
