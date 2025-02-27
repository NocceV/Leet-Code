# Intuition
Usar uma lista para guardar os valores ee dpois modifica-los dentro do proprio listNode

# Approach
Crio uma lista de inteiros e guardo todos os valores dos nodes em ordem dentro dela
Crio um listNode temp para iterar os valores e mudar em place o head, sem perder a posicão inicial
Começo a lista de tras para frente, mudando os valores dos nodos do listNode


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
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        
        //passar todos os valores para um array
        //criar um for loop
            //dentro do for loop ir renovando os valores e dando.next
        //retornar head atualizado

        
        List<int> values= new List<int>();

        ListNode temp = head;
        while(temp!=null){
            values.Add(temp.val);
            temp = temp.next;
        }

        temp = head;
        head = temp;
        for(int i = values.Count()-1;i>=0;i--){
            temp.val = values[i];
            temp = temp.next;
        }

        return head;
        
    }
}
```
