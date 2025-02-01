# Intuition
Resolver usando  uma tabela hash que compara os valores

# Approach
Primeiro verifico se a lista passada tem menos de 2 numeros, se sim retorno false. Apos isso caso nao retorne, entro em um laço while que so finalizara quando o proximo valor for = null. Enquanto não é, comparo seo valor atual ja foi add na tablea hash, se sim retorno true. se nao add na tabela e continuo comparando ate o fim.

# Complexity
- Time complexity: O(n)

- Space complexity: O(n)

# Code
```csharp []
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        
        //a lista so tem numeros diferentes?
        //a listga pode ter nenhum numero?
        

        //entao eu tenho que ver se a lista contem ciclos

        //primeiro vou verificar se al ista tem 0 ou nenhum numero
            //se tiver returno false
        //se nao crio um laco while enquanto o .next != null
        //dentro do laco verifico se o valor ja existe na hash 
            //se sim retorno true
            //se nao eu addd o valor na hash e prossigo para o proximo
        //se chegar ao fim eu retorno false

        HashSet<ListNode> table = new HashSet<ListNode>();

        if(head == null || head.next == null){
            return false;
        }
        else{
            while(head.next != null){

                if(table.Contains(head)){
                    return true;
                }
                else{
                    table.Add(head);
                    head = head.next;
                }
            }
        }

        return false;
        
    }
}
```
