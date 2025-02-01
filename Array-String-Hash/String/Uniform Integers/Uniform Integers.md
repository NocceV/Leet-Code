# Intuition

# Approach

# Complexity
- Time complexity: O(log n)

- Space complexity: O(log n)
O(n logn)

# Code
```csharp []
class Solution {
  
  public int getUniformIntegerCountInInterval(long A, long B) {
    
       
        int digitosMax = B.ToString().Length;
        int result = 0;

        
        for (int i = 1; i <= digitosMax; i++){
            for (int j = 1; j <= 9; j++){
               
                long uniformNumber = long.Parse(new string(j.ToString()[0], i));
                // Verificar se está no intervalo
                if (uniformNumber >= A && uniformNumber <= B){
                    result++;
                }
                if (uniformNumber > B){
                    break;
                }
            }
        }

        return result;
  }
  
}

```
