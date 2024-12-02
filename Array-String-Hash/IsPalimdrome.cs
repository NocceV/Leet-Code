public class Solution {
    public bool IsPalindrome(int x) {
        //oque é um palimdromo?
        //conta o espaço?
        //é so uma palavra?
        //pode ter qualquer caractere?
        //sao so numeros?

        //entao eu recebo um numero inteiro sendo negativo ou positivo
        //e verifico se ele é um palimdromo

        //inicio uma variavel = x.Length-1
        //inicio uma variavel booleana épalimdromo = true
        //inicio um for ate metade do tamanho de x
        //vou aumentando o for e diminuindo a variavel iniciada anteriormente
        //caso o caractere nas posições seja diferente eu retorno false
        //caso seja verdadeiro eu continuo ate o fim.
        //retorno a variavel booleana

        string str = x.ToString();
        int ponteiro = str.Length-1;
        int metade = str.Length/2;
        bool epalimdromo = true;
        for(int i = 0;i<=metade;i++){
            if(str[i] != str[ponteiro]){
                epalimdromo = false;
                return epalimdromo;
            }
            ponteiro--;
        }
        return epalimdromo;
    }
}
