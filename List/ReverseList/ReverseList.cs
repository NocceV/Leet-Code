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
        
        //passar todos os valores para uma lista
        //criar um for loop
            //dentro do for loop ir renovando os valores e dando.next para renovar todos os valores
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
