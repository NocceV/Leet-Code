public class Solution {
    public bool IsPalindrome(string s) {
        //eu tiro todos os espaços em branco?
        //eu tiro as letaas maiusculas?
        //a string pode vir com caracteres especiais?
        //a string pode vir numeros?

        //entao eu recebo uma string, 
        //coloco ela em letras minusculas
        //tiro os espacos em branco
        //tiro os caracteres especiais
        //comparo ela para ver se é um palimdromo

        //boto tudo em lowercase
        //faço virar um array que da split nos espaços em branco
        //crio um ponteiro esquerda e um ponteiro direita
        //vou comparando os ponteiros
        //se eles forem iguais continuo
        //se forem diferentes retorno false
        //se a posicao dos ponteiros possuir um caractere especial eu dou o ponteiro ++ ou --
        //caso va ate o final do repeidor quer dizer q é palindromo e eu retorno true

        s= s.ToLower();
        bool IsPalindrome = true;

        int left = 0;
        int right = s.Length-1;

        while(left < right){

            if(s[left] == ' ' || !char.IsLetterOrDigit(s[left])){
                left++;
            }
            else if(s[right] == ' ' || !char.IsLetterOrDigit(s[right])){
                right--;
            }
            else if(s[left] != s[right]){
                IsPalindrome = false;
                return IsPalindrome;
            }
            else{
                right--;
                left++;
            }
        }

        return IsPalindrome;
    }
}
