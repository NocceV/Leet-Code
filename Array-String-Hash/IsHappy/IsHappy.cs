public class Solution {
    public bool IsHappy(int n) {
       
        //criar uma tabela hash que ira guardar os numeros inteiros
        //criar um loop no qual o numero atual n nao exista na tablea
        //se ele existtir o loop acaba
        //criar uma funçao que faz o calculo e retorna um novo valor
        //este novo valor é guardado na tabela hash
        //e vai assim ate o novo valor ser 1 e retornar true
        //se o numero ja existir na tabela retorna false

        HashSet<int> values = new HashSet<int>();
        values.Add(n);

        while(true){
            if(n==1){
                return true;
            }
            int resultado = calcularValor(n);
           
            if(values.Contains(resultado)){
                return false;
            }
            else{
                values.Add(resultado);
            }
            n = resultado;
        }

        return false;
    }

    public int calcularValor(int num){
        string numeroString = num.ToString();
        int tamanhoString = numeroString.Length;
        int sum=0;
        for(int i=0;i<tamanhoString;i++){
            int numeroAtual = int.Parse(numeroString[i].ToString());
            sum += (numeroAtual*numeroAtual);
        }

        return sum;
    }
}
