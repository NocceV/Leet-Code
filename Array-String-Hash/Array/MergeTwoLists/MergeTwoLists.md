# Intuition
Ir comparando os valores das listas e ir adicionando em ordem em uma lista resultado. Tudo isso dentro de um laço while.

# Approach
O que pode mais confundir aqui é o retorno da lista, visto que devemos retornar o inicio dela, sendo assim criamos uma lista base, que vai mudar de acordo que mechemos na lista copiada. sobre a solução, devemos resolver dentro de um laço de repetição, atualizando a list1.next ou list2.next caso os valores atuais delas sejam adicionados na lista de resultados, além disso dando result.next para ir progredindo em ordem os vlaores.

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
        //Add the values in order
        //Time = O(n)
        // Space = O(n)


        // if (list1 == null) return list2;
        // if (list2 == null) return list1;
        // if(list1 ==null && list2==null){
        //     return null;
        // }

        // ListNode dummy = new ListNode(-1); // Nó fictício para facilitar a manipulação
        // ListNode result = dummy;

        // while(list1 != null && list2 != null){

        //     if(list1.val <= list2.val){
        //         result.next = list1;
        //         list1 = list1.next;
        //     }
        //     else{
        //         result.next = list2;
        //         list2 = list2.next;
        //     }
        //     result = result.next;
        // }

        // if (list1 != null) {
        //     result.next = list1;
        // }else {
        //     result.next = list2;
        // }

        // return dummy.next;


        //Revisao

        //First of all, we check if one or both of the lists are null
        //Create a new list base starting in the position (-1), because in the end we will return the list.next
        //Create a list result based in the new list
        //The list result will afetar the list base
        //Start a while loop, that will end if the list1 or the list2 are null
        //Check waht value is less
        //Update the list affected end continue result = result.next
        //After the while we just check what list contain the last value
        //Return the list base.next

        if(list1 ==null){
            return list2;
        }
        if(list2 == null){
            return list1;
        }

        ListNode base2 = new ListNode(-1);
        ListNode result = base2;

        while(list1!=null && list2 !=null){

            if(list1.val<=list2.val){
                result.next=list1;
                list1 = list1.next;
            }
            else{
                result.next=list2;
                list2 = list2.next;
            }

            result = result.next;
        }

        if(list1 != null){
            result.next = list1;
        }
        else{
            result.next = list2;
        }
        
        return base2.next;
    }
}
```
