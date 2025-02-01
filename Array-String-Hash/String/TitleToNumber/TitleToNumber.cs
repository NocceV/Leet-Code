public class Solution {
    public int TitleToNumber(string columnTitle) {
        //Pode vir um valor null?
        //Pode vir com espaço?
        //Pode vir ate quandos caracteres?
        //Vem todos em Uppercase?
        //Tem caracteres especiais?

        //Devo retornar o valor int da string passada

        //Crio uma variavel para o resultado
        //crio um foreach que ira transformar os valores int value = c - 'A' + 1;
        //faço o calculo do result
        //retorno result

        long result = 0;

        foreach(char c in columnTitle){
            int value = c - 'A' + 1;
            Console.WriteLine(value);

            result = result * 26 + value;
        }

        return (int)result;
    }
}
