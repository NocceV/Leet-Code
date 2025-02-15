# Intuition
Usar ponteiros para solucionar

# Approach
Criei um array com numeros 1, e percorri indo e voltando o array de ratings, para o final ter o valor de cada slot.

![Imagem da solução](./Candy.png "Candy Image")
# Complexity
- Time complexity:
O(n)

- Space complexity:
O(n)

# Code
```csharp []
public class Solution {
    public int Candy(int[] ratings) {
        
        int[] result = new int[ratings.Length];
        Array.Fill(result, 1);

        for(int i = 1; i< ratings.Length;i++){

            if(ratings[i] > ratings[i-1]){
                result[i] = result[i - 1] + 1;
            }
        }


        int total = 0;
        for(int i  = ratings.Length-2;i>=0;i--){

            if(ratings[i] > ratings[i+1]){
                result[i] = Math.Max(result[i],result[i+1]+1);
            }

            total+=result[i+1];
        }

        total+=result[0];
        return total;
    }
}
```
