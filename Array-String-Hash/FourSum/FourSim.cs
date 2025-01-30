public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        
        //Os numeros podem repetir?
        //Pode vir um array null?;
        //Podem vir valores negativos?
        //Podem vir valores muito grandes?

        //Tenho que retornar uma lista de vetores que demonstram todas as possibilidades de soma para dar 
        //um valor igual a target

        //Ordenando vetor
        //Tem como ordenar o vetor, porém, a dificuldade esta em controlar os ponteiros

        //Primeiro vou ordenar o vetor
        //criar uma lista de lista de inteiros
        //Depois vou criar 4 variaveis ponteiros
        //Vou criar um laço while que vai iterar duas variaveis
        //e vai acabar quando uma for menor a outra
        //dentro do laço nos vamos somar e caso de a soma de target add na lista criada
        //Depois criar um segundo while e fazer a mesma coisa
        //No fim, retornar a lista

    IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);
        int n = nums.Length;

        for (int a = 0; a < n - 3; a++) {
            if (a > 0 && nums[a] == nums[a - 1]) continue; // Evitar duplicatas no primeiro número

            for (int b = a + 1; b < n - 2; b++) {
                if (b > a + 1 && nums[b] == nums[b - 1]) continue; // Evitar duplicatas no segundo número

                int c = b + 1;
                int d = n - 1;

                while (c < d) {
                    long sum = (long)nums[a] + nums[b] + nums[c] + nums[d]; // Evitar overflow

                    if (sum == target) {
                        result.Add(new List<int> { nums[a], nums[b], nums[c], nums[d] });
                        c++;
                        d--;

                        // Evitar duplicatas no terceiro e quarto número
                        while (c < d && nums[c] == nums[c - 1]) c++;
                        while (c < d && nums[d] == nums[d + 1]) d--;
                    }
                    else if (sum < target) {
                        c++;
                    }
                    else {
                        d--;
                    }
                }
            }
        }

        return result;
    }
}
