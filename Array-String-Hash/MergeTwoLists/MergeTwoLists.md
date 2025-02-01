# Intuition
Usar uma especie de ponteiros para iterar e adicionar os valores

# Approach
Ir incrementando em result os valores em ordem correta e ir atualizando ambas as listas, no final um onjeto criado anteriromente tera o resultado, pois ele aponta para o mesmo local da memoria que o onjeto result, podendo assim retornar toda a lista desde o inicio

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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        
        //Can the lists have the same number?
        //Can one off the lists have none numbers?
        //Can the lists have negative numbers?
        //can i return one of the lists modificated?
        

        //So i have to merge the 2 lists and return the result sorted

        //Create a new list node
        //Create two pointers, each one for the lits
        //Add the values in order
        //Time = O(n)
        // Space = O(n)

        //Create two pointers, each one for the lits
        //Add the values in order in the list1
        //Time = O(n)
        // Space = O(1)

        if (list1 == null) return list2;
        if (list2 == null) return list1;
        if(list1 ==null && list2==null){
            return null;
        }

        ListNode dummy = new ListNode(-1); // Nó fictício para facilitar a manipulação
        ListNode result = dummy;

        while(list1 != null && list2 != null){

            if(list1.val <= list2.val){
                result.next = list1;
                list1 = list1.next;
            }
            else{
                result.next = list2;
                list2 = list2.next;
            }
            result = result.next;
        }

        if (list1 != null) {
            result.next = list1;
        }else {
            result.next = list2;
        }
        
        return dummy.next;
    }
}
```
