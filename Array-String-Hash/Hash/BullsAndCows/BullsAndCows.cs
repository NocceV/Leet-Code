public class Solution {
    public string GetHint(string secret, string guess) {
        
        //Sempre vem com o mesmo numero de caracteres?
        //Pode vir espaço branco ou nulo?
        //Podem vir nenhum numero igual?

        //QUe pegar o guess e ver quais numeros sao iguais e estao na posicao correta
        ///quando atender os dois, é touro, quando atender so o numero igual é vaca

        //Criar um dicionario de int int
        //Guardar cada valor de secret no dicionario, com chave posicao i de um for loop
        //Criar uma tabela hash para guardar cada caractere
        //Criar um for loop que vai iterar contando quantos bulls tem e quantas vacas tem
        //Depois cirar um string com o resultado

        int bulls = 0;
        HashSet<int> positions = new HashSet<int>();
        Dictionary<char,int> missing = new Dictionary<char,int>();

        for(int i =0;i<secret.Length;i++){

            if(secret[i]==guess[i]){
                bulls++;
                positions.Add(i);
            }
            else{
                if(missing.ContainsKey(secret[i])){
                    missing[secret[i]]++;
                }
                else{
                    missing[secret[i]]=1;
                }
               
            }
        }

        int cows =0;
        for(int j=0;j<guess.Length;j++){
            if(!positions.Contains(j)){
                if(missing.ContainsKey(guess[j]) && missing[guess[j]] > 0){
                    cows++;
                    missing[guess[j]]--;
                }
            }
        }

        return bulls.ToString()+"A"+cows.ToString()+"B";
    }
}
